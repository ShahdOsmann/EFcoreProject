namespace EFcoreProject
{
    partial class HomeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStudents = new Button();
            btnCourses = new Button();
            label1 = new Label();
            btnInstuctor = new Button();
            btnDepartments = new Button();
            btnCourseSessions = new Button();
            btnCourseSessionAttendence = new Button();
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(37, 278);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(216, 94);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Student Form";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(37, 139);
            btnCourses.Name = "btnCourses";
            btnCourses.Size = new Size(216, 103);
            btnCourses.TabIndex = 1;
            btnCourses.Text = "Course Form";
            btnCourses.UseVisualStyleBackColor = true;
            btnCourses.Click += btnCourses_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(332, 57);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 2;
            label1.Text = "Home Page";
            // 
            // btnInstuctor
            // 
            btnInstuctor.Location = new Point(292, 139);
            btnInstuctor.Name = "btnInstuctor";
            btnInstuctor.Size = new Size(216, 103);
            btnInstuctor.TabIndex = 3;
            btnInstuctor.Text = "Instructor Form";
            btnInstuctor.UseVisualStyleBackColor = true;
            btnInstuctor.Click += btnInstuctor_Click;
            // 
            // btnDepartments
            // 
            btnDepartments.Location = new Point(292, 269);
            btnDepartments.Name = "btnDepartments";
            btnDepartments.Size = new Size(216, 103);
            btnDepartments.TabIndex = 4;
            btnDepartments.Text = "Department Form";
            btnDepartments.UseVisualStyleBackColor = true;
            btnDepartments.Click += btnDepartments_Click;
            // 
            // btnCourseSessions
            // 
            btnCourseSessions.Location = new Point(545, 139);
            btnCourseSessions.Name = "btnCourseSessions";
            btnCourseSessions.Size = new Size(216, 103);
            btnCourseSessions.TabIndex = 5;
            btnCourseSessions.Text = "CourseSession Form";
            btnCourseSessions.UseVisualStyleBackColor = true;
            btnCourseSessions.Click += btnCourseSessions_Click;
            // 
            // btnCourseSessionAttendence
            // 
            btnCourseSessionAttendence.Location = new Point(545, 269);
            btnCourseSessionAttendence.Name = "btnCourseSessionAttendence";
            btnCourseSessionAttendence.Size = new Size(216, 103);
            btnCourseSessionAttendence.TabIndex = 6;
            btnCourseSessionAttendence.Text = "CourseSessionAttendence Form";
            btnCourseSessionAttendence.UseVisualStyleBackColor = true;
            btnCourseSessionAttendence.Click += btnCourseSessionAttendence_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCourseSessionAttendence);
            Controls.Add(btnCourseSessions);
            Controls.Add(btnDepartments);
            Controls.Add(btnInstuctor);
            Controls.Add(label1);
            Controls.Add(btnCourses);
            Controls.Add(btnStudents);
            Name = "HomeForm";
            Text = "HomeForm";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudents;
        private Button btnCourses;
        private Label label1;
        private Button btnInstuctor;
        private Button btnDepartments;
        private Button btnCourseSessions;
        private Button btnCourseSessionAttendence;
    }
}