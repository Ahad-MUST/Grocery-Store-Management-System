
namespace Grocery_Store_Management_System
{
    partial class AdminForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Button btnHome;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            System.Windows.Forms.Button btnSwitchBilling;
            this.ExpandTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnViewSales = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ProductContainer = new System.Windows.Forms.Panel();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnViewProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnsales = new System.Windows.Forms.Button();
            this.btnViewCategory = new System.Windows.Forms.Button();
            this.CategoryContainer = new System.Windows.Forms.Panel();
            this.btnCategory = new System.Windows.Forms.Button();
            this.SalesContainer = new System.Windows.Forms.Panel();
            this.EmployeeContainer = new System.Windows.Forms.Panel();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnViewEmployee = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBill = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            btnHome = new System.Windows.Forms.Button();
            btnSwitchBilling = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.ProductContainer.SuspendLayout();
            this.CategoryContainer.SuspendLayout();
            this.SalesContainer.SuspendLayout();
            this.EmployeeContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelBill.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnHome
            // 
            btnHome.BackColor = System.Drawing.Color.Transparent;
            btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnHome.Location = new System.Drawing.Point(0, 2);
            btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnHome.MaximumSize = new System.Drawing.Size(179, 47);
            btnHome.MinimumSize = new System.Drawing.Size(179, 47);
            btnHome.Name = "btnHome";
            btnHome.Size = new System.Drawing.Size(179, 47);
            btnHome.TabIndex = 2;
            btnHome.Text = "   Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnSwitchBilling
            // 
            btnSwitchBilling.BackColor = System.Drawing.Color.Transparent;
            btnSwitchBilling.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSwitchBilling.FlatAppearance.BorderSize = 0;
            btnSwitchBilling.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            btnSwitchBilling.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            btnSwitchBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSwitchBilling.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSwitchBilling.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnSwitchBilling.Location = new System.Drawing.Point(-1, 2);
            btnSwitchBilling.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSwitchBilling.Name = "btnSwitchBilling";
            btnSwitchBilling.Size = new System.Drawing.Size(184, 62);
            btnSwitchBilling.TabIndex = 3;
            btnSwitchBilling.Text = "Switch To Selling";
            btnSwitchBilling.UseVisualStyleBackColor = false;
            btnSwitchBilling.Click += new System.EventHandler(this.btnSwitchBilling_Click);
            // 
            // ExpandTimer
            // 
            this.ExpandTimer.Interval = 35;
            this.ExpandTimer.Tick += new System.EventHandler(this.ExpandTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 121);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(17, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnViewSales
            // 
            this.btnViewSales.BackColor = System.Drawing.Color.Transparent;
            this.btnViewSales.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewSales.FlatAppearance.BorderSize = 0;
            this.btnViewSales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnViewSales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnViewSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewSales.ForeColor = System.Drawing.Color.White;
            this.btnViewSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewSales.Location = new System.Drawing.Point(20, 58);
            this.btnViewSales.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewSales.MaximumSize = new System.Drawing.Size(149, 25);
            this.btnViewSales.MinimumSize = new System.Drawing.Size(149, 25);
            this.btnViewSales.Name = "btnViewSales";
            this.btnViewSales.Size = new System.Drawing.Size(149, 25);
            this.btnViewSales.TabIndex = 5;
            this.btnViewSales.Text = "View Sales";
            this.btnViewSales.UseVisualStyleBackColor = false;
            this.btnViewSales.Click += new System.EventHandler(this.btnViewSales_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(btnHome);
            this.panel3.Location = new System.Drawing.Point(3, 206);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.MaximumSize = new System.Drawing.Size(183, 53);
            this.panel3.MinimumSize = new System.Drawing.Size(183, 53);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(183, 53);
            this.panel3.TabIndex = 1;
            // 
            // ProductContainer
            // 
            this.ProductContainer.Controls.Add(this.btnProduct);
            this.ProductContainer.Controls.Add(this.btnViewProduct);
            this.ProductContainer.Controls.Add(this.btnAddProduct);
            this.ProductContainer.Location = new System.Drawing.Point(0, 261);
            this.ProductContainer.Margin = new System.Windows.Forms.Padding(0);
            this.ProductContainer.MaximumSize = new System.Drawing.Size(183, 116);
            this.ProductContainer.MinimumSize = new System.Drawing.Size(183, 57);
            this.ProductContainer.Name = "ProductContainer";
            this.ProductContainer.Size = new System.Drawing.Size(183, 57);
            this.ProductContainer.TabIndex = 3;
            // 
            // btnProduct
            // 
            this.btnProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProduct.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnProduct.FlatAppearance.BorderSize = 0;
            this.btnProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProduct.ForeColor = System.Drawing.Color.Transparent;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProduct.Location = new System.Drawing.Point(4, 0);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(0);
            this.btnProduct.MaximumSize = new System.Drawing.Size(179, 47);
            this.btnProduct.MinimumSize = new System.Drawing.Size(179, 47);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(179, 47);
            this.btnProduct.TabIndex = 2;
            this.btnProduct.Text = "      Products";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnViewProduct
            // 
            this.btnViewProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnViewProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewProduct.FlatAppearance.BorderSize = 0;
            this.btnViewProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnViewProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnViewProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewProduct.ForeColor = System.Drawing.Color.White;
            this.btnViewProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewProduct.Location = new System.Drawing.Point(16, 54);
            this.btnViewProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewProduct.MaximumSize = new System.Drawing.Size(149, 25);
            this.btnViewProduct.MinimumSize = new System.Drawing.Size(149, 25);
            this.btnViewProduct.Name = "btnViewProduct";
            this.btnViewProduct.Size = new System.Drawing.Size(149, 25);
            this.btnViewProduct.TabIndex = 5;
            this.btnViewProduct.Text = "View Product";
            this.btnViewProduct.UseVisualStyleBackColor = false;
            this.btnViewProduct.Click += new System.EventHandler(this.btnViewProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddProduct.FlatAppearance.BorderSize = 0;
            this.btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProduct.Location = new System.Drawing.Point(15, 84);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddProduct.MaximumSize = new System.Drawing.Size(149, 25);
            this.btnAddProduct.MinimumSize = new System.Drawing.Size(149, 25);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(149, 25);
            this.btnAddProduct.TabIndex = 4;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnsales
            // 
            this.btnsales.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnsales.BackColor = System.Drawing.Color.Transparent;
            this.btnsales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsales.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnsales.FlatAppearance.BorderSize = 0;
            this.btnsales.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnsales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnsales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsales.ForeColor = System.Drawing.Color.Transparent;
            this.btnsales.Image = ((System.Drawing.Image)(resources.GetObject("btnsales.Image")));
            this.btnsales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnsales.Location = new System.Drawing.Point(3, 0);
            this.btnsales.Margin = new System.Windows.Forms.Padding(0);
            this.btnsales.MaximumSize = new System.Drawing.Size(179, 47);
            this.btnsales.MinimumSize = new System.Drawing.Size(179, 47);
            this.btnsales.Name = "btnsales";
            this.btnsales.Size = new System.Drawing.Size(179, 47);
            this.btnsales.TabIndex = 2;
            this.btnsales.Text = "    Sales";
            this.btnsales.UseVisualStyleBackColor = false;
            this.btnsales.Click += new System.EventHandler(this.btnsales_Click);
            // 
            // btnViewCategory
            // 
            this.btnViewCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnViewCategory.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewCategory.FlatAppearance.BorderSize = 0;
            this.btnViewCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnViewCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnViewCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewCategory.ForeColor = System.Drawing.Color.White;
            this.btnViewCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewCategory.Location = new System.Drawing.Point(19, 54);
            this.btnViewCategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewCategory.MaximumSize = new System.Drawing.Size(149, 31);
            this.btnViewCategory.MinimumSize = new System.Drawing.Size(149, 31);
            this.btnViewCategory.Name = "btnViewCategory";
            this.btnViewCategory.Size = new System.Drawing.Size(149, 31);
            this.btnViewCategory.TabIndex = 5;
            this.btnViewCategory.Text = "View Category";
            this.btnViewCategory.UseVisualStyleBackColor = false;
            this.btnViewCategory.Click += new System.EventHandler(this.btnViewCategory_Click);
            // 
            // CategoryContainer
            // 
            this.CategoryContainer.Controls.Add(this.btnCategory);
            this.CategoryContainer.Controls.Add(this.btnViewCategory);
            this.CategoryContainer.Location = new System.Drawing.Point(0, 318);
            this.CategoryContainer.Margin = new System.Windows.Forms.Padding(0);
            this.CategoryContainer.MaximumSize = new System.Drawing.Size(189, 95);
            this.CategoryContainer.MinimumSize = new System.Drawing.Size(189, 52);
            this.CategoryContainer.Name = "CategoryContainer";
            this.CategoryContainer.Size = new System.Drawing.Size(189, 52);
            this.CategoryContainer.TabIndex = 6;
            // 
            // btnCategory
            // 
            this.btnCategory.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnCategory.BackColor = System.Drawing.Color.Transparent;
            this.btnCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCategory.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCategory.FlatAppearance.BorderSize = 0;
            this.btnCategory.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnCategory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategory.ForeColor = System.Drawing.Color.Transparent;
            this.btnCategory.Image = ((System.Drawing.Image)(resources.GetObject("btnCategory.Image")));
            this.btnCategory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCategory.Location = new System.Drawing.Point(0, 2);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(0);
            this.btnCategory.MaximumSize = new System.Drawing.Size(179, 47);
            this.btnCategory.MinimumSize = new System.Drawing.Size(179, 47);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(179, 47);
            this.btnCategory.TabIndex = 2;
            this.btnCategory.Text = "     Category";
            this.btnCategory.UseVisualStyleBackColor = false;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // SalesContainer
            // 
            this.SalesContainer.Controls.Add(this.btnViewSales);
            this.SalesContainer.Controls.Add(this.btnsales);
            this.SalesContainer.Location = new System.Drawing.Point(0, 423);
            this.SalesContainer.Margin = new System.Windows.Forms.Padding(0);
            this.SalesContainer.MaximumSize = new System.Drawing.Size(185, 92);
            this.SalesContainer.MinimumSize = new System.Drawing.Size(185, 57);
            this.SalesContainer.Name = "SalesContainer";
            this.SalesContainer.Size = new System.Drawing.Size(185, 57);
            this.SalesContainer.TabIndex = 7;
            // 
            // EmployeeContainer
            // 
            this.EmployeeContainer.Controls.Add(this.btnAddEmployee);
            this.EmployeeContainer.Controls.Add(this.btnViewEmployee);
            this.EmployeeContainer.Controls.Add(this.btnEmployee);
            this.EmployeeContainer.Location = new System.Drawing.Point(0, 370);
            this.EmployeeContainer.Margin = new System.Windows.Forms.Padding(0);
            this.EmployeeContainer.MaximumSize = new System.Drawing.Size(183, 130);
            this.EmployeeContainer.MinimumSize = new System.Drawing.Size(183, 53);
            this.EmployeeContainer.Name = "EmployeeContainer";
            this.EmployeeContainer.Size = new System.Drawing.Size(183, 53);
            this.EmployeeContainer.TabIndex = 8;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.White;
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(16, 89);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEmployee.MaximumSize = new System.Drawing.Size(149, 30);
            this.btnAddEmployee.MinimumSize = new System.Drawing.Size(149, 30);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(149, 30);
            this.btnAddEmployee.TabIndex = 8;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // btnViewEmployee
            // 
            this.btnViewEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnViewEmployee.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnViewEmployee.FlatAppearance.BorderSize = 0;
            this.btnViewEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnViewEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnViewEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnViewEmployee.ForeColor = System.Drawing.Color.White;
            this.btnViewEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnViewEmployee.Location = new System.Drawing.Point(16, 54);
            this.btnViewEmployee.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnViewEmployee.MaximumSize = new System.Drawing.Size(149, 30);
            this.btnViewEmployee.MinimumSize = new System.Drawing.Size(149, 30);
            this.btnViewEmployee.Name = "btnViewEmployee";
            this.btnViewEmployee.Size = new System.Drawing.Size(149, 30);
            this.btnViewEmployee.TabIndex = 7;
            this.btnViewEmployee.Text = "View Employee";
            this.btnViewEmployee.UseVisualStyleBackColor = false;
            this.btnViewEmployee.Click += new System.EventHandler(this.btnViewEmployee_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.ForeColor = System.Drawing.Color.Transparent;
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(0, 1);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnEmployee.MaximumSize = new System.Drawing.Size(179, 47);
            this.btnEmployee.MinimumSize = new System.Drawing.Size(179, 47);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(179, 47);
            this.btnEmployee.TabIndex = 6;
            this.btnEmployee.Text = "       Employees";
            this.btnEmployee.UseVisualStyleBackColor = false;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Navy;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panelBill);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.ProductContainer);
            this.flowLayoutPanel1.Controls.Add(this.CategoryContainer);
            this.flowLayoutPanel1.Controls.Add(this.EmployeeContainer);
            this.flowLayoutPanel1.Controls.Add(this.SalesContainer);
            this.flowLayoutPanel1.Controls.Add(this.btnLogout);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(184, 647);
            this.flowLayoutPanel1.MinimumSize = new System.Drawing.Size(65, 647);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(65, 647);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelBill
            // 
            this.panelBill.Controls.Add(btnSwitchBilling);
            this.panelBill.Location = new System.Drawing.Point(3, 127);
            this.panelBill.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelBill.Name = "panelBill";
            this.panelBill.Size = new System.Drawing.Size(192, 75);
            this.panelBill.TabIndex = 4;
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleRole = System.Windows.Forms.AccessibleRole.MenuBar;
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Blue;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 480);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(0);
            this.btnLogout.MaximumSize = new System.Drawing.Size(179, 47);
            this.btnLogout.MinimumSize = new System.Drawing.Size(179, 47);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(179, 47);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "    Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.White;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(65, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(4);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1228, 647);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1293, 647);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ProductContainer.ResumeLayout(false);
            this.CategoryContainer.ResumeLayout(false);
            this.SalesContainer.ResumeLayout(false);
            this.EmployeeContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelBill.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer ExpandTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnViewSales;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnsales;
        private System.Windows.Forms.Panel ProductContainer;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnViewProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnViewCategory;
        private System.Windows.Forms.Panel CategoryContainer;
        private System.Windows.Forms.Panel SalesContainer;
        private System.Windows.Forms.Panel EmployeeContainer;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnViewEmployee;
        public System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelBill;
    }
}

