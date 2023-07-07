using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Grocery_Store_Management_System
{
    public partial class CategoryForm : Form
    {
        public CategoryForm()
        {
            InitializeComponent();
        }
        Operations operations;
        private void CategoryForm_Load(object sender, EventArgs e)
        {
            operations = new Category(dgvCategory);
            Category obj = new Category();
            operations.ShowData("SELECT *FROM TableCategory");
        }
        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName= dgvCategory.Columns[e.ColumnIndex].Name;
            if (colName=="Edit")
            {
                txtCatID.Enabled = false;
                txtCatID.Text = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCatname.Text= dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if (colName=="Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete the category?\n(NOTE: All the products of this category will be deleted)","Decesion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    operations = new Category(dgvCategory);
                    operations.CUD("DELETE FROM TableProduct WHERE Product_Category LIKE '" + dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                    operations.CUD("DELETE FROM TableCategory WHERE Category_ID = '" + dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                    operations.ShowData("SELECT *FROM TableCategory");
                }
            }
        }
        private void btnUpdateCategory_Click(object sender, EventArgs e)
        {
            operations = new Category(dgvCategory);
            operations.CUD("UPDATE TableCategory SET Category_ID='" + txtCatID.Text + "',Category_Name='" + txtCatname.Text + "' WHERE Category_ID='"+txtCatID.Text+"'");
            MessageBox.Show("Product Updated Successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            operations.ShowData("SELECT *FROM TableCategory");
        }
        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            operations = new Category(dgvCategory);
            operations.CUD("INSERT INTO TableCategory VALUES('" + txtCatID.Text + "','" + txtCatname.Text + "')");
            MessageBox.Show("Category Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            operations.ShowData("SELECT *FROM TableCategory");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCatID.Enabled = true;
            txtCatname.Clear();
            txtCatID.Clear();
        }
    }
}
