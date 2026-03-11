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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            var studentForm = new StudentForm();
            studentForm.ShowDialog(); // Modal window
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            var courseForm = new CourseForm();
            courseForm.ShowDialog(); // Modal window
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btnInstuctor_Click(object sender, EventArgs e)
        {
            var InstructorForm = new InstructorForm();
            InstructorForm.ShowDialog(); // Modal window
        }

        private void btnDepartments_Click(object sender, EventArgs e)
        {
            var DepartmentForm = new DepartmentForm();
            DepartmentForm.ShowDialog(); // Modal window
        }

        private void btnCourseSessions_Click(object sender, EventArgs e)
        {
            var CourseSession = new CourseSessionForm();
            CourseSession.ShowDialog(); // Modal window
        }

        private void btnCourseSessionAttendence_Click(object sender, EventArgs e)
        {
            var CourseSessionAttendance = new CourseSessionAttendanceForm();
            CourseSessionAttendance.ShowDialog(); // Modal window
        }
    }
}
