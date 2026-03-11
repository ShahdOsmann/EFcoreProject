using EFcoreProject.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
 
namespace EFcoreProject
{
    public partial class CourseSessionForm : Form
    {
        private readonly AppDbContext _context;
        private int selectedSessionId = -1;

        public CourseSessionForm()
        {
            InitializeComponent();
            _context = new AppDbContext();
        }

        private void CourseSessionForm_Load(object sender, EventArgs e)
        {
            LoadCourses();
            LoadInstructors();
            LoadSessions();
        }

        private void LoadCourses()
        {
            comboCourses.DataSource = _context.Courses.ToList();
            comboCourses.DisplayMember = "Name";
            comboCourses.ValueMember = "Id";
        }

        private void LoadInstructors()
        {
            comboInstructors.DataSource = _context.Instructors.ToList();
            comboInstructors.DisplayMember = "FirstName";
            comboInstructors.ValueMember = "Id";
        }

        private void LoadSessions()
        {
            var sessions = _context.CourseSessions
                .Include(s => s.Course)
                .Include(s => s.Instructor)
                .Select(s => new
                {
                    s.Id,
                    Title = s.title,
                    s.Date,
                    Course = s.Course.Name,
                    Instructor = s.Instructor.FirstName
                })
                .ToList();

            dataGridViewSessions.DataSource = sessions;
            dataGridViewSessions.ClearSelection();
        }

        private void dataGridViewSessions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectedSessionId =
                (int)dataGridViewSessions.Rows[e.RowIndex].Cells["Id"].Value;

            var session = _context.CourseSessions
                .FirstOrDefault(s => s.Id == selectedSessionId);

            if (session != null)
            {
                txtTitle.Text = session.title;
                dateSession.Value = session.Date;
                comboCourses.SelectedValue = session.CourseId;
                comboInstructors.SelectedValue = session.InstructorId;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var session = new CourseSession
            {
                title = txtTitle.Text,
                Date = dateSession.Value,
                CourseId = (int)comboCourses.SelectedValue,
                InstructorId = (int)comboInstructors.SelectedValue
            };

            _context.CourseSessions.Add(session);
            _context.SaveChanges();

            LoadSessions();
            ClearForm();

            MessageBox.Show("Session added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedSessionId == -1) return;

            var session = _context.CourseSessions
                .FirstOrDefault(s => s.Id == selectedSessionId);

            if (session == null) return;

            session.title = txtTitle.Text;
            session.Date = dateSession.Value;
            session.CourseId = (int)comboCourses.SelectedValue;
            session.InstructorId = (int)comboInstructors.SelectedValue;

            _context.SaveChanges();

            LoadSessions();
            ClearForm();

            MessageBox.Show("Session updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedSessionId == -1) return;

            var session = _context.CourseSessions
                .FirstOrDefault(s => s.Id == selectedSessionId);

            if (session != null)
            {
                _context.CourseSessions.Remove(session);
                _context.SaveChanges();
            }

            LoadSessions();
            ClearForm();

            MessageBox.Show("Session deleted successfully!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtTitle.Clear();
            dateSession.Value = DateTime.Now;

            comboCourses.SelectedIndex = -1;
            comboInstructors.SelectedIndex = -1;

            selectedSessionId = -1;

            dataGridViewSessions.ClearSelection();
        }
    }
}