using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Grocery_Store_Management_System
{
    class Billing:Operations
    {
        public Billing(DataGridView dgv=null)
        {
            DataGridView = dgv;
        }
        public override void CUD(string query)
        {
            int i = 1;
            try
            {
                DataGridView.Rows.Clear();
                con.Open();
                cmd = new SqlCommand(query, con);
                var Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    DataGridView.Rows.Add(i, Reader["Product_ID"].ToString(), Reader["Product_Name"].ToString(), Reader["Product_Price"].ToString(), Reader["Product_Quantity"].ToString());
                    i++;
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
