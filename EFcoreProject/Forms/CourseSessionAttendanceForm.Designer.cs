namespace EFcoreProject
{
    partial class CourseSessionAttendanceForm
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
            comboStudents = new ComboBox();
            comboSessions = new ComboBox();
            numGrade = new NumericUpDown();
            txtNotes = new TextBox();
            dataGridViewAttendance = new DataGridView();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)numGrade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).BeginInit();
            SuspendLayout();
            // 
            // comboStudents
            // 
            comboStudents.FormattingEnabled = true;
            comboStudents.Location = new Point(145, 30);
            comboStudents.Name = "comboStudents";
            comboStudents.Size = new Size(151, 28);
            comboStudents.TabIndex = 0;
            // 
            // comboSessions
            // 
            comboSessions.FormattingEnabled = true;
            comboSessions.Location = new Point(145, 88);
            comboSessions.Name = "comboSessions";
            comboSessions.Size = new Size(151, 28);
            comboSessions.TabIndex = 1;
            // 
            // numGrade
            // 
            numGrade.Location = new Point(146, 148);
            numGrade.Name = "numGrade";
            numGrade.Size = new Size(150, 27);
            numGrade.TabIndex = 2;
            // 
            // txtNotes
            // 
            txtNotes.Location = new Point(145, 206);
            txtNotes.Name = "txtNotes";
            txtNotes.Size = new Size(568, 27);
            txtNotes.TabIndex = 3;
            // 
            // dataGridViewAttendance
            // 
            dataGridViewAttendance.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAttendance.Location = new Point(-4, 308);
            dataGridViewAttendance.Name = "dataGridViewAttendance";
            dataGridViewAttendance.RowHeadersWidth = 51;
            dataGridViewAttendance.Size = new Size(887, 198);
            dataGridViewAttendance.TabIndex = 4;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(145, 258);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(274, 258);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(396, 258);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(512, 258);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 8;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 33);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 9;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 155);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 10;
            label2.Text = "Grade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 91);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 11;
            label3.Text = "Sesssion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 213);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 12;
            label4.Text = "Notes";
            // 
            // CourseSessionAttendanceForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(880, 505);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(dataGridViewAttendance);
            Controls.Add(txtNotes);
            Controls.Add(numGrade);
            Controls.Add(comboSessions);
            Controls.Add(comboStudents);
            Name = "CourseSessionAttendanceForm";
            Text = "CourseSessionAttendanceForm";
            Load += CourseSessionAttendanceForm_Load;
            ((System.ComponentModel.ISupportInitialize)numGrade).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAttendance).EndInit();
            ResumeLayout(false);
            PerformLayout();
            Load += CourseSessionAttendanceForm_Load;

            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;

            dataGridViewAttendance.CellClick += dataGridViewAttendance_CellClick;
        }

        #endregion

        private ComboBox comboStudents;
        private ComboBox comboSessions;
        private NumericUpDown numGrade;
        private TextBox txtNotes;
        private DataGridView dataGridViewAttendance;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}