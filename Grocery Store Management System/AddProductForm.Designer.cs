
namespace Grocery_Store_Management_System
{
    partial class AddProductForm
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
            System.Windows.Forms.Button btnUpdateProduct;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            System.Windows.Forms.Button btnAddProduct;
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.lblName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProductID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProductName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProductPrice = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtProductQuantity = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.comboCategory = new System.Windows.Forms.ComboBox();
            btnUpdateProduct = new System.Windows.Forms.Button();
            btnAddProduct = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.BackColor = System.Drawing.Color.Transparent;
            btnUpdateProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            btnUpdateProduct.FlatAppearance.BorderSize = 0;
            btnUpdateProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnUpdateProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnUpdateProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnUpdateProduct.ForeColor = System.Drawing.Color.Black;
            btnUpdateProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProduct.Image")));
            btnUpdateProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnUpdateProduct.Location = new System.Drawing.Point(343, 366);
            btnUpdateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new System.Drawing.Size(201, 42);
            btnUpdateProduct.TabIndex = 26;
            btnUpdateProduct.Text = "    Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = false;
            btnUpdateProduct.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddProduct
            // 
            btnAddProduct.BackColor = System.Drawing.Color.Transparent;
            btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnAddProduct.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnAddProduct.ForeColor = System.Drawing.Color.Black;
            btnAddProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProduct.Image")));
            btnAddProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnAddProduct.Location = new System.Drawing.Point(108, 366);
            btnAddProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new System.Drawing.Size(179, 42);
            btnAddProduct.TabIndex = 25;
            btnAddProduct.Text = "   Add Product";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 31);
            this.panel1.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(16, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grocery Store Management System";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.InitialImage = null;
            this.btnExit.Location = new System.Drawing.Point(712, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(24, 22);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(153, 139);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 20);
            this.lblName.TabIndex = 15;
            this.lblName.Text = "Product Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Product Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 295);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "Product Category:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(183, 92);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(94, 20);
            this.lblID.TabIndex = 18;
            this.lblID.Text = "Product ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product Quantity:";
            // 
            // txtProductID
            // 
            this.txtProductID.Depth = 0;
            this.txtProductID.Hint = "";
            this.txtProductID.Location = new System.Drawing.Point(299, 85);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.SelectedText = "";
            this.txtProductID.SelectionLength = 0;
            this.txtProductID.SelectionStart = 0;
            this.txtProductID.Size = new System.Drawing.Size(224, 28);
            this.txtProductID.TabIndex = 20;
            this.txtProductID.UseSystemPasswordChar = false;
            // 
            // txtProductName
            // 
            this.txtProductName.Depth = 0;
            this.txtProductName.Hint = "";
            this.txtProductName.Location = new System.Drawing.Point(299, 132);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.SelectedText = "";
            this.txtProductName.SelectionLength = 0;
            this.txtProductName.SelectionStart = 0;
            this.txtProductName.Size = new System.Drawing.Size(224, 28);
            this.txtProductName.TabIndex = 21;
            this.txtProductName.UseSystemPasswordChar = false;
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Depth = 0;
            this.txtProductPrice.Hint = "";
            this.txtProductPrice.Location = new System.Drawing.Point(299, 183);
            this.txtProductPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductPrice.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.PasswordChar = '\0';
            this.txtProductPrice.SelectedText = "";
            this.txtProductPrice.SelectionLength = 0;
            this.txtProductPrice.SelectionStart = 0;
            this.txtProductPrice.Size = new System.Drawing.Size(224, 28);
            this.txtProductPrice.TabIndex = 23;
            this.txtProductPrice.UseSystemPasswordChar = false;
            // 
            // txtProductQuantity
            // 
            this.txtProductQuantity.Depth = 0;
            this.txtProductQuantity.Hint = "";
            this.txtProductQuantity.Location = new System.Drawing.Point(299, 231);
            this.txtProductQuantity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtProductQuantity.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtProductQuantity.Name = "txtProductQuantity";
            this.txtProductQuantity.PasswordChar = '\0';
            this.txtProductQuantity.SelectedText = "";
            this.txtProductQuantity.SelectionLength = 0;
            this.txtProductQuantity.SelectionStart = 0;
            this.txtProductQuantity.Size = new System.Drawing.Size(224, 28);
            this.txtProductQuantity.TabIndex = 24;
            this.txtProductQuantity.UseSystemPasswordChar = false;
            // 
            // comboCategory
            // 
            this.comboCategory.BackColor = System.Drawing.Color.White;
            this.comboCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCategory.ForeColor = System.Drawing.Color.Blue;
            this.comboCategory.Location = new System.Drawing.Point(299, 290);
            this.comboCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboCategory.Name = "comboCategory";
            this.comboCategory.Size = new System.Drawing.Size(223, 28);
            this.comboCategory.TabIndex = 27;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 474);
            this.Controls.Add(this.comboCategory);
            this.Controls.Add(btnUpdateProduct);
            this.Controls.Add(btnAddProduct);
            this.Controls.Add(this.txtProductQuantity);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FromAddProduct";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label4;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtProductID;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtProductName;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtProductPrice;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtProductQuantity;
        public System.Windows.Forms.ComboBox comboCategory;
    }
}