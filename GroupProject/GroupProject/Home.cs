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
        public Home()
        {
            InitializeComponent();
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

        private void DisplayProducts()
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
            dgvStudent.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            dgvStudent.ColumnHeadersDefaultCellStyle.BackColor = Color.Goldenrod;
            dgvStudent.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // format the odd numbered rows
            dgvStudent.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleGoldenrod;

            // format the first column
            dgvStudent.Columns[0].HeaderText = "Name";
            dgvStudent.Columns[0].Width = 110;

            // format the second column
            dgvStudent.Columns[1].Width = 240;

            // format the third column
            dgvStudent.Columns[2].HeaderText = "Age";
            dgvStudent.Columns[2].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[2].Width = 90;
            dgvStudent.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the forth column
            dgvStudent.Columns[3].HeaderText = "Gender";
            dgvStudent.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[3].Width = 90;
            dgvStudent.Columns[3].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                // format the fifth column
            dgvStudent.Columns[4].HeaderText = "Year";
            dgvStudent.Columns[4].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[4].Width = 90;
            dgvStudent.Columns[4].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the Sixth column
            dgvStudent.Columns[5].HeaderText = "Knumber";
            dgvStudent.Columns[5].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[5].Width = 90;
            dgvStudent.Columns[5].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the seventh column
            dgvStudent.Columns[6].HeaderText = "County";
            dgvStudent.Columns[6].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[6].Width = 90;
            dgvStudent.Columns[6].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the Eight column
            dgvStudent.Columns[7].HeaderText = "Availibility";
            dgvStudent.Columns[7].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[7].Width = 90;
            dgvStudent.Columns[7].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // format the Ninth column
            dgvStudent.Columns[8].HeaderText = "Phone Number";
            dgvStudent.Columns[8].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvStudent.Columns[8].Width = 90;
            dgvStudent.Columns[8].DefaultCellStyle.Format = "c";
            dgvStudent.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------


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
