namespace Team_Transcript_System {
    partial class frmEditStudent {
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
            label1 = new Label();
            txtId = new TextBox();
            btnSave = new Button();
            dgvSubjects = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtFullName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnExit = new Button();
            cboCurrentYear = new ComboBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 41);
            label1.TabIndex = 0;
            label1.Text = "ID : ";
            // 
            // txtId
            // 
            txtId.Location = new Point(200, 40);
            txtId.Name = "txtId";
            txtId.Size = new Size(127, 47);
            txtId.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(560, 875);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(188, 58);
            btnSave.TabIndex = 2;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // dgvSubjects
            // 
            dgvSubjects.AllowUserToAddRows = false;
            dgvSubjects.AllowUserToDeleteRows = false;
            dgvSubjects.AllowUserToResizeColumns = false;
            dgvSubjects.AllowUserToResizeRows = false;
            dgvSubjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubjects.Location = new Point(30, 298);
            dgvSubjects.Name = "dgvSubjects";
            dgvSubjects.RowHeadersWidth = 102;
            dgvSubjects.Size = new Size(960, 528);
            dgvSubjects.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(400, 40);
            label2.Name = "label2";
            label2.Size = new Size(166, 41);
            label2.TabIndex = 4;
            label2.Text = "Full Name :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 100);
            label3.Name = "label3";
            label3.Size = new Size(103, 41);
            label3.TabIndex = 5;
            label3.Text = "Email :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 160);
            label4.Name = "label4";
            label4.Size = new Size(158, 41);
            label4.TabIndex = 6;
            label4.Text = "Password :";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(640, 40);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(350, 47);
            txtFullName.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(200, 160);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(790, 47);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(200, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(790, 47);
            txtPassword.TabIndex = 4;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(802, 875);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(188, 58);
            btnExit.TabIndex = 10;
            btnExit.Text = "E&xit";
            btnExit.UseVisualStyleBackColor = true;
            // 
            // cboCurrentYear
            // 
            cboCurrentYear.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCurrentYear.FormattingEnabled = true;
            cboCurrentYear.Location = new Point(416, 220);
            cboCurrentYear.Name = "cboCurrentYear";
            cboCurrentYear.Size = new Size(250, 49);
            cboCurrentYear.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 220);
            label5.Name = "label5";
            label5.Size = new Size(262, 41);
            label5.TabIndex = 12;
            label5.Text = "Current Class Year:";
            // 
            // frmEditStudent
            // 
            AcceptButton = btnExit;
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnSave;
            ClientSize = new Size(1011, 962);
            Controls.Add(label5);
            Controls.Add(cboCurrentYear);
            Controls.Add(btnExit);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtFullName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dgvSubjects);
            Controls.Add(btnSave);
            Controls.Add(txtId);
            Controls.Add(label1);
            Name = "frmEditStudent";
            Text = "Edit Student";
            ((System.ComponentModel.ISupportInitialize)dgvSubjects).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtId;
        private Button btnSave;
        private DataGridView dgvSubjects;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtFullName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnExit;
        private ComboBox cboCurrentYear;
        private Label label5;
    }
}