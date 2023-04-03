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
            txtGroupMembers = new TextBox();
            txtSessionsAgenda = new TextBox();
            SuspendLayout();
            // 
            // btnSessionsCancel
            // 
            btnSessionsCancel.Location = new Point(163, 396);
            btnSessionsCancel.Name = "btnSessionsCancel";
            btnSessionsCancel.Size = new Size(94, 29);
            btnSessionsCancel.TabIndex = 35;
            btnSessionsCancel.Text = "Cancel";
            btnSessionsCancel.UseVisualStyleBackColor = true;
            btnSessionsCancel.Click += btnSessionsCancel_Click;
            // 
            // btnAddSessions
            // 
            btnAddSessions.Location = new Point(12, 396);
            btnAddSessions.Name = "btnAddSessions";
            btnAddSessions.Size = new Size(108, 29);
            btnAddSessions.TabIndex = 34;
            btnAddSessions.Text = "Add Sessions";
            btnAddSessions.UseVisualStyleBackColor = true;
            // 
            // txtStudyMats
            // 
            txtStudyMats.Location = new Point(132, 344);
            txtStudyMats.Name = "txtStudyMats";
            txtStudyMats.Size = new Size(125, 27);
            txtStudyMats.TabIndex = 31;
            // 
            // lblStudyMats
            // 
            lblStudyMats.AutoSize = true;
            lblStudyMats.Location = new Point(12, 347);
            lblStudyMats.Name = "lblStudyMats";
            lblStudyMats.Size = new Size(114, 20);
            lblStudyMats.TabIndex = 30;
            lblStudyMats.Text = "Study Materials:";
            // 
            // txtSessionsGoals
            // 
            txtSessionsGoals.Location = new Point(149, 296);
            txtSessionsGoals.Name = "txtSessionsGoals";
            txtSessionsGoals.Size = new Size(125, 27);
            txtSessionsGoals.TabIndex = 29;
            // 
            // lblSessionsGoals
            // 
            lblSessionsGoals.AutoSize = true;
            lblSessionsGoals.Location = new Point(12, 299);
            lblSessionsGoals.Name = "lblSessionsGoals";
            lblSessionsGoals.Size = new Size(124, 20);
            lblSessionsGoals.TabIndex = 28;
            lblSessionsGoals.Text = "Goals/Objectives:";
            // 
            // lblSessionAgenda
            // 
            lblSessionAgenda.AutoSize = true;
            lblSessionAgenda.Location = new Point(12, 259);
            lblSessionAgenda.Name = "lblSessionAgenda";
            lblSessionAgenda.Size = new Size(64, 20);
            lblSessionAgenda.TabIndex = 27;
            lblSessionAgenda.Text = "Agenda:";
            // 
            // txtSessionAssignments
            // 
            txtSessionAssignments.Location = new Point(113, 205);
            txtSessionAssignments.Name = "txtSessionAssignments";
            txtSessionAssignments.Size = new Size(125, 27);
            txtSessionAssignments.TabIndex = 26;
            // 
            // lblSessionsAssignments
            // 
            lblSessionsAssignments.AutoSize = true;
            lblSessionsAssignments.Location = new Point(12, 208);
            lblSessionsAssignments.Name = "lblSessionsAssignments";
            lblSessionsAssignments.Size = new Size(95, 20);
            lblSessionsAssignments.TabIndex = 25;
            lblSessionsAssignments.Text = "Assignments:";
            // 
            // lblGroupMembers
            // 
            lblGroupMembers.AutoSize = true;
            lblGroupMembers.Location = new Point(12, 159);
            lblGroupMembers.Name = "lblGroupMembers";
            lblGroupMembers.Size = new Size(119, 20);
            lblGroupMembers.TabIndex = 24;
            lblGroupMembers.Text = "Group Members:";
            // 
            // txtTopic
            // 
            txtTopic.Location = new Point(106, 103);
            txtTopic.Name = "txtTopic";
            txtTopic.Size = new Size(125, 27);
            txtTopic.TabIndex = 23;
            // 
            // lblTopic
            // 
            lblTopic.AutoSize = true;
            lblTopic.Location = new Point(12, 106);
            lblTopic.Name = "lblTopic";
            lblTopic.Size = new Size(48, 20);
            lblTopic.TabIndex = 22;
            lblTopic.Text = "Topic:";
            // 
            // txtRoomNr
            // 
            txtRoomNr.Location = new Point(132, 52);
            txtRoomNr.Name = "txtRoomNr";
            txtRoomNr.Size = new Size(125, 27);
            txtRoomNr.TabIndex = 21;
            // 
            // lblRoomNr
            // 
            lblRoomNr.AutoSize = true;
            lblRoomNr.Location = new Point(12, 55);
            lblRoomNr.Name = "lblRoomNr";
            lblRoomNr.Size = new Size(110, 20);
            lblRoomNr.TabIndex = 20;
            lblRoomNr.Text = "Room Number:";
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(12, 9);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(110, 20);
            lblDateTime.TabIndex = 18;
            lblDateTime.Text = "Date and Time:";
            // 
            // dtpSessions
            // 
            dtpSessions.Location = new Point(128, 9);
            dtpSessions.Name = "dtpSessions";
            dtpSessions.Size = new Size(250, 27);
            dtpSessions.TabIndex = 36;
            // 
            // txtGroupMembers
            // 
            txtGroupMembers.Location = new Point(149, 156);
            txtGroupMembers.Name = "txtGroupMembers";
            txtGroupMembers.Size = new Size(125, 27);
            txtGroupMembers.TabIndex = 37;
            // 
            // txtSessionsAgenda
            // 
            txtSessionsAgenda.Location = new Point(129, 256);
            txtSessionsAgenda.Name = "txtSessionsAgenda";
            txtSessionsAgenda.Size = new Size(125, 27);
            txtSessionsAgenda.TabIndex = 38;
            // 
            // SessionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 450);
            Controls.Add(txtSessionsAgenda);
            Controls.Add(txtGroupMembers);
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
            Name = "SessionsForm";
            Text = "SessionsForm";
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
        private TextBox txtGroupMembers;
        private TextBox txtSessionsAgenda;
        private Button btnSessionsCancel;
        private Button btnAddSessions;
        private TextBox txtStudyMats;
        private Label lblStudyMats;
        private TextBox txtSessionsGoals;
        private Label lblSessionsGoals;
        private Label lblSessionAgenda;
        private TextBox txtSessionAssignments;
    }
}