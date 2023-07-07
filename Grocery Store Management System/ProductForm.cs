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
    public partial class ProductForm : Form
    {
        AddProductForm frm;
        Operations operations;
        public ProductForm()
        {
            InitializeComponent();
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frm = new AddProductForm();
            frm.Show();
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            operations= new Product(dgvProduct);
            operations.ShowData( "SELECT * FROM TableProduct");
            operations.LoadCategories("SELECT *FROM TableCategory", comboCategory);
        }
        private void dgvProduct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvProduct.Columns[e.ColumnIndex].Name;
            frm = new AddProductForm();
            if (colName=="Edit")
            {
                try
                {
                    frm.Show();
                    frm.txtProductID.Text = dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString();
                    frm.txtProductName.Text = dgvProduct.Rows[e.RowIndex].Cells[2].Value.ToString();
                    frm.comboCategory.Text = dgvProduct.Rows[e.RowIndex].Cells[3].Value.ToString();
                    frm.txtProductPrice.Text = dgvProduct.Rows[e.RowIndex].Cells[4].Value.ToString();
                    frm.txtProductQuantity.Text = dgvProduct.Rows[e.RowIndex].Cells[5].Value.ToString();
                    frm.txtProductID.Enabled = false;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }          
            }
            else if(colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete the Record","Information",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    operations = new Product();
                    operations.CUD("DELETE FROM TableProduct WHERE Product_ID LIKE '" + dgvProduct.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                }
                operations = new Product(dgvProduct);
                operations.ShowData("SELECT * FROM TableProduct");
            }
        }
        private void comboCategory_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string category = comboCategory.Text;
            operations = new Product(dgvProduct);
            
            if (category == "All")
            {
                operations.ShowData("SELECT * FROM TableProduct");
            }
            else
            {
                operations.ShowData("SELECT * FROM TableProduct WHERE Product_Category Like'" + category + "'");
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            operations = new Product(dgvProduct);
            operations.ShowData("SELECT * FROM TableProduct WHERE Product_Name LIKE '%" + txtSearch.Text + "%'");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            operations = new Product(dgvProduct);
            operations.ShowData("SELECT * FROM TableProduct WHERE Product_Name LIKE '%" + txtSearch.Text + "%'");
            if (dgvProduct.Rows.Count == 1)
            {
                MessageBox.Show("No Product Found", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
