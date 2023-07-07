using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Grocery_Store_Management_System
{
    abstract class Operations
    {
        protected SqlConnection con = new SqlConnection("Data Source=DESKTOP-784AJUE;Initial Catalog=Grocery Store Management System;Integrated Security=True");
        protected SqlCommand cmd;
        protected DataGridView DataGridView;
        public abstract void CUD(string query);
        public virtual void ShowData(string query)
        {

        }
        public void LoadCategories(string Query, ComboBox combo)
        {
            con.Open();
            cmd = new SqlCommand(Query, con);
            var Reader = cmd.ExecuteReader();
            while (Reader.Read())
            {
                combo.Items.Add(Reader["Category_Name"]);
            }
            con.Close();
        }
    }
}
