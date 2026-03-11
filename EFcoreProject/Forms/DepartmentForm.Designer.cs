namespace EFcoreProject
{
    partial class DepartmentForm
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
            txtName = new TextBox();
            txtLocation = new TextBox();
            comboManagers = new ComboBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            dataGridViewDepartments = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(123, 45);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 0;
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(123, 108);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(125, 27);
            txtLocation.TabIndex = 1;
            // 
            // comboManagers
            // 
            comboManagers.FormattingEnabled = true;
            comboManagers.Location = new Point(123, 173);
            comboManagers.Name = "comboManagers";
            comboManagers.Size = new Size(151, 28);
            comboManagers.TabIndex = 2;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(123, 244);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(252, 244);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 4;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(394, 244);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(520, 244);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(94, 29);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 7;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 108);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 8;
            label2.Text = "Location";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 181);
            label3.Name = "label3";
            label3.Size = new Size(68, 20);
            label3.TabIndex = 9;
            label3.Text = "Manager";
            // 
            // dataGridViewDepartments
            // 
            dataGridViewDepartments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDepartments.Location = new Point(-1, 296);
            dataGridViewDepartments.Name = "dataGridViewDepartments";
            dataGridViewDepartments.RowHeadersWidth = 51;
            dataGridViewDepartments.Size = new Size(853, 201);
            dataGridViewDepartments.TabIndex = 10;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(854, 500);
            Controls.Add(dataGridViewDepartments);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(comboManagers);
            Controls.Add(txtLocation);
            Controls.Add(txtName);
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            Load += DepartmentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewDepartments).EndInit();
            ResumeLayout(false);
            PerformLayout();
            btnAdd.Click += btnAdd_Click;
            btnUpdate.Click += btnUpdate_Click;
            btnDelete.Click += btnDelete_Click;
            btnClear.Click += btnClear_Click;
            dataGridViewDepartments.CellClick += dataGridViewDepartments_CellClick;
        }

        #endregion

        private TextBox txtName;
        private TextBox txtLocation;
        private ComboBox comboManagers;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnClear;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView dataGridViewDepartments;
    }
}