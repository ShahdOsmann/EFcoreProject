using EFcoreProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
 
namespace EFcoreProject
{
    public partial class CourseSessionAttendanceForm : Form
    {
        private readonly AppDbContext _context;
        private int selectedAttendanceId = -1;

        public CourseSessionAttendanceForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void CourseSessionAttendanceForm_Load(object sender, EventArgs e)
        {
            LoadStudents();
            LoadSessions();
            LoadAttendance();
        }

        private void LoadStudents()
        {
            comboStudents.DataSource = _context.Students.ToList();
            comboStudents.DisplayMember = "Name";
            comboStudents.ValueMember = "Id";
        }

        private void LoadSessions()
        {
            comboSessions.DataSource = _context.CourseSessions
                .Include(s => s.Course)
                .Select(s => new
                {
                    s.Id,
                    Display = s.title + " - " + s.Date
                })
                .ToList();

            comboSessions.DisplayMember = "Display";
            comboSessions.ValueMember = "Id";
        }

        private void LoadAttendance()
        {
            var data = _context.CourseSessionAttendances
                .Include(a => a.Student)
                .Include(a => a.CourseSession)
                .ThenInclude(s => s.Course)
                .Select(a => new
                {
                    a.Id,
                    Student = a.Student.FirstName,
                    Session = a.CourseSession.title,
                    a.Grade,
                    a.Notes
                })
                .ToList();

            dataGridViewAttendance.DataSource = data;
            dataGridViewAttendance.ClearSelection();
        }

        private void dataGridViewAttendance_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedAttendanceId =
                (int)dataGridViewAttendance.Rows[e.RowIndex].Cells["Id"].Value;

            var attendance = _context.CourseSessionAttendances
                .FirstOrDefault(a => a.Id == selectedAttendanceId);

            if (attendance != null)
            {
                comboStudents.SelectedValue = attendance.StudentId;
                comboSessions.SelectedValue = attendance.CourseSessionId;

                if (attendance.Grade.HasValue)
                    numGrade.Value = attendance.Grade.Value;

                txtNotes.Text = attendance.Notes;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var attendance = new CourseSessionAttendance
            {
                StudentId = (int)comboStudents.SelectedValue,
                CourseSessionId = (int)comboSessions.SelectedValue,
                Grade = (int)numGrade.Value,
                Notes = txtNotes.Text
            };

            _context.CourseSessionAttendances.Add(attendance);
            _context.SaveChanges();

            LoadAttendance();
            ClearForm();

            MessageBox.Show("Attendance added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId == -1) return;

            var attendance = _context.CourseSessionAttendances
                .FirstOrDefault(a => a.Id == selectedAttendanceId);

            if (attendance == null) return;

            attendance.StudentId = (int)comboStudents.SelectedValue;
            attendance.CourseSessionId = (int)comboSessions.SelectedValue;
            attendance.Grade = (int)numGrade.Value;
            attendance.Notes = txtNotes.Text;

            _context.SaveChanges();

            LoadAttendance();
            ClearForm();

            MessageBox.Show("Attendance updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedAttendanceId == -1) return;

            var attendance = _context.CourseSessionAttendances
                .FirstOrDefault(a => a.Id == selectedAttendanceId);

            if (attendance != null)
            {
                _context.CourseSessionAttendances.Remove(attendance);
                _context.SaveChanges();
            }

            LoadAttendance();
            ClearForm();

            MessageBox.Show("Attendance deleted successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            comboStudents.SelectedIndex = -1;
            comboSessions.SelectedIndex = -1;

            numGrade.Value = 0;
            txtNotes.Clear();

            selectedAttendanceId = -1;

            dataGridViewAttendance.ClearSelection();
        }
    }
}