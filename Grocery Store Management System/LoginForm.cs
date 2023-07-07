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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string Role = "";
            if (RadioAdmin.Checked == true)
            {
                Role = "Admin";
            }
            else if (RadioEmployee.Checked == true)
            {
                Role = "Employee";
            }
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-784AJUE;Initial Catalog=Grocery Store Management System;Integrated Security=True");
                SqlCommand cmd = new SqlCommand("SELECT * FROM TableEmployee WHERE Employee_ID='" + txtusername.Text + "'AND Employee_Password='" + txtPassword.Text + "' AND Employee_Role='"+Role+"'", con);
                cmd.Parameters.AddWithValue("@Employee_ID", txtusername.Text);
                cmd.Parameters.AddWithValue("@Employee_Password", txtPassword.Text);
                cmd.Parameters.AddWithValue("@Employee_Role", Role);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    if (Role=="Admin")
                    {
                        AdminForm frm = new AdminForm();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        BillingForm frm = new BillingForm();
                        frm.btnAdmin.Enabled = false;
                        frm.Show();
                        this.Hide();
                    }
                     
                }
                else
                {
                    MessageBox.Show("Incorrect Login\nPlease try again", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

             
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
