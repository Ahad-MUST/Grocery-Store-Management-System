﻿namespace BakeryInventorySystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tsBread = new System.Windows.Forms.ToolStripButton();
            this.tsListofProducts = new System.Windows.Forms.ToolStripButton();
            this.tsStockin = new System.Windows.Forms.ToolStripButton();
            this.tsStockout = new System.Windows.Forms.ToolStripButton();
            this.tsUser = new System.Windows.Forms.ToolStripButton();
            this.tsReport = new System.Windows.Forms.ToolStripButton();
            this.tsLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(60, 50);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBread,
            this.tsListofProducts,
            this.tsStockin,
            this.tsStockout,
            this.tsUser,
            this.tsReport,
            this.tsLogin});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(105, 491);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::BakeryInventorySystem.Properties.Resources.bakeshop_banner_or_cover_with_sign_on_white_round_vector_232184181;
            this.pictureBox1.Location = new System.Drawing.Point(105, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(890, 491);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tsBread
            // 
            this.tsBread.Image = ((System.Drawing.Image)(resources.GetObject("tsBread.Image")));
            this.tsBread.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsBread.Name = "tsBread";
            this.tsBread.Size = new System.Drawing.Size(102, 59);
            this.tsBread.Text = "Product";
            this.tsBread.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsBread.Click += new System.EventHandler(this.tsBread_Click);
            // 
            // tsListofProducts
            // 
            this.tsListofProducts.Image = ((System.Drawing.Image)(resources.GetObject("tsListofProducts.Image")));
            this.tsListofProducts.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsListofProducts.Name = "tsListofProducts";
            this.tsListofProducts.Size = new System.Drawing.Size(102, 59);
            this.tsListofProducts.Text = "List of Products";
            this.tsListofProducts.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsListofProducts.Click += new System.EventHandler(this.tsListofProducts_Click);
            // 
            // tsStockin
            // 
            this.tsStockin.Image = ((System.Drawing.Image)(resources.GetObject("tsStockin.Image")));
            this.tsStockin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockin.Name = "tsStockin";
            this.tsStockin.Size = new System.Drawing.Size(102, 59);
            this.tsStockin.Text = "Stockin";
            this.tsStockin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockin.Click += new System.EventHandler(this.tsStockin_Click);
            // 
            // tsStockout
            // 
            this.tsStockout.Image = ((System.Drawing.Image)(resources.GetObject("tsStockout.Image")));
            this.tsStockout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsStockout.Name = "tsStockout";
            this.tsStockout.Size = new System.Drawing.Size(102, 59);
            this.tsStockout.Text = "Stockout";
            this.tsStockout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsStockout.Click += new System.EventHandler(this.tsStockout_Click);
            // 
            // tsUser
            // 
            this.tsUser.Image = ((System.Drawing.Image)(resources.GetObject("tsUser.Image")));
            this.tsUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsUser.Name = "tsUser";
            this.tsUser.Size = new System.Drawing.Size(102, 59);
            this.tsUser.Text = "Manage Users";
            this.tsUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsUser.Click += new System.EventHandler(this.tsUser_Click);
            // 
            // tsReport
            // 
            this.tsReport.Image = ((System.Drawing.Image)(resources.GetObject("tsReport.Image")));
            this.tsReport.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsReport.Name = "tsReport";
            this.tsReport.Size = new System.Drawing.Size(102, 59);
            this.tsReport.Text = "Inventory Reports";
            this.tsReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsReport.Click += new System.EventHandler(this.tsReport_Click);
            // 
            // tsLogin
            // 
            this.tsLogin.Image = global::BakeryInventorySystem.Properties.Resources.login;
            this.tsLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsLogin.Name = "tsLogin";
            this.tsLogin.Size = new System.Drawing.Size(102, 59);
            this.tsLogin.Text = "Login";
            this.tsLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsLogin.Click += new System.EventHandler(this.tsLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 491);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsBread;
        private System.Windows.Forms.ToolStripButton tsStockin;
        private System.Windows.Forms.ToolStripButton tsStockout;
        private System.Windows.Forms.ToolStripButton tsUser;
        private System.Windows.Forms.ToolStripButton tsReport;
        private System.Windows.Forms.ToolStripButton tsLogin;
        private System.Windows.Forms.ToolStripButton tsListofProducts;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

