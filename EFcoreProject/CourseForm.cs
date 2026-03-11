using EFcoreProject.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFcoreProject
{
    public partial class CourseForm : Form
    {
        private readonly AppDbContext _context;
        public CourseForm()
        {
            InitializeComponent();
            _context = new AppDbContext();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CourseForm_Load(object sender, EventArgs e)
        {
            LoadInstructors();
            LoadDepartments();
            LoadCourses();
        }
        private void LoadInstructors()
        {
            comboBoxInstructor.DataSource = _context.Instructors.ToList();
            comboBoxInstructor.DisplayMember = "FirstName";  
            comboBoxInstructor.ValueMember = "Id";  
            comboBoxInstructor.SelectedIndex = -1; 
        }

         private void LoadDepartments()
        {
            comboBoxDepartment.DataSource = _context.Departments.ToList();
            comboBoxDepartment.DisplayMember = "Name";
            comboBoxDepartment.ValueMember = "DepartmentId";
            comboBoxDepartment.SelectedIndex = -1;
        }

         private void LoadCourses()
        {
            var courses = _context.Courses
                .Select(c => new
                {
                    c.Id,
                    c.Name,
                    c.Duration,
                    Instructor = c.Instructor.FirstName + " " + c.Instructor.LastName,
                    Department = c.Department.Name
                }).ToList();

            dataGridView1.DataSource = courses;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || comboBoxInstructor.SelectedIndex == -1 || comboBoxDepartment.SelectedIndex == -1)
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var course = new Course
            {
                Name = txtName.Text,
                Duration = int.TryParse(txtDuration.Text, out int dur) ? dur : null,
                InstructorId = (int)comboBoxInstructor.SelectedValue,
                DepartmentId = (int)comboBoxDepartment.SelectedValue
            };

            _context.Courses.Add(course);
            _context.SaveChanges();
            LoadCourses();
            ClearForm();
            MessageBox.Show("Course Added Successfully!");
        }

         private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                course.Name = txtName.Text;
                course.Duration = int.TryParse(txtDuration.Text, out int dur) ? dur : null;
                course.InstructorId = (int)comboBoxInstructor.SelectedValue;
                course.DepartmentId = (int)comboBoxDepartment.SelectedValue;

                _context.SaveChanges();
                LoadCourses();
                ClearForm();
                MessageBox.Show("Course Updated Successfully!");
            }
        }

         private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            int id = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            var course = _context.Courses.Find(id);
            if (course != null)
            {
                _context.Courses.Remove(course);
                _context.SaveChanges();
                LoadCourses();
                ClearForm();
                MessageBox.Show("Course Deleted Successfully!");
            }
        }

         private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

         private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null) return;

            txtName.Text = dataGridView1.CurrentRow.Cells["Name"].Value.ToString();
            txtDuration.Text = dataGridView1.CurrentRow.Cells["Duration"].Value?.ToString();

            int selectedCourseId = (int)dataGridView1.CurrentRow.Cells["Id"].Value;
            var course = _context.Courses.Find(selectedCourseId);
            if (course != null)
            {
                comboBoxInstructor.SelectedValue = course.InstructorId;
                comboBoxDepartment.SelectedValue = course.DepartmentId;
            }
        }

         private void ClearForm()
        {
            txtName.Clear();
            txtDuration.Clear();
            comboBoxInstructor.SelectedIndex = -1;
            comboBoxDepartment.SelectedIndex = -1;
            dataGridView1.ClearSelection();
        }
    }
}
