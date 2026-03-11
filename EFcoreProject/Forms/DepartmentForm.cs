using EFcoreProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq; 

namespace EFcoreProject
{
    public partial class DepartmentForm : Form
    {
        private readonly AppDbContext _context;
        private int selectedDepartmentId = -1;

        public DepartmentForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void DepartmentForm_Load(object sender, EventArgs e)
        {
            LoadManagers();
            LoadDepartments();
        }

        private void LoadManagers()
        {
            var instructors = _context.Instructors.ToList();

            comboManagers.DataSource = instructors;
            comboManagers.DisplayMember = "FirstName";
            comboManagers.ValueMember = "Id";
        }

        private void LoadDepartments()
        {
            var departments = _context.Departments
                .Include(d => d.Manager)
                .Select(d => new
                {
                    d.DepartmentId,
                    d.Name,
                    d.location,
                    Manager = d.Manager != null ? d.Manager.FirstName : ""
                })
                .ToList();

            dataGridViewDepartments.DataSource = departments;
            dataGridViewDepartments.ClearSelection();
        }

        private void dataGridViewDepartments_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedDepartmentId =
                (int)dataGridViewDepartments.Rows[e.RowIndex].Cells["DepartmentId"].Value;

            var department = _context.Departments
                .FirstOrDefault(d => d.DepartmentId == selectedDepartmentId);

            if (department != null)
            {
                txtName.Text = department.Name;
                txtLocation.Text = department.location;

                if (department.ManagerId != null)
                    comboManagers.SelectedValue = department.ManagerId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var department = new Department
            {
                Name = txtName.Text,
                location = txtLocation.Text,
                ManagerId = (int?)comboManagers.SelectedValue
            };

            _context.Departments.Add(department);
            _context.SaveChanges();

            LoadDepartments();
            ClearForm();

            MessageBox.Show("Department Added Successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentId == -1) return;

            var department = _context.Departments
                .FirstOrDefault(d => d.DepartmentId == selectedDepartmentId);

            if (department == null) return;

            department.Name = txtName.Text;
            department.location = txtLocation.Text;
            department.ManagerId = (int?)comboManagers.SelectedValue;

            _context.SaveChanges();

            LoadDepartments();
            ClearForm();

            MessageBox.Show("Department Updated Successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedDepartmentId == -1) return;

            var department = _context.Departments
                .FirstOrDefault(d => d.DepartmentId == selectedDepartmentId);

            if (department != null)
            {
                _context.Departments.Remove(department);
                _context.SaveChanges();
            }

            LoadDepartments();
            ClearForm();

            MessageBox.Show("Department Deleted Successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtLocation.Clear();

            comboManagers.SelectedIndex = -1;

            selectedDepartmentId = -1;
            dataGridViewDepartments.ClearSelection();
        }
    }
}