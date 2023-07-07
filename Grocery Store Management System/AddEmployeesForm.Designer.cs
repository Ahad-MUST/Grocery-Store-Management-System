
namespace Grocery_Store_Management_System
{
    partial class AddEmployeesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEmployeesForm));
            this.lblEmpId = new System.Windows.Forms.Label();
            this.lblEmpAddress = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtEmpID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmpAddress = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtEmpSalary = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.PictureBox();
            this.txtEmployeeName = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmpContact = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.btnUpdateEmployee = new System.Windows.Forms.Button();
            this.txtEmployeePassword = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.label5 = new System.Windows.Forms.Label();
            this.RadioEmployee = new MaterialSkin.Controls.MaterialRadioButton();
            this.RadioAdmin = new MaterialSkin.Controls.MaterialRadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEmpId
            // 
            this.lblEmpId.AutoSize = true;
            this.lblEmpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpId.Location = new System.Drawing.Point(146, 76);
            this.lblEmpId.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpId.Name = "lblEmpId";
            this.lblEmpId.Size = new System.Drawing.Size(73, 15);
            this.lblEmpId.TabIndex = 18;
            this.lblEmpId.Text = "Emplyee ID:";
            // 
            // lblEmpAddress
            // 
            this.lblEmpAddress.AutoSize = true;
            this.lblEmpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpAddress.Location = new System.Drawing.Point(96, 170);
            this.lblEmpAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpAddress.Name = "lblEmpAddress";
            this.lblEmpAddress.Size = new System.Drawing.Size(130, 17);
            this.lblEmpAddress.TabIndex = 2;
            this.lblEmpAddress.Text = "Employee Address:";
            this.lblEmpAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(104, 220);
            this.lblRole.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(122, 17);
            this.lblRole.TabIndex = 3;
            this.lblRole.Text = "Employee Salary: ";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Depth = 0;
            this.txtEmpID.Hint = "";
            this.txtEmpID.Location = new System.Drawing.Point(230, 67);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.PasswordChar = '\0';
            this.txtEmpID.SelectedText = "";
            this.txtEmpID.SelectionLength = 0;
            this.txtEmpID.SelectionStart = 0;
            this.txtEmpID.Size = new System.Drawing.Size(196, 23);
            this.txtEmpID.TabIndex = 21;
            this.txtEmpID.UseSystemPasswordChar = false;
            // 
            // txtEmpAddress
            // 
            this.txtEmpAddress.Depth = 0;
            this.txtEmpAddress.Hint = "";
            this.txtEmpAddress.Location = new System.Drawing.Point(230, 163);
            this.txtEmpAddress.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpAddress.Name = "txtEmpAddress";
            this.txtEmpAddress.PasswordChar = '\0';
            this.txtEmpAddress.SelectedText = "";
            this.txtEmpAddress.SelectionLength = 0;
            this.txtEmpAddress.SelectionStart = 0;
            this.txtEmpAddress.Size = new System.Drawing.Size(196, 23);
            this.txtEmpAddress.TabIndex = 22;
            this.txtEmpAddress.UseSystemPasswordChar = false;
            // 
            // txtEmpSalary
            // 
            this.txtEmpSalary.Depth = 0;
            this.txtEmpSalary.Hint = "";
            this.txtEmpSalary.Location = new System.Drawing.Point(230, 214);
            this.txtEmpSalary.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpSalary.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpSalary.Name = "txtEmpSalary";
            this.txtEmpSalary.PasswordChar = '\0';
            this.txtEmpSalary.SelectedText = "";
            this.txtEmpSalary.SelectionLength = 0;
            this.txtEmpSalary.SelectionStart = 0;
            this.txtEmpSalary.Size = new System.Drawing.Size(196, 23);
            this.txtEmpSalary.TabIndex = 23;
            this.txtEmpSalary.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 25);
            this.panel1.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Grocery Store Management System";
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.InitialImage = null;
            this.btnExit.Location = new System.Drawing.Point(534, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(18, 18);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnExit.TabIndex = 6;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Depth = 0;
            this.txtEmployeeName.Hint = "";
            this.txtEmployeeName.Location = new System.Drawing.Point(230, 113);
            this.txtEmployeeName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeeName.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.PasswordChar = '\0';
            this.txtEmployeeName.SelectedText = "";
            this.txtEmployeeName.SelectionLength = 0;
            this.txtEmployeeName.SelectionStart = 0;
            this.txtEmployeeName.Size = new System.Drawing.Size(196, 23);
            this.txtEmployeeName.TabIndex = 32;
            this.txtEmployeeName.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(110, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 31;
            this.label1.Text = "Employee Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtEmpContact
            // 
            this.txtEmpContact.Depth = 0;
            this.txtEmpContact.Hint = "";
            this.txtEmpContact.Location = new System.Drawing.Point(230, 267);
            this.txtEmpContact.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmpContact.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmpContact.Name = "txtEmpContact";
            this.txtEmpContact.PasswordChar = '\0';
            this.txtEmpContact.SelectedText = "";
            this.txtEmpContact.SelectionLength = 0;
            this.txtEmpContact.SelectionStart = 0;
            this.txtEmpContact.Size = new System.Drawing.Size(196, 23);
            this.txtEmpContact.TabIndex = 34;
            this.txtEmpContact.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(95, 274);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 17);
            this.label3.TabIndex = 33;
            this.label3.Text = "Employee Contact: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAddEmployee.FlatAppearance.BorderSize = 0;
            this.btnAddEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEmployee.Image")));
            this.btnAddEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEmployee.Location = new System.Drawing.Point(102, 443);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(138, 41);
            this.btnAddEmployee.TabIndex = 35;
            this.btnAddEmployee.Text = "       Add Employee";
            this.btnAddEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEmployee.UseVisualStyleBackColor = false;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click_1);
            // 
            // btnUpdateEmployee
            // 
            this.btnUpdateEmployee.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdateEmployee.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnUpdateEmployee.FlatAppearance.BorderSize = 0;
            this.btnUpdateEmployee.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateEmployee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnUpdateEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateEmployee.Image")));
            this.btnUpdateEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateEmployee.Location = new System.Drawing.Point(268, 443);
            this.btnUpdateEmployee.Name = "btnUpdateEmployee";
            this.btnUpdateEmployee.Size = new System.Drawing.Size(158, 41);
            this.btnUpdateEmployee.TabIndex = 36;
            this.btnUpdateEmployee.Text = "         Update Employee";
            this.btnUpdateEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdateEmployee.UseVisualStyleBackColor = false;
            this.btnUpdateEmployee.Click += new System.EventHandler(this.btnUpdateEmployee_Click);
            // 
            // txtEmployeePassword
            // 
            this.txtEmployeePassword.Depth = 0;
            this.txtEmployeePassword.Hint = "";
            this.txtEmployeePassword.Location = new System.Drawing.Point(230, 318);
            this.txtEmployeePassword.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmployeePassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtEmployeePassword.Name = "txtEmployeePassword";
            this.txtEmployeePassword.PasswordChar = '\0';
            this.txtEmployeePassword.SelectedText = "";
            this.txtEmployeePassword.SelectionLength = 0;
            this.txtEmployeePassword.SelectionStart = 0;
            this.txtEmployeePassword.Size = new System.Drawing.Size(196, 23);
            this.txtEmployeePassword.TabIndex = 38;
            this.txtEmployeePassword.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(83, 325);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Employee Password: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // RadioEmployee
            // 
            this.RadioEmployee.AutoSize = true;
            this.RadioEmployee.Depth = 0;
            this.RadioEmployee.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioEmployee.Location = new System.Drawing.Point(347, 375);
            this.RadioEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.RadioEmployee.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioEmployee.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioEmployee.Name = "RadioEmployee";
            this.RadioEmployee.Ripple = true;
            this.RadioEmployee.Size = new System.Drawing.Size(89, 30);
            this.RadioEmployee.TabIndex = 40;
            this.RadioEmployee.TabStop = true;
            this.RadioEmployee.Text = "Employee";
            this.RadioEmployee.UseVisualStyleBackColor = true;
            // 
            // RadioAdmin
            // 
            this.RadioAdmin.AutoSize = true;
            this.RadioAdmin.Depth = 0;
            this.RadioAdmin.Font = new System.Drawing.Font("Roboto", 10F);
            this.RadioAdmin.Location = new System.Drawing.Point(230, 375);
            this.RadioAdmin.Margin = new System.Windows.Forms.Padding(0);
            this.RadioAdmin.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RadioAdmin.MouseState = MaterialSkin.MouseState.HOVER;
            this.RadioAdmin.Name = "RadioAdmin";
            this.RadioAdmin.Ripple = true;
            this.RadioAdmin.Size = new System.Drawing.Size(69, 30);
            this.RadioAdmin.TabIndex = 39;
            this.RadioAdmin.TabStop = true;
            this.RadioAdmin.Text = "Admin";
            this.RadioAdmin.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(114, 378);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "Employee Role: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddEmployeesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 570);
            this.ControlBox = false;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.RadioEmployee);
            this.Controls.Add(this.RadioAdmin);
            this.Controls.Add(this.txtEmployeePassword);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdateEmployee);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.txtEmpContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEmployeeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmpSalary);
            this.Controls.Add(this.txtEmpAddress);
            this.Controls.Add(this.txtEmpID);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblEmpAddress);
            this.Controls.Add(this.lblEmpId);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "AddEmployeesForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddEmployeesForm";
            this.Load += new System.EventHandler(this.AddEmployeesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmpId;
        private System.Windows.Forms.Label lblEmpAddress;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtEmpID;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtEmpAddress;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtEmpSalary;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtEmployeeName;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtEmpContact;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.Button btnUpdateEmployee;
        public MaterialSkin.Controls.MaterialSingleLineTextField txtEmployeePassword;
        private System.Windows.Forms.Label label5;
        private MaterialSkin.Controls.MaterialRadioButton RadioEmployee;
        private MaterialSkin.Controls.MaterialRadioButton RadioAdmin;
        private System.Windows.Forms.Label label4;
    }
}