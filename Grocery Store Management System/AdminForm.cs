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
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            ExpandTimer.Start();
        }
        bool Expand;
        private Form activeform = null;
        public void OpenChildForm(Form Childform)
        {
            if (activeform != null)
            {
                activeform.Dispose();
            }
            activeform = Childform;
            Childform.TopLevel = false;
            MainPanel.Controls.Add(Childform);
            Childform.BringToFront();
            Childform.Show();
        }
        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
        }
        private void btnMenu_Click(object sender, EventArgs e)
        {
            ExpandTimer.Start();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            if (ProductContainer.Height == ProductContainer.MinimumSize.Height)
            {
                ProductContainer.Height = ProductContainer.MaximumSize.Height;
            }
            else
            {
                ProductContainer.Height = ProductContainer.MinimumSize.Height;
            }
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            if (CategoryContainer.Height == CategoryContainer.MinimumSize.Height)
            {
                CategoryContainer.Height = CategoryContainer.MaximumSize.Height;
            }
            else
            {
                CategoryContainer.Height = CategoryContainer.MinimumSize.Height;
            }
        }
        private void btnsales_Click(object sender, EventArgs e)
        {
            if (SalesContainer.Height == SalesContainer.MinimumSize.Height)
            {
                SalesContainer.Height = SalesContainer.MaximumSize.Height;
            }
            else
            {
                SalesContainer.Height = SalesContainer.MinimumSize.Height;
            }
        }
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (EmployeeContainer.Height==EmployeeContainer.MinimumSize.Height)
            {
                EmployeeContainer.Height = EmployeeContainer.MaximumSize.Height;
            }
            else
            {
                EmployeeContainer.Height = EmployeeContainer.MinimumSize.Height;
            }
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            this.Hide();
            frm.Show();
        }
        private void ExpandTimer_Tick(object sender, EventArgs e)
        {
            if (Expand)
            {
                flowLayoutPanel1.Width -= 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MinimumSize.Width)
                {
                    Expand = false;
                    ExpandTimer.Stop();
                }
            }
            else
            {
                flowLayoutPanel1.Width += 10;
                if (flowLayoutPanel1.Width == flowLayoutPanel1.MaximumSize.Width)
                {
                    Expand = true;
                    ExpandTimer.Stop();
                }
            }
        }

        private void btnViewProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm());           
        }
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProductForm frm = new AddProductForm();
            frm.Show();
        }
        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            AddEmployeesForm frm = new AddEmployeesForm();
            frm.Show();
        }
        private void btnViewEmployee_Click(object sender, EventArgs e)
        {
            OpenChildForm(new EmployeeForm());
        }
        private void btnViewCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm());
        }
        private void AdminForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
        }

        private void btnSwitchBilling_Click(object sender, EventArgs e)
        {
            BillingForm frm = new BillingForm();
            frm.Show();
            this.Hide();
        }

        private void btnViewSales_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesForm());
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
