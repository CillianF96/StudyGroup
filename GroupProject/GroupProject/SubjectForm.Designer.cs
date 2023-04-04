namespace GroupProject
{
    partial class SubjectForm
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
            btnSubjectCancel = new Button();
            btnAddSubject = new Button();
            cbxSubjectYear = new ComboBox();
            txtSubjectRoles = new TextBox();
            lblRoles = new Label();
            txtSubjectMaterials = new TextBox();
            lblStudyMats = new Label();
            lblSubjectProjects = new Label();
            txtPreReq = new TextBox();
            lblPreReq = new Label();
            lblSubjectYear = new Label();
            txtOutcomes = new TextBox();
            lblLearning = new Label();
            txtSubjectDescription = new TextBox();
            lblDescription = new Label();
            txtSubjectName = new TextBox();
            lblStubjectName = new Label();
            txtSubjectProjects = new TextBox();
            SuspendLayout();
            // 
            // btnSubjectCancel
            // 
            btnSubjectCancel.Location = new Point(263, 431);
            btnSubjectCancel.Margin = new Padding(4);
            btnSubjectCancel.Name = "btnSubjectCancel";
            btnSubjectCancel.Size = new Size(118, 43);
            btnSubjectCancel.TabIndex = 35;
            btnSubjectCancel.Text = "Cancel";
            btnSubjectCancel.UseVisualStyleBackColor = true;
            btnSubjectCancel.Click += btnSubjectCancel_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(33, 431);
            btnAddSubject.Margin = new Padding(4);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(135, 43);
            btnAddSubject.TabIndex = 34;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            btnAddSubject.Click += btnAddSubject_Click;
            // 
            // cbxSubjectYear
            // 
            cbxSubjectYear.FormattingEnabled = true;
            cbxSubjectYear.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbxSubjectYear.Location = new Point(193, 168);
            cbxSubjectYear.Margin = new Padding(4);
            cbxSubjectYear.Name = "cbxSubjectYear";
            cbxSubjectYear.Size = new Size(188, 33);
            cbxSubjectYear.TabIndex = 32;
            // 
            // txtSubjectRoles
            // 
            txtSubjectRoles.Location = new Point(193, 367);
            txtSubjectRoles.Margin = new Padding(4);
            txtSubjectRoles.Name = "txtSubjectRoles";
            txtSubjectRoles.Size = new Size(188, 31);
            txtSubjectRoles.TabIndex = 31;
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Location = new Point(15, 373);
            lblRoles.Margin = new Padding(4, 0, 4, 0);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(58, 25);
            lblRoles.TabIndex = 30;
            lblRoles.Text = "Roles:";
            // 
            // txtSubjectMaterials
            // 
            txtSubjectMaterials.Location = new Point(193, 320);
            txtSubjectMaterials.Margin = new Padding(4);
            txtSubjectMaterials.Name = "txtSubjectMaterials";
            txtSubjectMaterials.Size = new Size(188, 31);
            txtSubjectMaterials.TabIndex = 29;
            // 
            // lblStudyMats
            // 
            lblStudyMats.AutoSize = true;
            lblStudyMats.Location = new Point(15, 323);
            lblStudyMats.Margin = new Padding(4, 0, 4, 0);
            lblStudyMats.Name = "lblStudyMats";
            lblStudyMats.Size = new Size(137, 25);
            lblStudyMats.TabIndex = 28;
            lblStudyMats.Text = "Study Materials:";
            // 
            // lblSubjectProjects
            // 
            lblSubjectProjects.AutoSize = true;
            lblSubjectProjects.Location = new Point(15, 274);
            lblSubjectProjects.Margin = new Padding(4, 0, 4, 0);
            lblSubjectProjects.Name = "lblSubjectProjects";
            lblSubjectProjects.Size = new Size(78, 25);
            lblSubjectProjects.TabIndex = 27;
            lblSubjectProjects.Text = "Projects:";
            // 
            // txtPreReq
            // 
            txtPreReq.Location = new Point(193, 220);
            txtPreReq.Margin = new Padding(4);
            txtPreReq.Name = "txtPreReq";
            txtPreReq.Size = new Size(188, 31);
            txtPreReq.TabIndex = 26;
            // 
            // lblPreReq
            // 
            lblPreReq.AutoSize = true;
            lblPreReq.Location = new Point(15, 226);
            lblPreReq.Margin = new Padding(4, 0, 4, 0);
            lblPreReq.Name = "lblPreReq";
            lblPreReq.Size = new Size(116, 25);
            lblPreReq.TabIndex = 25;
            lblPreReq.Text = "Prerequisites:";
            // 
            // lblSubjectYear
            // 
            lblSubjectYear.AutoSize = true;
            lblSubjectYear.Location = new Point(15, 176);
            lblSubjectYear.Margin = new Padding(4, 0, 4, 0);
            lblSubjectYear.Name = "lblSubjectYear";
            lblSubjectYear.Size = new Size(111, 25);
            lblSubjectYear.TabIndex = 24;
            lblSubjectYear.Text = "Subject Year:";
            // 
            // txtOutcomes
            // 
            txtOutcomes.Location = new Point(193, 115);
            txtOutcomes.Margin = new Padding(4);
            txtOutcomes.Name = "txtOutcomes";
            txtOutcomes.Size = new Size(188, 31);
            txtOutcomes.TabIndex = 23;
            // 
            // lblLearning
            // 
            lblLearning.AutoSize = true;
            lblLearning.Location = new Point(15, 118);
            lblLearning.Margin = new Padding(4, 0, 4, 0);
            lblLearning.Name = "lblLearning";
            lblLearning.Size = new Size(170, 25);
            lblLearning.TabIndex = 22;
            lblLearning.Text = "Learning Outcomes:";
            // 
            // txtSubjectDescription
            // 
            txtSubjectDescription.Location = new Point(193, 67);
            txtSubjectDescription.Margin = new Padding(4);
            txtSubjectDescription.Name = "txtSubjectDescription";
            txtSubjectDescription.Size = new Size(188, 31);
            txtSubjectDescription.TabIndex = 21;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(15, 73);
            lblDescription.Margin = new Padding(4, 0, 4, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(106, 25);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Description:";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(193, 25);
            txtSubjectName.Margin = new Padding(4);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(188, 31);
            txtSubjectName.TabIndex = 19;
            // 
            // lblStubjectName
            // 
            lblStubjectName.AutoSize = true;
            lblStubjectName.Location = new Point(15, 28);
            lblStubjectName.Margin = new Padding(4, 0, 4, 0);
            lblStubjectName.Name = "lblStubjectName";
            lblStubjectName.Size = new Size(63, 25);
            lblStubjectName.TabIndex = 18;
            lblStubjectName.Text = "Name:";
            // 
            // txtSubjectProjects
            // 
            txtSubjectProjects.Location = new Point(193, 268);
            txtSubjectProjects.Margin = new Padding(4);
            txtSubjectProjects.Name = "txtSubjectProjects";
            txtSubjectProjects.Size = new Size(188, 31);
            txtSubjectProjects.TabIndex = 36;
            // 
            // SubjectForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 497);
            Controls.Add(txtSubjectProjects);
            Controls.Add(btnSubjectCancel);
            Controls.Add(btnAddSubject);
            Controls.Add(cbxSubjectYear);
            Controls.Add(txtSubjectRoles);
            Controls.Add(lblRoles);
            Controls.Add(txtSubjectMaterials);
            Controls.Add(lblStudyMats);
            Controls.Add(lblSubjectProjects);
            Controls.Add(txtPreReq);
            Controls.Add(lblPreReq);
            Controls.Add(lblSubjectYear);
            Controls.Add(txtOutcomes);
            Controls.Add(lblLearning);
            Controls.Add(txtSubjectDescription);
            Controls.Add(lblDescription);
            Controls.Add(txtSubjectName);
            Controls.Add(lblStubjectName);
            Margin = new Padding(4);
            Name = "SubjectForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Study Group | Add Subject";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSubjectCancel;
        private Button btnAddSubject;
        private ComboBox cbxSubjectYear;
        private TextBox txtSubjectRoles;
        private Label lblRoles;
        private TextBox txtSubjectMaterials;
        private Label lblStudyMats;
        private Label lblSubjectProjects;
        private TextBox txtPreReq;
        private Label lblPreReq;
        private Label lblSubjectYear;
        private TextBox txtOutcomes;
        private Label lblLearning;
        private TextBox txtSubjectDescription;
        private Label lblDescription;
        private TextBox txtSubjectName;
        private Label lblStubjectName;
        private TextBox txtSubjectProjects;
    }
}