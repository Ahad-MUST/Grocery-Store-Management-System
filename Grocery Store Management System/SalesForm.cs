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
    public partial class SalesForm : Form
    {
        public SalesForm()
        {
            InitializeComponent();
        }
        Operations operations;
        private void SalesForm_Load(object sender, EventArgs e)
        {
            operations = new Sales(dgvSales);
            operations.ShowData("SELECT * FROM tblSales");
        }
        private void comboSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            int days = 0;
            operations = new Sales(dgvSales);
            if (comboSales.Text == "Day")
            {
                days = 1;
            }
            else if (comboSales.Text=="All")
            {
                operations.ShowData("SELECT *FROM tblSales");
            }
            else if (comboSales.Text=="Week")
            {
                days = 7;
            }
            else if (comboSales.Text=="Month")
            {
                days = 30;
            }
            operations.ShowData(" SELECT * FROM tblSales WHERE SDateTime BETWEEN '" + (System.DateTime.Today - System.TimeSpan.FromDays(days)) + "' AND '" + System.DateTime.Now + "'");
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            operations = new Sales(dgvSales);
            operations.ShowData("SELECT *FROM tblSales WHERE SName LIKE '%" + txtSearch.Text + "%'");
        }

        private void btnShowStats_Click(object sender, EventArgs e)
        {
            Sales obj = new Sales();
            obj.CalculateStats(dgvSales);
            MessageBox.Show("Total Sales: "+obj.total+"\n10% Profit: "+obj.profit10+"\n20% Profit: "+obj.profit20);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            operations = new Sales();
            operations.CUD("DELETE FROM tblSales");
            MessageBox.Show("Deleted Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            SalesForm_Load(null, null);
        }
    }
}
