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
            SuspendLayout();
            // 
            // btnStudents
            // 
            btnStudents.Location = new Point(268, 262);
            btnStudents.Name = "btnStudents";
            btnStudents.Size = new Size(216, 94);
            btnStudents.TabIndex = 0;
            btnStudents.Text = "Student Form";
            btnStudents.UseVisualStyleBackColor = true;
            btnStudents.Click += btnStudents_Click;
            // 
            // btnCourses
            // 
            btnCourses.Location = new Point(268, 134);
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
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}