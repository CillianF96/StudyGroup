namespace GroupProject
{
    partial class SessionsForm
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
            btnSessionsCancel = new Button();
            btnAddSessions = new Button();
            txtStudyMats = new TextBox();
            lblStudyMats = new Label();
            txtSessionsGoals = new TextBox();
            lblSessionsGoals = new Label();
            lblSessionAgenda = new Label();
            txtSessionAssignments = new TextBox();
            lblSessionsAssignments = new Label();
            lblGroupMembers = new Label();
            txtTopic = new TextBox();
            lblTopic = new Label();
            txtRoomNr = new TextBox();
            lblRoomNr = new Label();
            lblDateTime = new Label();
            dtpSessions = new DateTimePicker();
            txtSessionsAgenda = new TextBox();
            txtGroupMembers = new TextBox();
            SuspendLayout();
            // 
            // btnSessionsCancel
            // 
            btnSessionsCancel.Location = new Point(286, 403);
            btnSessionsCancel.Margin = new Padding(4);
            btnSessionsCancel.Name = "btnSessionsCancel";
            btnSessionsCancel.Size = new Size(118, 46);
            btnSessionsCancel.TabIndex = 35;
            btnSessionsCancel.Text = "Cancel";
            btnSessionsCancel.UseVisualStyleBackColor = true;
            btnSessionsCancel.Click += btnSessionsCancel_Click;
            // 
            // btnAddSessions
            // 
            btnAddSessions.Location = new Point(28, 403);
            btnAddSessions.Margin = new Padding(4);
            btnAddSessions.Name = "btnAddSessions";
            btnAddSessions.Size = new Size(135, 46);
            btnAddSessions.TabIndex = 34;
            btnAddSessions.Text = "Add Sessions";
            btnAddSessions.UseVisualStyleBackColor = true;
            btnAddSessions.Click += btnAddSessions_Click;
            // 
            // txtStudyMats
            // 
            txtStudyMats.Location = new Point(181, 344);
            txtStudyMats.Margin = new Padding(4);
            txtStudyMats.Name = "txtStudyMats";
            txtStudyMats.Size = new Size(223, 31);
            txtStudyMats.TabIndex = 31;
            // 
            // lblStudyMats
            // 
            lblStudyMats.AutoSize = true;
            lblStudyMats.Location = new Point(13, 347);
            lblStudyMats.Margin = new Padding(4, 0, 4, 0);
            lblStudyMats.Name = "lblStudyMats";
            lblStudyMats.Size = new Size(137, 25);
            lblStudyMats.TabIndex = 30;
            lblStudyMats.Text = "Study Materials:";
            // 
            // txtSessionsGoals
            // 
            txtSessionsGoals.Location = new Point(181, 294);
            txtSessionsGoals.Margin = new Padding(4);
            txtSessionsGoals.Name = "txtSessionsGoals";
            txtSessionsGoals.Size = new Size(223, 31);
            txtSessionsGoals.TabIndex = 29;
            // 
            // lblSessionsGoals
            // 
            lblSessionsGoals.AutoSize = true;
            lblSessionsGoals.Location = new Point(14, 297);
            lblSessionsGoals.Margin = new Padding(4, 0, 4, 0);
            lblSessionsGoals.Name = "lblSessionsGoals";
            lblSessionsGoals.Size = new Size(149, 25);
            lblSessionsGoals.TabIndex = 28;
            lblSessionsGoals.Text = "Goals/Objectives:";
            // 
            // lblSessionAgenda
            // 
            lblSessionAgenda.AutoSize = true;
            lblSessionAgenda.Location = new Point(13, 248);
            lblSessionAgenda.Margin = new Padding(4, 0, 4, 0);
            lblSessionAgenda.Name = "lblSessionAgenda";
            lblSessionAgenda.Size = new Size(78, 25);
            lblSessionAgenda.TabIndex = 27;
            lblSessionAgenda.Text = "Agenda:";
            // 
            // txtSessionAssignments
            // 
            txtSessionAssignments.Location = new Point(181, 197);
            txtSessionAssignments.Margin = new Padding(4);
            txtSessionAssignments.Name = "txtSessionAssignments";
            txtSessionAssignments.Size = new Size(223, 31);
            txtSessionAssignments.TabIndex = 26;
            // 
            // lblSessionsAssignments
            // 
            lblSessionsAssignments.AutoSize = true;
            lblSessionsAssignments.Location = new Point(11, 200);
            lblSessionsAssignments.Margin = new Padding(4, 0, 4, 0);
            lblSessionsAssignments.Name = "lblSessionsAssignments";
            lblSessionsAssignments.Size = new Size(118, 25);
            lblSessionsAssignments.TabIndex = 25;
            lblSessionsAssignments.Text = "Assignments:";
            // 
            // lblGroupMembers
            // 
            lblGroupMembers.AutoSize = true;
            lblGroupMembers.Location = new Point(11, 151);
            lblGroupMembers.Margin = new Padding(4, 0, 4, 0);
            lblGroupMembers.Name = "lblGroupMembers";
            lblGroupMembers.Size = new Size(146, 25);
            lblGroupMembers.TabIndex = 24;
            lblGroupMembers.Text = "Group Members:";
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(181, 101);
            txtTopic.Margin = new Padding(4);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(223, 31);
            txtTopic.TabIndex = 23;
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Location = new Point(14, 104);
            lblTopic.Margin = new Padding(4, 0, 4, 0);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(57, 25);
            lblTopic.TabIndex = 22;
            lblTopic.Text = "Topic:";
            // 
            // txtRoomNr
            // 
            txtRoomNr.Location = new Point(181, 57);
            txtRoomNr.Margin = new Padding(4);
            txtRoomNr.Name = "txtRoomNr";
            txtRoomNr.Size = new Size(223, 31);
            txtRoomNr.TabIndex = 21;
            // 
            // lblRoomNr
            // 
            lblRoomNr.AutoSize = true;
            lblRoomNr.Location = new Point(16, 63);
            lblRoomNr.Margin = new Padding(4, 0, 4, 0);
            lblRoomNr.Name = "lblRoomNr";
            lblRoomNr.Size = new Size(134, 25);
            lblRoomNr.TabIndex = 20;
            lblRoomNr.Text = "Room Number:";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(15, 11);
            lblDateTime.Margin = new Padding(4, 0, 4, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(131, 25);
            lblDateTime.TabIndex = 18;
            lblDateTime.Text = "Date and Time:";
            // 
            // dtpSessions
            // 
            dtpSessions.Location = new Point(181, 11);
            dtpSessions.Margin = new Padding(4);
            dtpSessions.Name = "dtpSessions";
            dtpSessions.Size = new Size(312, 31);
            dtpSessions.TabIndex = 36;
            // 
            // txtSessionsAgenda
            // 
            txtSessionsAgenda.Location = new Point(181, 245);
            txtSessionsAgenda.Margin = new Padding(4);
            txtSessionsAgenda.Name = "txtSessionsAgenda";
            txtSessionsAgenda.Size = new Size(223, 31);
            txtSessionsAgenda.TabIndex = 38;
            // 
            // txtGroupMembers
            // 
            txtGroupMembers.Location = new Point(181, 148);
            txtGroupMembers.Name = "txtGroupMembers";
            txtGroupMembers.Size = new Size(223, 31);
            txtGroupMembers.TabIndex = 39;
            // 
            // SessionsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(525, 490);
            Controls.Add(txtGroupMembers);
            Controls.Add(txtSessionsAgenda);
            Controls.Add(dtpSessions);
            Controls.Add(btnSessionsCancel);
            Controls.Add(btnAddSessions);
            Controls.Add(txtStudyMats);
            Controls.Add(lblStudyMats);
            Controls.Add(txtSessionsGoals);
            Controls.Add(lblSessionsGoals);
            Controls.Add(lblSessionAgenda);
            Controls.Add(txtSessionAssignments);
            Controls.Add(lblSessionsAssignments);
            Controls.Add(lblGroupMembers);
            Controls.Add(txtTopic);
            Controls.Add(lblTopic);
            Controls.Add(txtRoomNr);
            Controls.Add(lblRoomNr);
            Controls.Add(lblDateTime);
            Margin = new Padding(4);
            Name = "SessionsForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Study Group | Add Session";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStudentCancel;
        private Button btnAddStudent;
        private ComboBox cbxCounty;
        private ComboBox cbxStudentYear;
        private TextBox txtPhoneNum;
        private Label txtPhoneNumber;
        private TextBox txtAvailability;
        private Label lblAvailability;
        private Label lblCounty;
        private TextBox txtStudentKnum;
        private Label lblSessionsAssignments;
        private Label lblGroupMembers;
        private TextBox txtTopic;
        private Label lblTopic;
        private TextBox txtRoomNr;
        private Label lblRoomNr;
        private Label lblDateTime;
        private DateTimePicker dtpSessions;
        private TextBox txtSessionsAgenda;
        private Button btnSessionsCancel;
        private Button btnAddSessions;
        private TextBox txtStudyMats;
        private Label lblStudyMats;
        private TextBox txtSessionsGoals;
        private Label lblSessionsGoals;
        private Label lblSessionAgenda;
        private TextBox txtSessionAssignments;
        private TextBox txtGroupMembers;
    }
}