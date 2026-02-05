namespace Team_Transcript_System {
    partial class frmAddStudent {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
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
            lblId = new Label();
            lblName = new Label();
            lblEmail = new Label();
            lblPassword = new Label();
            txtId = new TextBox();
            txtFullname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            comboBox1 = new ComboBox();
            lblCurrentClassYear = new Label();
            dgvSubjects = new DataGridView();
            btnAdd = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblId.Location = new Point(25, 41);
            lblId.Name = "lblId";
            lblId.Size = new Size(44, 25);
            lblId.TabIndex = 0;
            lblId.Text = "ID : ";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblName.Location = new Point(302, 41);
            lblName.Name = "lblName";
            lblName.Size = new Size(100, 25);
            lblName.TabIndex = 1;
            lblName.Text = "Full Name :";
            lblName.Click += lblName_Click;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEmail.Location = new Point(25, 75);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(68, 25);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email : ";
            lblEmail.Click += lblEmail_Click;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.Location = new Point(25, 110);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(101, 25);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password : ";
            // 
            // txtId
            // 
            txtId.Location = new Point(141, 41);
            txtId.Name = "txtId";
            txtId.Size = new Size(122, 27);
            txtId.TabIndex = 0;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(437, 41);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(208, 27);
            txtFullname.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(141, 76);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(502, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(141, 111);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(502, 27);
            txtPassword.TabIndex = 4;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(284, 147);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(162, 28);
            comboBox1.TabIndex = 5;
            // 
            // lblCurrentClassYear
            // 
            lblCurrentClassYear.AutoSize = true;
            lblCurrentClassYear.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrentClassYear.Location = new Point(25, 150);
            lblCurrentClassYear.Name = "lblCurrentClassYear";
            lblCurrentClassYear.Size = new Size(176, 25);
            lblCurrentClassYear.TabIndex = 6;
            lblCurrentClassYear.Text = "Current Class Year :   ";
            lblCurrentClassYear.Click += lblCurrentClassYear_Click;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AllowUserToResizeColumns = false;
            dgvSubjects.AllowUserToResizeRows = false;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(25, 198);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 51;
            dgvSubjects.Size = new Size(618, 278);
            dgvSubjects.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(360, 508);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(122, 37);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "&Save";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(530, 508);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(113, 37);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // frmAddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(669, 562);
            Controls.Add(btnCancel);
            Controls.Add(btnAdd);
            Controls.Add(dgvSubjects);
            Controls.Add(lblCurrentClassYear);
            Controls.Add(comboBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullname);
            Controls.Add(txtId);
            Controls.Add(lblPassword);
            Controls.Add(lblEmail);
            Controls.Add(lblName);
            Controls.Add(lblId);
            Name = "frmAddStudent";
            Text = "Add Student";
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private Label lblName;
        private Label lblEmail;
        private Label lblPassword;
        private TextBox txtId;
        private TextBox txtFullname;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private ComboBox comboBox1;
        private Label lblCurrentClassYear;
        private DataGridView dgvSubjects;
        private Button btnAdd;
        private Button btnCancel;
    }
}