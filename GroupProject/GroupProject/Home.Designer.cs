namespace GroupProject
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            tabControl1 = new TabControl();
            tabStudent = new TabPage();
            lblStudentTabTitle = new Label();
            btnAddStudentHome = new Button();
            dgvStudent = new DataGridView();
            tabSubject = new TabPage();
            lblSubjectTabTitle = new Label();
            btnAddSubjectHome = new Button();
            dgvSubject = new DataGridView();
            tabSessions = new TabPage();
            lblSessionTabTitle = new Label();
            btnAddSessionHome = new Button();
            dgvSessions = new DataGridView();
            tabControl1.SuspendLayout();
            tabStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            tabSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            tabSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStudent);
            tabControl1.Controls.Add(tabSubject);
            tabControl1.Controls.Add(tabSessions);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(998, 484);
            tabControl1.TabIndex = 0;
            // 
            // tabStudent
            // 
            tabStudent.Controls.Add(lblStudentTabTitle);
            tabStudent.Controls.Add(btnAddStudentHome);
            tabStudent.Controls.Add(dgvStudent);
            tabStudent.Location = new Point(4, 34);
            tabStudent.Margin = new Padding(4);
            tabStudent.Name = "tabStudent";
            tabStudent.Padding = new Padding(4);
            tabStudent.Size = new Size(990, 446);
            tabStudent.TabIndex = 0;
            tabStudent.Text = "Student";
            tabStudent.UseVisualStyleBackColor = true;
            tabStudent.Click += tabStudent_Click;
            // 
            // lblStudentTabTitle
            // 
            lblStudentTabTitle.AutoSize = true;
            lblStudentTabTitle.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblStudentTabTitle.ForeColor = Color.MidnightBlue;
            lblStudentTabTitle.Location = new Point(20, 15);
            lblStudentTabTitle.Name = "lblStudentTabTitle";
            lblStudentTabTitle.Size = new Size(273, 23);
            lblStudentTabTitle.TabIndex = 2;
            lblStudentTabTitle.Text = "Study Group | Add Student";
            // 
            // btnAddStudentHome
            // 
            btnAddStudentHome.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddStudentHome.ForeColor = Color.MidnightBlue;
            btnAddStudentHome.Location = new Point(730, 390);
            btnAddStudentHome.Margin = new Padding(4);
            btnAddStudentHome.Name = "btnAddStudentHome";
            btnAddStudentHome.Size = new Size(205, 35);
            btnAddStudentHome.TabIndex = 1;
            btnAddStudentHome.Text = "Add Student";
            btnAddStudentHome.UseVisualStyleBackColor = true;
            btnAddStudentHome.Click += btnAddStudentHome_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(20, 50);
            dgvStudent.Margin = new Padding(4);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.Size = new Size(960, 320);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // tabSubject
            // 
            tabSubject.Controls.Add(lblSubjectTabTitle);
            tabSubject.Controls.Add(btnAddSubjectHome);
            tabSubject.Controls.Add(dgvSubject);
            tabSubject.Location = new Point(4, 34);
            tabSubject.Margin = new Padding(4);
            tabSubject.Name = "tabSubject";
            tabSubject.Padding = new Padding(4);
            tabSubject.Size = new Size(990, 446);
            tabSubject.TabIndex = 1;
            tabSubject.Text = "Subject";
            tabSubject.UseVisualStyleBackColor = true;
            tabSubject.Click += tabSubject_Click;
            // 
            // lblSubjectTabTitle
            // 
            lblSubjectTabTitle.AutoSize = true;
            lblSubjectTabTitle.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSubjectTabTitle.ForeColor = Color.MidnightBlue;
            lblSubjectTabTitle.Location = new Point(20, 15);
            lblSubjectTabTitle.Name = "lblSubjectTabTitle";
            lblSubjectTabTitle.Size = new Size(273, 23);
            lblSubjectTabTitle.TabIndex = 4;
            lblSubjectTabTitle.Text = "Study Group | Add Subject";
            // 
            // btnAddSubjectHome
            // 
            btnAddSubjectHome.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSubjectHome.ForeColor = Color.MidnightBlue;
            btnAddSubjectHome.Location = new Point(730, 390);
            btnAddSubjectHome.Margin = new Padding(4);
            btnAddSubjectHome.Name = "btnAddSubjectHome";
            btnAddSubjectHome.Size = new Size(205, 35);
            btnAddSubjectHome.TabIndex = 3;
            btnAddSubjectHome.Text = "Add Subject";
            btnAddSubjectHome.UseVisualStyleBackColor = true;
            btnAddSubjectHome.Click += btnAddSubjectHome_Click;
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(20, 50);
            dgvSubject.Margin = new Padding(4);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.RowTemplate.Height = 29;
            dgvSubject.Size = new Size(960, 320);
            dgvSubject.TabIndex = 2;
            dgvSubject.CellContentClick += dgvSubject_CellContentClick;
            // 
            // tabSessions
            // 
            tabSessions.Controls.Add(lblSessionTabTitle);
            tabSessions.Controls.Add(btnAddSessionHome);
            tabSessions.Controls.Add(dgvSessions);
            tabSessions.Location = new Point(4, 34);
            tabSessions.Margin = new Padding(4);
            tabSessions.Name = "tabSessions";
            tabSessions.Padding = new Padding(4);
            tabSessions.Size = new Size(990, 446);
            tabSessions.TabIndex = 2;
            tabSessions.Text = "Sessions";
            tabSessions.UseVisualStyleBackColor = true;
            tabSessions.Click += tabSessions_Click;
            // 
            // lblSessionTabTitle
            // 
            lblSessionTabTitle.AutoSize = true;
            lblSessionTabTitle.BackColor = Color.Transparent;
            lblSessionTabTitle.Font = new Font("Century Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSessionTabTitle.ForeColor = Color.MidnightBlue;
            lblSessionTabTitle.Location = new Point(20, 15);
            lblSessionTabTitle.Name = "lblSessionTabTitle";
            lblSessionTabTitle.Size = new Size(272, 23);
            lblSessionTabTitle.TabIndex = 4;
            lblSessionTabTitle.Text = "Study Group | Add Session";
            // 
            // btnAddSessionHome
            // 
            btnAddSessionHome.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAddSessionHome.ForeColor = Color.MidnightBlue;
            btnAddSessionHome.Location = new Point(730, 390);
            btnAddSessionHome.Margin = new Padding(4);
            btnAddSessionHome.Name = "btnAddSessionHome";
            btnAddSessionHome.Size = new Size(205, 35);
            btnAddSessionHome.TabIndex = 3;
            btnAddSessionHome.Text = "Add Session";
            btnAddSessionHome.UseVisualStyleBackColor = true;
            btnAddSessionHome.Click += btnAddSessionHome_Click;
            // 
            // dgvSessions
            // 
            dgvSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSessions.Location = new Point(20, 50);
            dgvSessions.Margin = new Padding(4);
            dgvSessions.Name = "dgvSessions";
            dgvSessions.RowHeadersWidth = 51;
            dgvSessions.RowTemplate.Height = 29;
            dgvSessions.Size = new Size(960, 320);
            dgvSessions.TabIndex = 2;
            dgvSessions.CellContentClick += dgvSessions_CellContentClick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1011, 481);
            Controls.Add(tabControl1);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Study Group | Home";
            Load += Home_Load;
            tabControl1.ResumeLayout(false);
            tabStudent.ResumeLayout(false);
            tabStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            tabSubject.ResumeLayout(false);
            tabSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
            tabSessions.ResumeLayout(false);
            tabSessions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabStudent;
        private Button btnAddStudentHome;
        private DataGridView dgvStudent;
        private TabPage tabSubject;
        private TabPage tabSessions;
        private Button btnAddSubjectHome;
        private DataGridView dgvSubject;
        private Button btnAddSessionHome;
        private DataGridView dgvSessions;
        private Label lblStudentTabTitle;
        private Label lblSubjectTabTitle;
        private Label lblSessionTabTitle;
    }
}