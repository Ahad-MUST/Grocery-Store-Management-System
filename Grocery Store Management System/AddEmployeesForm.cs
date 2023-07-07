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
    public partial class AddEmployeesForm : Form
    {
        Operations operations;
        public string Role = "";
        public AddEmployeesForm()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            Clear();
        }
        private void Clear()
        {
            txtEmpAddress.Clear();
            txtEmpContact.Clear();
            txtEmpID.Clear();
            txtEmployeeName.Clear();
            txtEmployeePassword.Clear();
            txtEmpSalary.Clear();
        }
        private void CheckRole()
        {
            if (RadioAdmin.Checked == true)
            {
                Role = "Admin";
            }
            else if (RadioEmployee.Checked == true)
            {
                Role = "Employee";
            }
            else
            {
                MessageBox.Show("Please Select a Role and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnAddEmployee_Click_1(object sender, EventArgs e)
        {
            operations = new Employee();
            CheckRole();
            operations.CUD("INSERT INTO TableEmployee VALUES('" + txtEmpID.Text + "','" + txtEmployeeName.Text + "','" + txtEmpAddress.Text + "','" + int.Parse(txtEmpSalary.Text)+ "','" + int.Parse(txtEmpContact.Text) + "','"+Role+ "','" + txtEmployeePassword.Text + "')");
            MessageBox.Show("Employee Added Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnUpdateEmployee_Click(object sender, EventArgs e)
        {
            operations = new Employee();
            CheckRole();
            operations.CUD("UPDATE TableEmployee SET Employee_Name = '" + txtEmployeeName.Text + "',  Employee_Address = '" + txtEmpAddress.Text + "',Employee_Salary='" + txtEmpSalary.Text + "', Employee_Contact = '" + txtEmpContact.Text + "', Employee_Password = '" +txtEmployeePassword.Text+ "',Employee_Role='"+Role+"' WHERE Employee_ID = '" + txtEmpID.Text + "'");
            MessageBox.Show("Employee Updated Successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AddEmployeesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
