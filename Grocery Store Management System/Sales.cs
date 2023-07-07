using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Store_Management_System
{
    class Sales :Operations
    {
        private double TotalSales=0;
        private double Profit10,Profit20;
        public double total
        {
            get { return TotalSales; }
            set { TotalSales = value; }
        }
        public double profit10
        {
            get { return Profit10; }
            set { Profit10 = value; }
        }
        public double profit20
        {
            get { return Profit20; }
            set { Profit20 = value; }
        }
        public Sales(DataGridView dgv=null)
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
            try
            {
                DataGridView.Rows.Clear();
                con.Open();
                cmd = new SqlCommand(query, con);
                var Reader = cmd.ExecuteReader();
                while (Reader.Read())
                {
                    DataGridView.Rows.Add(Reader["SName"].ToString(), Reader["SPrice"].ToString(), Reader["SQTY"].ToString(), Reader["SSubTotal"].ToString(), Reader["SDateTime"].ToString());
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
        public void CalculateStats(DataGridView dgv)
        {
            for (int i = 0; i < dgv.Rows.Count-1; i++)
            {
                TotalSales += double.Parse(dgv.Rows[i].Cells[3].Value.ToString());
            }
            Profit10 = (TotalSales / 100) * 10;
            Profit20 = (TotalSales / 100) * 20;
        }
    }
}
