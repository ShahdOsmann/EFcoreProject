namespace EFcoreProject
{
    partial class CourseSessionForm
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
            comboCourses = new ComboBox();
            comboInstructors = new ComboBox();
            dateSession = new DateTimePicker();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridViewSessions = new DataGridView();
            txtTitle = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSessions).BeginInit();
            SuspendLayout();
            // 
            // comboCourses
            // 
            comboCourses.FormattingEnabled = true;
            comboCourses.Location = new Point(107, 56);
            comboCourses.Name = "comboCourses";
            comboCourses.Size = new Size(151, 28);
            comboCourses.TabIndex = 0;
            // 
            // comboInstructors
            // 
            comboInstructors.FormattingEnabled = true;
            comboInstructors.Location = new Point(106, 108);
            comboInstructors.Name = "comboInstructors";
            comboInstructors.Size = new Size(151, 28);
            comboInstructors.TabIndex = 1;
            // 
            // dateSession
            // 
            dateSession.Location = new Point(107, 171);
            dateSession.Name = "dateSession";
            dateSession.Size = new Size(250, 27);
            dateSession.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(107, 230);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(231, 230);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(355, 230);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(466, 230);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 7;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 59);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 8;
            label1.Text = "Courses";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 111);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 9;
            label2.Text = "Instructors";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 171);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 10;
            label3.Text = "Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 16);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 11;
            label4.Text = "Title";
            // 
            // dataGridViewSessions
            // 
            dataGridViewSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewSessions.Location = new Point(-5, 277);
            dataGridViewSessions.Name = "dataGridViewSessions";
            dataGridViewSessions.RowHeadersWidth = 51;
            dataGridViewSessions.Size = new Size(806, 212);
            dataGridViewSessions.TabIndex = 12;
            dataGridViewSessions.CellClick += dataGridViewSessions_CellClick;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(107, 16);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 13;
            // 
            // CourseSessionForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 488);
            Controls.Add(txtTitle);
            Controls.Add(dataGridViewSessions);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dateSession);
            Controls.Add(comboInstructors);
            Controls.Add(comboCourses);
            Name = "CourseSessionForm";
            Text = "CourseSessionForm";
            Load += CourseSessionForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewSessions).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboCourses;
        private ComboBox comboInstructors;
        private DateTimePicker dateSession;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridViewSessions;
        private TextBox txtTitle;
    }
}