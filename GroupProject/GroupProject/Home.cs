using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Home : Form
    {
        List<Student> students = new List<Student>();
        List<Subject> subjects = new List<Subject>();
        List<Sessions> sessions = new List<Sessions>();
        public Home()
        {
            loadDataToList();
            InitializeComponent();
        }
        private void loadDataToList()
        {
            Student s0 = new Student("Greg", 18, "Male", 2, "K00273113", "Clare", "Yes", "0852433145");
            Student s1 = new Student("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            Student s2 = new Student("Eoin", 17, "Male", 1, "K00234453", "Sligo", "Yes", "0852433145");
            Student s3 = new Student("Mike", 20, "Male", 3, "K00345633", "Clare", "No", "0852433145");
            Student s4 = new Student("Paul", 16, "Male", 1, "K00273113", "Galway", "Yes", "0852433145");
            Student s5 = new Student("Jack", 22, "Male", 4, "K00276788", "Antrim", "No", "0852433145");
            Student s6 = new Student("Ryan", 18, "Male", 1, "K00234453", "Limerick", "Yes", "0852433145");
            Student s7 = new Student("John", 19, "Male", 2, "K00345633", "Clare", "No", "0852433145");
            this.students.Add(s0);
            this.students.Add(s1);
            this.students.Add(s2);
            this.students.Add(s3);
            this.students.Add(s4);
            this.students.Add(s5);
            this.students.Add(s6);
            this.students.Add(s7);

            Subject sub0 = new Subject("Maths", "Set Theory", "Chapter 2", 1, "Learn chapter 1", "3", "Calculator", "Jim is leader");
            //Student sub1 = new Student("App Dev", "Foreach loops", "Chapter 22", 2, "Learn chapter 19", 1, "Slides 19", "Jim is leader");
            //Student sub2 = new Student("Maths", "Set Theory", "Chapter 2", 2, "Learn chapter 1", 3, "Calculator", "Jim is leader");
            //Student sub3 = new Student("Maths", "Set Theory", "Chapter 2", 2, "Learn chapter 1", 3, "Calculator", "Jim is leader");
            //Student sub4 = new Student("Maths", "Set Theory", "Chapter 2", 2, "Learn chapter 1", 3, "Calculator", "Jim is leader");
            //Student sub5 = new Student("Maths", "Set Theory", "Chapter 2", 2, "Learn chapter 1", 3, "Calculator", "Jim is leader");
            //Student sub6 = new Student("Maths", "Set Theory", "Chapter 2", 2, "Learn chapter 1", 3, "Calculator", "Jim is leader");
            //Student sub7 = new Student("Maths", "Set Theory", "Chapter 2", 2, "Learn chapter 1", 3, "Calculator", "Jim is leader");
            this.subjects.Add(sub0);
            //this.subjects.Add(sub1);
            //this.subjects.Add(sub2);
            //this.subjects.Add(sub3);
            //this.subjects.Add(sub4);
            //this.subjects.Add(sub5);
            //this.subjects.Add(sub6);
            //this.subjects.Add(sub7);

            Sessions ses0 = new Sessions(DateTime.Parse("04/04/2023"), 18, "Maths", "Greg, Bill, Mark", "A, B and C", "Complete questions", "Result above 70%", "Calculator");
            //Sessions ses1 = new Sessions("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            //Sessions ses2 = new Sessions("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            //Sessions ses3 = new Sessions("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            //Sessions ses4 = new Sessions("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            //Sessions ses5 = new Sessions("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            //Sessions ses6 = new Sessions("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            //Sessions ses7 = new Sessions("Bill", 19, "Male", 2, "K00276788", "Cavan", "Yes", "0852433145");
            this.sessions.Add(ses0);
            //this.sessions.Add(ses1);
            //this.sessions.Add(ses2);
            //this.sessions.Add(ses3);
            //this.sessions.Add(ses4);
            //this.sessions.Add(ses5);
            //this.sessions.Add(ses6);
            //this.sessions.Add(ses7);


        }

        private void Home_Load(object sender, EventArgs e)
        {
            DisplayStudents();
            DisplaySubjects();
            DisplaySessions();
        }

        private void dgvStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddStudentHome_Click(object sender, EventArgs e)
        {
            StudentForm showStudent = new StudentForm();

            DialogResult selectedButton = showStudent.ShowDialog();
        }

        private void tabStudent_Click(object sender, EventArgs e)
        {

        }

        private void DisplayStudents()
        {
            dgvStudent.Columns.Clear();
            dgvStudent.DataSource = new BindingList<Student>(this.students.ToList());

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvStudent.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvStudent.Columns.Add(deleteColumn);

            // format the column header
            dgvStudent.EnableHeadersVisualStyles = false;
            dgvStudent.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 7, FontStyle.Bold);
            dgvStudent.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // format the first column
            dgvStudent.Columns[0].HeaderText = "Name";
            dgvStudent.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[0].Width = 90;
            dgvStudent.Columns[0].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Second column
            dgvStudent.Columns[1].HeaderText = "Age";
            dgvStudent.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[1].Width = 90;
            dgvStudent.Columns[1].DefaultCellStyle.Format = "0";
            dgvStudent.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Third column
            dgvStudent.Columns[2].HeaderText = "Gender";
            dgvStudent.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[2].Width = 90;
            dgvStudent.Columns[2].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Forth column
            dgvStudent.Columns[3].HeaderText = "Year";
            dgvStudent.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[3].Width = 50;
            dgvStudent.Columns[3].DefaultCellStyle.Format = "0";
            dgvStudent.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Fifth column
            dgvStudent.Columns[4].HeaderText = "Knumber";
            dgvStudent.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[4].Width = 110;
            dgvStudent.Columns[4].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Sixth column
            dgvStudent.Columns[5].HeaderText = "County";
            dgvStudent.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[5].Width = 90;
            dgvStudent.Columns[5].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Seventh column
            dgvStudent.Columns[6].HeaderText = "Availibility";
            dgvStudent.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[6].Width = 90;
            dgvStudent.Columns[6].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Eight column
            dgvStudent.Columns[7].HeaderText = "Phone Number";
            dgvStudent.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[7].Width = 110;
            dgvStudent.Columns[7].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Ninth column
            dgvStudent.Columns[8].HeaderText = "Modify Details";
            dgvStudent.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[8].Width = 90;
            dgvStudent.Columns[8].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Tenth column
            dgvStudent.Columns[9].HeaderText = "Delete Details";
            dgvStudent.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvStudent.Columns[9].Width = 90;
            dgvStudent.Columns[9].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void DisplaySubjects()
        {
            dgvSubject.Columns.Clear();
            dgvSubject.DataSource = new BindingList<Subject>(this.subjects.ToList());

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvSubject.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvSubject.Columns.Add(deleteColumn);

            // format the column header
            dgvSubject.EnableHeadersVisualStyles = false;
            dgvSubject.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 7, FontStyle.Bold);
            dgvSubject.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvSubject.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvSubject.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // format the first column
            dgvSubject.Columns[0].HeaderText = "Name";
            dgvSubject.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[0].Width = 90;
            dgvSubject.Columns[0].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Second column
            dgvSubject.Columns[1].HeaderText = "Description";
            dgvSubject.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[1].Width = 90;
            dgvSubject.Columns[1].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Third column
            dgvSubject.Columns[2].HeaderText = "Learning Outcomes";
            dgvSubject.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[2].Width = 90;
            dgvSubject.Columns[2].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Forth column
            dgvSubject.Columns[3].HeaderText = "Year";
            dgvSubject.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[3].Width = 50;
            dgvSubject.Columns[3].DefaultCellStyle.Format = "0";
            dgvSubject.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Fifth column
            dgvSubject.Columns[4].HeaderText = "Prerequisites";
            dgvSubject.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[4].Width = 110;
            dgvSubject.Columns[4].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Sixth column
            dgvSubject.Columns[5].HeaderText = "Projects";
            dgvSubject.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[5].Width = 90;
            dgvSubject.Columns[5].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Seventh column
            dgvSubject.Columns[6].HeaderText = "Materials";
            dgvSubject.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[6].Width = 90;
            dgvSubject.Columns[6].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Eight column
            dgvSubject.Columns[7].HeaderText = "Roles";
            dgvSubject.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[7].Width = 110;
            dgvSubject.Columns[7].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Ninth column
            dgvSubject.Columns[8].HeaderText = "Modify Details";
            dgvSubject.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[8].Width = 90;
            dgvSubject.Columns[8].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Tenth column
            dgvSubject.Columns[9].HeaderText = "Delete Details";
            dgvSubject.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSubject.Columns[9].Width = 90;
            dgvSubject.Columns[9].DefaultCellStyle.Format = "c";
            dgvSubject.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void tabSubject_Click(object sender, EventArgs e)
        {
           
        }

        private void dgvSubject_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddSubjectHome_Click(object sender, EventArgs e)
        {
            SubjectForm showSubject = new SubjectForm();

            DialogResult selectedButton = showSubject.ShowDialog();
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void DisplaySessions()
        {
            dgvSessions.Columns.Clear();
            dgvSessions.DataSource = new BindingList<Sessions>(this.sessions.ToList());

            // add column for modify button
            var modifyColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Modify"
            };
            dgvSessions.Columns.Add(modifyColumn);

            // add column for delete button
            var deleteColumn = new DataGridViewButtonColumn()
            {
                UseColumnTextForButtonValue = true,
                HeaderText = "",
                Text = "Delete"
            };
            dgvSessions.Columns.Add(deleteColumn);

            // format the column header
            dgvSessions.EnableHeadersVisualStyles = false;
            dgvSessions.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 7, FontStyle.Bold);
            dgvSessions.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            dgvSessions.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvSessions.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // format the first column
            dgvSessions.Columns[0].HeaderText = "Date";
            dgvSessions.Columns[0].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[0].Width = 90;
            dgvSessions.Columns[0].DefaultCellStyle.Format = "dd/MM/yyyy";
            dgvSessions.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Second column
            dgvSessions.Columns[1].HeaderText = "Room Number";
            dgvSessions.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[1].Width = 90;
            dgvSessions.Columns[1].DefaultCellStyle.Format = "0";
            dgvSessions.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Third column
            dgvSessions.Columns[2].HeaderText = "Topic";
            dgvSessions.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[2].Width = 90;
            dgvSessions.Columns[2].DefaultCellStyle.Format = "c";
            dgvSessions.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Forth column
            dgvSessions.Columns[3].HeaderText = "Group Members";
            dgvSessions.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[3].Width = 50;
            dgvSessions.Columns[3].DefaultCellStyle.Format = "c";
            dgvSessions.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Fifth column
            dgvSessions.Columns[4].HeaderText = "Assignment Questions";
            dgvSessions.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[4].Width = 110;
            dgvSessions.Columns[4].DefaultCellStyle.Format = "0";
            dgvSessions.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Sixth column
            dgvSessions.Columns[5].HeaderText = "Agenda";
            dgvSessions.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[5].Width = 90;
            dgvSessions.Columns[5].DefaultCellStyle.Format = "c";
            dgvSessions.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Seventh column
            dgvSessions.Columns[6].HeaderText = "Goals";
            dgvSessions.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[6].Width = 90;
            dgvSessions.Columns[6].DefaultCellStyle.Format = "c";
            dgvSessions.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Eight column
            dgvSessions.Columns[7].HeaderText = "Materials";
            dgvSessions.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[7].Width = 110;
            dgvSessions.Columns[7].DefaultCellStyle.Format = "c";
            dgvSessions.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Ninth column
            dgvSessions.Columns[8].HeaderText = "Modify Details";
            dgvSessions.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[8].Width = 90;
            dgvSessions.Columns[8].DefaultCellStyle.Format = "c";
            dgvSessions.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // format the Tenth column
            dgvSessions.Columns[9].HeaderText = "Delete Details";
            dgvSessions.Columns[9].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvSessions.Columns[9].Width = 90;
            dgvSessions.Columns[9].DefaultCellStyle.Format = "c";
            dgvSessions.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void dgvSessions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAddSessionHome_Click(object sender, EventArgs e)
        {
            SessionsForm showSessions = new SessionsForm();

            DialogResult selectedButton = showSessions.ShowDialog();
        }

        private void tabSessions_Click(object sender, EventArgs e)
        {

        }


    }
}
