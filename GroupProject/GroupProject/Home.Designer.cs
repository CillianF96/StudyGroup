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
            tabControl1 = new TabControl();
            tabStudent = new TabPage();
            tabSubject = new TabPage();
            tabSessions = new TabPage();
            dgvStudent = new DataGridView();
            btnAddStudentHome = new Button();
            btnAddSubjectHome = new Button();
            dgvSubject = new DataGridView();
            btnAddSessionHome = new Button();
            dgvSessions = new DataGridView();
            tabControl1.SuspendLayout();
            tabStudent.SuspendLayout();
            tabSubject.SuspendLayout();
            tabSessions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvStudent).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvSessions).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabStudent);
            tabControl1.Controls.Add(tabSubject);
            tabControl1.Controls.Add(tabSessions);
            tabControl1.Location = new Point(2, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(724, 387);
            tabControl1.TabIndex = 0;
            // 
            // tabStudent
            // 
            tabStudent.Controls.Add(btnAddStudentHome);
            tabStudent.Controls.Add(dgvStudent);
            tabStudent.Location = new Point(4, 29);
            tabStudent.Name = "tabStudent";
            tabStudent.Padding = new Padding(3);
            tabStudent.Size = new Size(716, 354);
            tabStudent.TabIndex = 0;
            tabStudent.Text = "Student";
            tabStudent.UseVisualStyleBackColor = true;
            tabStudent.Click += tabStudent_Click;
            // 
            // tabSubject
            // 
            tabSubject.Controls.Add(btnAddSubjectHome);
            tabSubject.Controls.Add(dgvSubject);
            tabSubject.Location = new Point(4, 29);
            tabSubject.Name = "tabSubject";
            tabSubject.Padding = new Padding(3);
            tabSubject.Size = new Size(716, 354);
            tabSubject.TabIndex = 1;
            tabSubject.Text = "Subject";
            tabSubject.UseVisualStyleBackColor = true;
            tabSubject.Click += tabSubject_Click;
            // 
            // tabSessions
            // 
            tabSessions.Controls.Add(btnAddSessionHome);
            tabSessions.Controls.Add(dgvSessions);
            tabSessions.Location = new Point(4, 29);
            tabSessions.Name = "tabSessions";
            tabSessions.Padding = new Padding(3);
            tabSessions.Size = new Size(716, 354);
            tabSessions.TabIndex = 2;
            tabSessions.Text = "Sessions";
            tabSessions.UseVisualStyleBackColor = true;
            tabSessions.Click += tabSessions_Click;
            // 
            // dgvStudent
            // 
            dgvStudent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudent.Location = new Point(51, 28);
            dgvStudent.Name = "dgvStudent";
            dgvStudent.RowHeadersWidth = 51;
            dgvStudent.RowTemplate.Height = 29;
            dgvStudent.Size = new Size(613, 255);
            dgvStudent.TabIndex = 0;
            dgvStudent.CellContentClick += dgvStudent_CellContentClick;
            // 
            // btnAddStudentHome
            // 
            btnAddStudentHome.Location = new Point(51, 306);
            btnAddStudentHome.Name = "btnAddStudentHome";
            btnAddStudentHome.Size = new Size(164, 29);
            btnAddStudentHome.TabIndex = 1;
            btnAddStudentHome.Text = "Add Student";
            btnAddStudentHome.UseVisualStyleBackColor = true;
            btnAddStudentHome.Click += btnAddStudentHome_Click;
            // 
            // btnAddSubjectHome
            // 
            btnAddSubjectHome.Location = new Point(52, 302);
            btnAddSubjectHome.Name = "btnAddSubjectHome";
            btnAddSubjectHome.Size = new Size(164, 29);
            btnAddSubjectHome.TabIndex = 3;
            btnAddSubjectHome.Text = "Add Subject";
            btnAddSubjectHome.UseVisualStyleBackColor = true;
            btnAddSubjectHome.Click += btnAddSubjectHome_Click;
            // 
            // dgvSubject
            // 
            dgvSubject.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSubject.Location = new Point(52, 24);
            dgvSubject.Name = "dgvSubject";
            dgvSubject.RowHeadersWidth = 51;
            dgvSubject.RowTemplate.Height = 29;
            dgvSubject.Size = new Size(613, 255);
            dgvSubject.TabIndex = 2;
            dgvSubject.CellContentClick += dgvSubject_CellContentClick;
            // 
            // btnAddSessionHome
            // 
            btnAddSessionHome.Location = new Point(52, 302);
            btnAddSessionHome.Name = "btnAddSessionHome";
            btnAddSessionHome.Size = new Size(164, 29);
            btnAddSessionHome.TabIndex = 3;
            btnAddSessionHome.Text = "Add Session";
            btnAddSessionHome.UseVisualStyleBackColor = true;
            btnAddSessionHome.Click += btnAddSessionHome_Click;
            // 
            // dgvSessions
            // 
            dgvSessions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSessions.Location = new Point(52, 24);
            dgvSessions.Name = "dgvSessions";
            dgvSessions.RowHeadersWidth = 51;
            dgvSessions.RowTemplate.Height = 29;
            dgvSessions.Size = new Size(613, 255);
            dgvSessions.TabIndex = 2;
            dgvSessions.CellContentClick += dgvSessions_CellContentClick;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Home";
            Text = "Home";
            tabControl1.ResumeLayout(false);
            tabStudent.ResumeLayout(false);
            tabSubject.ResumeLayout(false);
            tabSessions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvStudent).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvSubject).EndInit();
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
    }
}