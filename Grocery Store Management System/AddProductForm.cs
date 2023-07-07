using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store_Management_System
{
    public partial class AddProductForm : Form
    {
        public AddProductForm()
        {
            InitializeComponent();
        }
        Operations operation;
        
        private void Clear()
        {
            txtProductID.Clear();
            txtProductName.Clear();
            txtProductPrice.Clear();
            txtProductQuantity.Clear();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            GC.Collect();
        }  
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            operation = new Product(null);
            operation.CUD("INSERT INTO TableProduct VALUES('" + txtProductID.Text + "','" + txtProductName.Text + "','" + comboCategory.Text+ "','" + float.Parse(txtProductPrice.Text) + "','" +float.Parse(txtProductQuantity.Text) + "')");
            MessageBox.Show("Product Added Successfully","Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Clear();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            operation = new Product(null);
            operation.CUD("UPDATE TableProduct SET Product_Name='" + txtProductName.Text + "',Product_Category='" + comboCategory.Text+ "',Product_Price='" + txtProductPrice.Text + "',Product_Quantity='" + txtProductQuantity.Text + "' WHERE Product_ID ='" + txtProductID.Text + "'");
            MessageBox.Show("Product Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-784AJUE;Initial Catalog=Grocery Store Management System;Integrated Security=True");
            SqlCommand cmd = new SqlCommand(" SELECT Category_Name FROM TableCategory", con);
            con.Open();
            var Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                comboCategory.Items.Add(Reader["Category_Name"]);
            }
            con.Close();
        }
    }
}
