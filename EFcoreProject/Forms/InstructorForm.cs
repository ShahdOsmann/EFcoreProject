using EFcoreProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EFcoreProject
{
    public partial class InstructorForm : Form
    {
        private readonly AppDbContext _context;
        private int selectedInstructorId = -1;

        public InstructorForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void InstructorForm_Load(object sender, EventArgs e)
        {
            LoadDepartments();
            LoadInstructors();
        }

        private void LoadDepartments()
        {
            var departments = _context.Departments.ToList();

            comboDepartments.DataSource = departments;
            comboDepartments.DisplayMember = "Name";
            comboDepartments.ValueMember = "DepartmentId";
        }

        private void LoadInstructors()
        {
            var instructors = _context.Instructors
                .Include(i => i.Department)
                .Select(i => new
                {
                    i.Id,
                    i.FirstName,
                    i.LastName,
                    i.Phone,
                    Department = i.Department.Name
                })
                .ToList();

            dataGridViewInstructors.DataSource = instructors;
            dataGridViewInstructors.ClearSelection();
        }

        private void dataGridViewInstructors_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedInstructorId =
                (int)dataGridViewInstructors.Rows[e.RowIndex].Cells["Id"].Value;

            var instructor = _context.Instructors
                .FirstOrDefault(i => i.Id == selectedInstructorId);

            if (instructor != null)
            {
                txtFirstName.Text = instructor.FirstName;
                txtLastName.Text = instructor.LastName;
                txtPhone.Text = instructor.Phone;

                comboDepartments.SelectedValue = instructor.DepartmentId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var instructor = new Instructor
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text,
                DepartmentId = (int)comboDepartments.SelectedValue
            };

            _context.Instructors.Add(instructor);
            _context.SaveChanges();

            LoadInstructors();
            ClearForm();

            MessageBox.Show("Instructor Added Successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedInstructorId == -1) return;

            var instructor = _context.Instructors
                .FirstOrDefault(i => i.Id == selectedInstructorId);

            if (instructor == null) return;

            instructor.FirstName = txtFirstName.Text;
            instructor.LastName = txtLastName.Text;
            instructor.Phone = txtPhone.Text;
            instructor.DepartmentId = (int)comboDepartments.SelectedValue;

            _context.SaveChanges();

            LoadInstructors();
            ClearForm();

            MessageBox.Show("Instructor Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedInstructorId == -1) return;

            var instructor = _context.Instructors
                .FirstOrDefault(i => i.Id == selectedInstructorId);

            if (instructor != null)
            {
                _context.Instructors.Remove(instructor);
                _context.SaveChanges();
            }

            LoadInstructors();
            ClearForm();

            MessageBox.Show("Instructor Deleted Successfully!");
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

            comboDepartments.SelectedIndex = -1;

            selectedInstructorId = -1;
            dataGridViewInstructors.ClearSelection();
        }
    }
}
