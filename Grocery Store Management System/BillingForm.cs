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
using System.Drawing.Printing;

namespace Grocery_Store_Management_System
{
    public partial class BillingForm : Form
    {
        public BillingForm()
        {
            InitializeComponent();
        }
        Operations operations;
        string name,ID;
        int Price,ProductTotal,Stock,UpdatedStock, total;
        bool Key;
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            operations = new Sales();
            for (int i = 0; i < dgvBill.Rows.Count - 1; i++)
            {
                operations.CUD("INSERT INTO tblSales VALUES('" + dgvBill.Rows[i].Cells[0].Value.ToString() + "','" + dgvBill.Rows[i].Cells[1].Value.ToString() + "','" + dgvBill.Rows[i].Cells[2].Value.ToString() + "','" + dgvBill.Rows[i].Cells[3].Value.ToString() + "','" + DateTime.Now + "')");
            }
            lblsubtotal.Text ="Sub Total: "+ total.ToString();
            lbltax.Text = "Tax: "+((total / 100) * 5).ToString();
            lbltotal.Text = "Total: "+(total + ((total / 100) * 5)).ToString();
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new PaperSize("pprnm", 150, 250);
            printDocument1.Print();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics graphics = e.Graphics;
            Font font = new Font("Courier New", 12);
            int offset = 60;
            graphics.DrawString("XYZ Grocery Store", new Font("Courier New", 18, FontStyle.Bold), new SolidBrush(Color.Black), new Point(120));
            graphics.DrawString("Name" + "\t\t" + "Price" + "\t\t" + "QTY"+"\t\tSub Total", font, new SolidBrush(Color.Black), new Point(20,40));
            for (int i = 0; i < dgvBill.Rows.Count-1; i++)
            {
                graphics.DrawString(dgvBill.Rows[i].Cells[0].Value.ToString() , font, new SolidBrush(Color.Black), 20, offset);
                graphics.DrawString(dgvBill.Rows[i].Cells[1].Value.ToString() , font, new SolidBrush(Color.Black), 150, offset);
                graphics.DrawString(dgvBill.Rows[i].Cells[2].Value.ToString() , font, new SolidBrush(Color.Black), 290,offset);
                graphics.DrawString(dgvBill.Rows[i].Cells[3].Value.ToString() , font, new SolidBrush(Color.Black), 430,offset);
                offset += 20;
            }
            graphics.DrawString("Total" + "\t\t" + total.ToString(), new Font("Courier New", 14, FontStyle.Bold), new SolidBrush(Color.Black), 100,offset);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdminForm frm = new AdminForm();
            this.Hide();
            frm.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dgvBill.Rows.Clear();
            lblsubtotal.Text = "Sub Total: ";
            lbltax.Text = "Tax: ";
            lbltotal.Text = "Total: ";
            total = 0;
        }
        private void BillingForm_Load(object sender, EventArgs e)
        {
            operations = new Billing(dgvAllProducts);
            operations.CUD("SELECT * FROM TableProduct");
        }
        private void dgvAllProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                ID = dgvAllProducts.Rows[e.RowIndex].Cells[1].Value.ToString();
                name = dgvAllProducts.Rows[e.RowIndex].Cells[2].Value.ToString();
                Price = int.Parse(dgvAllProducts.Rows[e.RowIndex].Cells[3].Value.ToString());
                Stock = int.Parse(dgvAllProducts.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            if (Name=="")
            {
                Key = false;
            }
            else
            {
                Key = true;
            }
        }
        private void btnAddToBill_Click(object sender, EventArgs e)
        {
            if (Key)
            {
                if (int.Parse(comboQTY.Text)<=Stock)
                {
                    ProductTotal = int.Parse(comboQTY.Text) * Price;
                    total += ProductTotal;
                    dgvBill.Rows.Add(name, Price, comboQTY.Text, ProductTotal);
                    operations = new Product(null);
                    UpdatedStock = Stock - (int.Parse(comboQTY.Text));
                    operations.CUD("UPDATE TableProduct SET Product_Quantity='" + UpdatedStock+ "' WHERE Product_ID='"+ID+"'");
                }
                else
                {
                    MessageBox.Show("Not Enough Stock","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
