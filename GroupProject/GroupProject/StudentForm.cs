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
    public partial class StudentForm : Form
    {
        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            //var addModifyProductForm = new frmAddModifyProduct()
            //{
            //    AddProduct = true
            //};
            //DialogResult result = addModifyProductForm.ShowDialog();
            //if (result == DialogResult.OK)
            //{
            //    try
            //    {
            //        selectedProduct = addModifyProductForm.Product;
            //        this.productsInStock.Add(selectedProduct);
            //        DisplayProducts();
            //    }

            //    catch (Exception ex)
            //    {
            //        HandleGeneralError(ex);
            //    }
            //}
        }

        private void btnStudentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
