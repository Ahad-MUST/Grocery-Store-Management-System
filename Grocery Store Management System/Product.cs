using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Grocery_Store_Management_System
{
    class Product:Operations
    {
        public Product(DataGridView dgv)
        {
            DataGridView = dgv;
        }
        public Product()
        {

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
            int SNo = 1;
            try
            {
                DataGridView.Rows.Clear();
                con.Open();
                cmd = new SqlCommand(query, con);
                var Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    DataGridView.Rows.Add(SNo, Reader["Product_ID"].ToString(), Reader["Product_Name"].ToString(), Reader["Product_Category"].ToString(), Reader["Product_Price"].ToString(), Reader["Product_Quantity"].ToString());
                    SNo++;
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
