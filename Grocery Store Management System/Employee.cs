using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Grocery_Store_Management_System
{
    class Employee:Operations
    {
        public Employee(DataGridView dgv=null)
        {
            DataGridView = dgv;
        }
        public override void CUD(string query)
        {
            try
            {
                con.Open();
                cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message, "Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        public override void ShowData(string query)
        {
            string Query;
            try
            {
                DataGridView.Rows.Clear();
                Query = "SELECT * FROM TableEmployee";
                con.Open();
                cmd = new SqlCommand(Query, con);
                var Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    DataGridView.Rows.Add(Reader["Employee_ID"], Reader["Employee_Name"], Reader["Employee_Password"], Reader["Employee_Address"], Reader["Employee_Role"], Reader["Employee_Salary"], Reader["Employee_Contact"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

    }
}
 