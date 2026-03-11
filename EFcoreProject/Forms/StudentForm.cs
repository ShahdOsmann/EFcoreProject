using EFcoreProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Windows.Forms;

namespace EFcoreProject
{
    public partial class StudentForm : Form
    {
        private readonly AppDbContext _context;
        private int selectedStudentId = -1;

        public StudentForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            LoadCoursesIntoCheckedListBox();
            LoadStudentsIntoDataGridView();
        }

        private void LoadCoursesIntoCheckedListBox()
        {
            var courses = _context.Courses.ToList();
            checkedListBoxCourses.DataSource = courses;
            checkedListBoxCourses.DisplayMember = "Name";
            checkedListBoxCourses.ValueMember = "Id";
        }

        private void LoadStudentsIntoDataGridView()
        {
            // Project students with courses as a comma-separated string
            var students = _context.Students
                .Include(s => s.CourseStudents)
                .ThenInclude(cs => cs.Course)
                .Select(s => new
                {
                    s.Id,
                    s.FirstName,
                    s.LastName,
                    s.Phone,
                    Courses = string.Join(", ", s.CourseStudents.Select(cs => cs.Course.Name))
                })
                .ToList();

            dataGridViewStudents.DataSource = students;

            // Optional: clear selection
            dataGridViewStudents.ClearSelection();
        }

        private void dataGridViewStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedStudentId = (int)dataGridViewStudents.Rows[e.RowIndex].Cells["Id"].Value;

            var student = _context.Students
                .Include(s => s.CourseStudents)
                .ThenInclude(cs => cs.Course)
                .FirstOrDefault(s => s.Id == selectedStudentId);

            if (student != null)
            {
                txtFirstName.Text = student.FirstName;
                txtLastName.Text = student.LastName;
                txtPhone.Text = student.Phone;

                // Update checked list box
                for (int i = 0; i < checkedListBoxCourses.Items.Count; i++)
                {
                    var course = (Course)checkedListBoxCourses.Items[i];
                    checkedListBoxCourses.SetItemChecked(i,
                        student.CourseStudents.Any(cs => cs.CourseId == course.Id));
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            var student = new Student
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text
            };

            foreach (Course course in checkedListBoxCourses.CheckedItems)
            {
                student.CourseStudents.Add(new CourseStudent
                {
                    CourseId = course.Id,
                    Student = student
                });
            }

            _context.Students.Add(student);
            _context.SaveChanges();

            ClearForm();
            LoadStudentsIntoDataGridView();
            MessageBox.Show("Student Added Successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedStudentId < 0) return;

            var student = _context.Students
                .Include(s => s.CourseStudents)
                .FirstOrDefault(s => s.Id == selectedStudentId);

            if (student == null) return;

            student.FirstName = txtFirstName.Text;
            student.LastName = txtLastName.Text;
            student.Phone = txtPhone.Text;

            // Remove old course links
            student.CourseStudents.Clear();

            foreach (Course course in checkedListBoxCourses.CheckedItems)
            {
                student.CourseStudents.Add(new CourseStudent
                {
                    CourseId = course.Id,
                    StudentId = student.Id
                });
            }

            _context.SaveChanges();
            ClearForm();
            LoadStudentsIntoDataGridView();
            MessageBox.Show("Student Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedStudentId < 0) return;

            var student = _context.Students.Find(selectedStudentId);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }

            ClearForm();
            LoadStudentsIntoDataGridView();
            MessageBox.Show("Student Deleted Successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();

            for (int i = 0; i < checkedListBoxCourses.Items.Count; i++)
                checkedListBoxCourses.SetItemChecked(i, false);

            selectedStudentId = -1;
            dataGridViewStudents.ClearSelection();
        }
    }
}