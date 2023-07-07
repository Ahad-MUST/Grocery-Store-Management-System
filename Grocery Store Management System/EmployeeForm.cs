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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }
        AddEmployeesForm frm = new AddEmployeesForm();
        Operations operations;
        private void AdEmplyee_Click(object sender, EventArgs e)
        {
            frm.txtEmpID.Enabled = true;
            frm.Show();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            operations = new Employee(dgvEmployee);
            operations.ShowData("SELECT * FROM TableEmployee");
        }
        private void dgvEmployee_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvEmployee.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                try
                {
                    frm.Show();
                    frm.txtEmpID.Text = dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString();
                    frm.txtEmployeeName.Text = dgvEmployee.Rows[e.RowIndex].Cells[1].Value.ToString();
                    frm.txtEmployeePassword.Text = dgvEmployee.Rows[e.RowIndex].Cells[2].Value.ToString();
                    frm.txtEmpAddress.Text = dgvEmployee.Rows[e.RowIndex].Cells[3].Value.ToString();
                    frm.txtEmpSalary.Text = dgvEmployee.Rows[e.RowIndex].Cells[5].Value.ToString();
                    frm.txtEmpContact.Text = dgvEmployee.Rows[e.RowIndex].Cells[6].Value.ToString();
                    frm.txtEmpID.Enabled = false;
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to Delete the Record", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    operations = new Employee(dgvEmployee);
                    operations.CUD("DELETE FROM TableEmployee WHERE Employee_ID LIKE '" + dgvEmployee.Rows[e.RowIndex].Cells[0].Value.ToString() + "'");
                    operations.ShowData("SELECT * FROM TableEmployee");
                }
            }
        }
    }
}
