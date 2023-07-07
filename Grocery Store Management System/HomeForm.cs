using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Store_Management_System
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }
        private Form activeform = null;
        public void OpenChildForm(Form Childform)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = Childform;
            Childform.TopLevel = false;
            MainPanel.Controls.Add(Childform);
            MainPanel.Tag = Childform;
            MainPanel.BringToFront();
            Childform.BringToFront();
            Childform.Show();
        }

        private void PanelProduct_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ProductForm());
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CategoryForm());
        }
        private void btnsales_click(object sender, EventArgs e)
        {
            OpenChildForm(new SalesForm());
        }
    }
}
