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
            btnSubjectCancel.Location = new Point(163, 407);
            btnSubjectCancel.Name = "btnSubjectCancel";
            btnSubjectCancel.Size = new Size(94, 29);
            btnSubjectCancel.TabIndex = 35;
            btnSubjectCancel.Text = "Cancel";
            btnSubjectCancel.UseVisualStyleBackColor = true;
            btnSubjectCancel.Click += btnSubjectCancel_Click;
            // 
            // btnAddSubject
            // 
            btnAddSubject.Location = new Point(12, 407);
            btnAddSubject.Name = "btnAddSubject";
            btnAddSubject.Size = new Size(108, 29);
            btnAddSubject.TabIndex = 34;
            btnAddSubject.Text = "Add Subject";
            btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // cbxSubjectYear
            // 
            cbxSubjectYear.FormattingEnabled = true;
            cbxSubjectYear.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbxSubjectYear.Location = new Point(113, 167);
            cbxSubjectYear.Name = "cbxSubjectYear";
            cbxSubjectYear.Size = new Size(151, 28);
            cbxSubjectYear.TabIndex = 32;
            // 
            // txtSubjectRoles
            // 
            txtSubjectRoles.Location = new Point(132, 355);
            txtSubjectRoles.Name = "txtSubjectRoles";
            txtSubjectRoles.Size = new Size(125, 27);
            txtSubjectRoles.TabIndex = 31;
            // 
            // lblRoles
            // 
            lblRoles.AutoSize = true;
            lblRoles.Location = new Point(12, 358);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(48, 20);
            lblRoles.TabIndex = 30;
            lblRoles.Text = "Roles:";
            // 
            // txtSubjectMaterials
            // 
            txtSubjectMaterials.Location = new Point(106, 307);
            txtSubjectMaterials.Name = "txtSubjectMaterials";
            txtSubjectMaterials.Size = new Size(125, 27);
            txtSubjectMaterials.TabIndex = 29;
            // 
            // lblStudyMats
            // 
            lblStudyMats.AutoSize = true;
            lblStudyMats.Location = new Point(12, 310);
            lblStudyMats.Name = "lblStudyMats";
            lblStudyMats.Size = new Size(114, 20);
            lblStudyMats.TabIndex = 28;
            lblStudyMats.Text = "Study Materials:";
            // 
            // lblSubjectProjects
            // 
            lblSubjectProjects.AutoSize = true;
            lblSubjectProjects.Location = new Point(12, 270);
            lblSubjectProjects.Name = "lblSubjectProjects";
            lblSubjectProjects.Size = new Size(64, 20);
            lblSubjectProjects.TabIndex = 27;
            lblSubjectProjects.Text = "Projects:";
            // 
            // txtPreReq
            // 
            txtPreReq.Location = new Point(106, 216);
            txtPreReq.Name = "txtPreReq";
            txtPreReq.Size = new Size(125, 27);
            txtPreReq.TabIndex = 26;
            // 
            // lblPreReq
            // 
            lblPreReq.AutoSize = true;
            lblPreReq.Location = new Point(12, 219);
            lblPreReq.Name = "lblPreReq";
            lblPreReq.Size = new Size(96, 20);
            lblPreReq.TabIndex = 25;
            lblPreReq.Text = "Prerequisites:";
            // 
            // lblSubjectYear
            // 
            lblSubjectYear.AutoSize = true;
            lblSubjectYear.Location = new Point(12, 170);
            lblSubjectYear.Name = "lblSubjectYear";
            lblSubjectYear.Size = new Size(93, 20);
            lblSubjectYear.TabIndex = 24;
            lblSubjectYear.Text = "Subject Year:";
            // 
            // txtOutcomes
            // 
            txtOutcomes.Location = new Point(106, 114);
            txtOutcomes.Name = "txtOutcomes";
            txtOutcomes.Size = new Size(125, 27);
            txtOutcomes.TabIndex = 23;
            // 
            // lblLearning
            // 
            lblLearning.AutoSize = true;
            lblLearning.Location = new Point(12, 117);
            lblLearning.Name = "lblLearning";
            lblLearning.Size = new Size(140, 20);
            lblLearning.TabIndex = 22;
            lblLearning.Text = "Learning Outcomes:";
            // 
            // txtSubjectDescription
            // 
            txtSubjectDescription.Location = new Point(106, 63);
            txtSubjectDescription.Name = "txtSubjectDescription";
            txtSubjectDescription.Size = new Size(125, 27);
            txtSubjectDescription.TabIndex = 21;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(12, 66);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(88, 20);
            lblDescription.TabIndex = 20;
            lblDescription.Text = "Description:";
            // 
            // txtSubjectName
            // 
            txtSubjectName.Location = new Point(106, 17);
            txtSubjectName.Name = "txtSubjectName";
            txtSubjectName.Size = new Size(125, 27);
            txtSubjectName.TabIndex = 19;
            // 
            // lblStubjectName
            // 
            lblStubjectName.AutoSize = true;
            lblStubjectName.Location = new Point(12, 20);
            lblStubjectName.Name = "lblStubjectName";
            lblStubjectName.Size = new Size(52, 20);
            lblStubjectName.TabIndex = 18;
            lblStubjectName.Text = "Name:";
            // 
            // txtSubjectProjects
            // 
            txtSubjectProjects.Location = new Point(106, 267);
            txtSubjectProjects.Name = "txtSubjectProjects";
            txtSubjectProjects.Size = new Size(125, 27);
            txtSubjectProjects.TabIndex = 36;
            // 
            // SujectForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(370, 450);
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
            Name = "SujectForm";
            Text = "SubjectForm";
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