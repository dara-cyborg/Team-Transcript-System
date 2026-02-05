namespace Team_Transcript_System {
    partial class frmMain {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btnAdd = new Button();
            dataGridView1 = new DataGridView();
            idCol = new DataGridViewTextBoxColumn();
            fullnameCol = new DataGridViewTextBoxColumn();
            gpa1Col = new DataGridViewTextBoxColumn();
            gpa2Col = new DataGridViewTextBoxColumn();
            gpa3Col = new DataGridViewTextBoxColumn();
            gpa4Col = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(682, 371);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(106, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { idCol, fullnameCol, gpa1Col, gpa2Col, gpa3Col, gpa4Col });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 353);
            dataGridView1.TabIndex = 2;
            // 
            // idCol
            // 
            idCol.HeaderText = "ID";
            idCol.MinimumWidth = 6;
            idCol.Name = "idCol";
            idCol.ReadOnly = true;
            idCol.Width = 80;
            // 
            // fullnameCol
            // 
            fullnameCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            fullnameCol.HeaderText = "Full Name";
            fullnameCol.MinimumWidth = 6;
            fullnameCol.Name = "fullnameCol";
            fullnameCol.ReadOnly = true;
            // 
            // gpa1Col
            // 
            gpa1Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gpa1Col.HeaderText = "GPA Year 1";
            gpa1Col.MinimumWidth = 6;
            gpa1Col.Name = "gpa1Col";
            gpa1Col.ReadOnly = true;
            gpa1Col.Width = 109;
            // 
            // gpa2Col
            // 
            gpa2Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gpa2Col.HeaderText = "GPA Year 2";
            gpa2Col.MinimumWidth = 6;
            gpa2Col.Name = "gpa2Col";
            gpa2Col.ReadOnly = true;
            gpa2Col.Width = 109;
            // 
            // gpa3Col
            // 
            gpa3Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gpa3Col.HeaderText = "GPA Year 3";
            gpa3Col.MinimumWidth = 6;
            gpa3Col.Name = "gpa3Col";
            gpa3Col.ReadOnly = true;
            gpa3Col.Width = 109;
            // 
            // gpa4Col
            // 
            gpa4Col.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            gpa4Col.HeaderText = "GPA Year 4";
            gpa4Col.MinimumWidth = 6;
            gpa4Col.Name = "gpa4Col";
            gpa4Col.ReadOnly = true;
            gpa4Col.Width = 109;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 419);
            Controls.Add(dataGridView1);
            Controls.Add(btnAdd);
            Name = "frmMain";
            Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAdd;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn idCol;
        private DataGridViewTextBoxColumn fullnameCol;
        private DataGridViewTextBoxColumn gpa1Col;
        private DataGridViewTextBoxColumn gpa2Col;
        private DataGridViewTextBoxColumn gpa3Col;
        private DataGridViewTextBoxColumn gpa4Col;
    }
}
