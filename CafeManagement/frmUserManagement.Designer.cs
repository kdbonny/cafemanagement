namespace CafeManagement
{
    partial class frmUserManagement
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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.gvUsers = new System.Windows.Forms.DataGridView();
            this.btnItems = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUserEmail = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.DeepPink;
            this.btnLogOut.Location = new System.Drawing.Point(37, 448);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 35);
            this.btnLogOut.TabIndex = 23;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepPink;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(132, 264);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 35);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.DeepPink;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(243, 264);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 35);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(24, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(88, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 18);
            this.label5.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.DeepPink;
            this.label4.Location = new System.Drawing.Point(24, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Phone Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(23, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "User Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(633, 425);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Order Amount";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.DeepPink;
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(451, 422);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(143, 35);
            this.btnPlaceOrder.TabIndex = 9;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.Color.DeepPink;
            this.btnUser.Location = new System.Drawing.Point(37, 203);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(135, 35);
            this.btnUser.TabIndex = 25;
            this.btnUser.Text = "Users";
            this.btnUser.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepPink;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(23, 264);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(358, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "Manage User";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPhoneNumber.Location = new System.Drawing.Point(132, 173);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(198, 23);
            this.txtPhoneNumber.TabIndex = 3;
            // 
            // txtUserName
            // 
            this.txtUserName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserName.Location = new System.Drawing.Point(132, 104);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(198, 23);
            this.txtUserName.TabIndex = 2;
            // 
            // gvUsers
            // 
            this.gvUsers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.gvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvUsers.Location = new System.Drawing.Point(358, 87);
            this.gvUsers.Name = "gvUsers";
            this.gvUsers.RowTemplate.Height = 25;
            this.gvUsers.Size = new System.Drawing.Size(411, 212);
            this.gvUsers.TabIndex = 1;
            this.gvUsers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvUsers_CellContentClick);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.White;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItems.ForeColor = System.Drawing.Color.DeepPink;
            this.btnItems.Location = new System.Drawing.Point(37, 94);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(135, 36);
            this.btnItems.TabIndex = 24;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Location = new System.Drawing.Point(132, 207);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(198, 23);
            this.txtPassword.TabIndex = 7;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtUserEmail);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.gvUsers);
            this.panel1.Location = new System.Drawing.Point(220, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 471);
            this.panel1.TabIndex = 22;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(188, 53);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 19;
            this.txtId.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(23, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 18);
            this.label7.TabIndex = 18;
            this.label7.Text = "User Email";
            // 
            // txtUserEmail
            // 
            this.txtUserEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUserEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtUserEmail.Location = new System.Drawing.Point(132, 138);
            this.txtUserEmail.Name = "txtUserEmail";
            this.txtUserEmail.Size = new System.Drawing.Size(198, 23);
            this.txtUserEmail.TabIndex = 17;
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.DeepPink;
            this.btnOrder.Location = new System.Drawing.Point(37, 150);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 35);
            this.btnOrder.TabIndex = 26;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmUserManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1074, 494);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUserManagement";
            this.Text = "frmUserManagement";
            this.Load += new System.EventHandler(this.frmUserManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gvUsers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnLogOut;
        private Button btnEdit;
        private Button btnDelete;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label3;
        private Button btnPlaceOrder;
        private Button btnUser;
        private Button btnAdd;
        private Label label1;
        private TextBox txtPhoneNumber;
        private TextBox txtUserName;
        private DataGridView gvUsers;
        private Button btnItems;
        private TextBox txtPassword;
        private Panel panel1;
        private Label label7;
        private TextBox txtUserEmail;
        private TextBox txtId;
        private Button btnOrder;
    }
}