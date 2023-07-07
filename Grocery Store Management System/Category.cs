using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Grocery_Store_Management_System
{
    class Category:Operations
    {
        public Category(DataGridView dgv=null)
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
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
        public override void ShowData(string query)
        {
            try
            {
                DataGridView.Rows.Clear();
                con.Open();
                cmd = new SqlCommand(query, con);
                var Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    DataGridView.Rows.Add(Reader["Category_ID"].ToString(), Reader["Category_Name"].ToString());
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
