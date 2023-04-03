namespace GroupProject
{
    partial class StudentForm
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
            lblStudentName = new Label();
            txtStudentName = new TextBox();
            txtStudentAge = new TextBox();
            lblAge = new Label();
            txtGender = new TextBox();
            lblGender = new Label();
            lblStudentYear = new Label();
            txtStudentKnum = new TextBox();
            lblStudentKnum = new Label();
            lblCounty = new Label();
            txtAvailability = new TextBox();
            lblAvailability = new Label();
            txtPhoneNum = new TextBox();
            lblPhoneNumber = new Label();
            cbxStudentYear = new ComboBox();
            cbxCounty = new ComboBox();
            btnAddStudent = new Button();
            btnStudentCancel = new Button();
            SuspendLayout();
            // 
            // lblStudentName
            // 
            lblStudentName.AutoSize = true;
            lblStudentName.Location = new Point(29, 29);
            lblStudentName.Name = "lblStudentName";
            lblStudentName.Size = new Size(52, 20);
            lblStudentName.TabIndex = 0;
            lblStudentName.Text = "Name:";
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(123, 26);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.Size = new Size(125, 27);
            txtStudentName.TabIndex = 1;
            // 
            // txtStudentAge
            // 
            txtStudentAge.Location = new Point(123, 72);
            txtStudentAge.Name = "txtStudentAge";
            txtStudentAge.Size = new Size(125, 27);
            txtStudentAge.TabIndex = 3;
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(29, 75);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(39, 20);
            lblAge.TabIndex = 2;
            lblAge.Text = "Age:";
            // 
            // txtGender
            // 
            txtGender.Location = new Point(123, 123);
            txtGender.Name = "txtGender";
            txtGender.Size = new Size(125, 27);
            txtGender.TabIndex = 5;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Location = new Point(29, 126);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(60, 20);
            lblGender.TabIndex = 4;
            lblGender.Text = "Gender:";
            // 
            // lblStudentYear
            // 
            lblStudentYear.AutoSize = true;
            lblStudentYear.Location = new Point(29, 179);
            lblStudentYear.Name = "lblStudentYear";
            lblStudentYear.Size = new Size(95, 20);
            lblStudentYear.TabIndex = 6;
            lblStudentYear.Text = "Student Year:";
            // 
            // txtStudentKnum
            // 
            txtStudentKnum.Location = new Point(123, 225);
            txtStudentKnum.Name = "txtStudentKnum";
            txtStudentKnum.Size = new Size(125, 27);
            txtStudentKnum.TabIndex = 8;
            // 
            // lblStudentKnum
            // 
            lblStudentKnum.AutoSize = true;
            lblStudentKnum.Location = new Point(29, 228);
            lblStudentKnum.Name = "lblStudentKnum";
            lblStudentKnum.Size = new Size(75, 20);
            lblStudentKnum.TabIndex = 7;
            lblStudentKnum.Text = "KNumber:";
            // 
            // lblCounty
            // 
            lblCounty.AutoSize = true;
            lblCounty.Location = new Point(29, 279);
            lblCounty.Name = "lblCounty";
            lblCounty.Size = new Size(58, 20);
            lblCounty.TabIndex = 9;
            lblCounty.Text = "County:";
            // 
            // txtAvailability
            // 
            txtAvailability.Location = new Point(123, 316);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(125, 27);
            txtAvailability.TabIndex = 11;
            // 
            // lblAvailability
            // 
            lblAvailability.AutoSize = true;
            lblAvailability.Location = new Point(29, 319);
            lblAvailability.Name = "lblAvailability";
            lblAvailability.Size = new Size(86, 20);
            lblAvailability.TabIndex = 10;
            lblAvailability.Text = "Availability:";
            // 
            // txtPhoneNum
            // 
            txtPhoneNum.Location = new Point(149, 364);
            txtPhoneNum.Name = "txtPhoneNum";
            txtPhoneNum.Size = new Size(125, 27);
            txtPhoneNum.TabIndex = 13;
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(29, 367);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(111, 20);
            lblPhoneNumber.TabIndex = 12;
            lblPhoneNumber.Text = "Phone Number:";
            // 
            // cbxStudentYear
            // 
            cbxStudentYear.FormattingEnabled = true;
            cbxStudentYear.Items.AddRange(new object[] { "1", "2", "3", "4" });
            cbxStudentYear.Location = new Point(130, 176);
            cbxStudentYear.Name = "cbxStudentYear";
            cbxStudentYear.Size = new Size(151, 28);
            cbxStudentYear.TabIndex = 14;
            // 
            // cbxCounty
            // 
            cbxCounty.FormattingEnabled = true;
            cbxCounty.Items.AddRange(new object[] { "Carlow", "Cavan", "Clare", "Cork", "Donegal", "Dublin", "Galway", "Kerry", "Kildare", "Kilkenny", "Laois", "Leitrim", "Limerick", "Longford", "Louth", "Mayo", "Meath", "Monaghan", "Offaly", "Roscommon", "Sligo", "Tipperary", "Waterford", "Westmeath", "Wexford", "Wicklow" });
            cbxCounty.Location = new Point(123, 276);
            cbxCounty.Name = "cbxCounty";
            cbxCounty.Size = new Size(151, 28);
            cbxCounty.TabIndex = 15;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(29, 416);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(108, 29);
            btnAddStudent.TabIndex = 16;
            btnAddStudent.Text = "Add Student";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnStudentCancel
            // 
            btnStudentCancel.Location = new Point(180, 416);
            btnStudentCancel.Name = "btnStudentCancel";
            btnStudentCancel.Size = new Size(94, 29);
            btnStudentCancel.TabIndex = 17;
            btnStudentCancel.Text = "Cancel";
            btnStudentCancel.UseVisualStyleBackColor = true;
            btnStudentCancel.Click += btnStudentCancel_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(360, 485);
            Controls.Add(btnStudentCancel);
            Controls.Add(btnAddStudent);
            Controls.Add(cbxCounty);
            Controls.Add(cbxStudentYear);
            Controls.Add(txtPhoneNum);
            Controls.Add(lblPhoneNumber);
            Controls.Add(txtAvailability);
            Controls.Add(lblAvailability);
            Controls.Add(lblCounty);
            Controls.Add(txtStudentKnum);
            Controls.Add(lblStudentKnum);
            Controls.Add(lblStudentYear);
            Controls.Add(txtGender);
            Controls.Add(lblGender);
            Controls.Add(txtStudentAge);
            Controls.Add(lblAge);
            Controls.Add(txtStudentName);
            Controls.Add(lblStudentName);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentName;
        private TextBox txtStudentName;
        private TextBox txtStudentAge;
        private Label lblAge;
        private TextBox txtGender;
        private Label lblGender;
        private Label lblStudentYear;
        private TextBox txtStudentKnum;
        private Label lblStudentKnum;
        private Label lblCounty;
        private TextBox txtAvailability;
        private Label lblAvailability;
        private TextBox txtPhoneNum;
        private Label lblPhoneNumber;
        private ComboBox cbxStudentYear;
        private ComboBox cbxCounty;
        private Button btnAddStudent;
        private Button btnStudentCancel;
    }
}