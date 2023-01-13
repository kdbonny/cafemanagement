namespace CafeManagement
{
    partial class ItemsManagement
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItemPrice = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.gvItems = new System.Windows.Forms.DataGridView();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.chkActive);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.btnAddCategory);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtItemPrice);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.gvItems);
            this.panel1.Controls.Add(this.cmbCategory);
            this.panel1.Location = new System.Drawing.Point(220, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 389);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(19, 38);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 23);
            this.txtId.TabIndex = 22;
            this.txtId.Visible = false;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Checked = true;
            this.chkActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkActive.Location = new System.Drawing.Point(156, 268);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(43, 19);
            this.chkActive.TabIndex = 21;
            this.chkActive.Text = "Yes";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(48, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 18);
            this.label7.TabIndex = 20;
            this.label7.Text = "Is Active?";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(48, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 18);
            this.label3.TabIndex = 19;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(156, 136);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(174, 77);
            this.txtDescription.TabIndex = 18;
            this.txtDescription.Text = "";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.BackColor = System.Drawing.Color.DeepPink;
            this.btnAddCategory.Font = new System.Drawing.Font("Baskerville Old Face", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddCategory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCategory.Location = new System.Drawing.Point(134, 38);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(37, 30);
            this.btnAddCategory.TabIndex = 17;
            this.btnAddCategory.Text = "+";
            this.btnAddCategory.UseVisualStyleBackColor = false;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.DeepPink;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(134, 320);
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
            this.btnDelete.Location = new System.Drawing.Point(245, 320);
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
            this.label6.Location = new System.Drawing.Point(48, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Item Price";
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
            this.label4.Location = new System.Drawing.Point(41, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 18);
            this.label4.TabIndex = 12;
            this.label4.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(41, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Description";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DeepPink;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(25, 320);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItemPrice
            // 
            this.txtItemPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtItemPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemPrice.Location = new System.Drawing.Point(156, 228);
            this.txtItemPrice.Name = "txtItemPrice";
            this.txtItemPrice.Size = new System.Drawing.Size(174, 23);
            this.txtItemPrice.TabIndex = 7;
            // 
            // txtItemName
            // 
            this.txtItemName.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtItemName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtItemName.Location = new System.Drawing.Point(156, 96);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(174, 23);
            this.txtItemName.TabIndex = 3;
            // 
            // gvItems
            // 
            this.gvItems.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItems.Location = new System.Drawing.Point(358, 36);
            this.gvItems.Name = "gvItems";
            this.gvItems.RowTemplate.Height = 25;
            this.gvItems.Size = new System.Drawing.Size(431, 263);
            this.gvItems.TabIndex = 1;
            this.gvItems.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvItems_CellContentClick);
            // 
            // cmbCategory
            // 
            this.cmbCategory.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(189, 36);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(143, 32);
            this.cmbCategory.TabIndex = 0;
            this.cmbCategory.Text = "Category";
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.Color.DeepPink;
            this.btnUser.Location = new System.Drawing.Point(37, 291);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(135, 35);
            this.btnUser.TabIndex = 21;
            this.btnUser.Text = "Users";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.White;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItems.ForeColor = System.Drawing.Color.DeepPink;
            this.btnItems.Location = new System.Drawing.Point(37, 185);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(135, 36);
            this.btnItems.TabIndex = 20;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.DeepPink;
            this.btnLogOut.Location = new System.Drawing.Point(37, 539);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 35);
            this.btnLogOut.TabIndex = 19;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(482, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Item Management";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DeepPink;
            this.label8.Location = new System.Drawing.Point(1013, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 24);
            this.label8.TabIndex = 22;
            this.label8.Text = "X";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.DeepPink;
            this.btnOrder.Location = new System.Drawing.Point(37, 240);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 35);
            this.btnOrder.TabIndex = 23;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // ItemsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1090, 700);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnLogOut);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ItemsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ItemsManagement";
            this.Load += new System.EventHandler(this.ItemsManagement_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Button btnAdd;
        private TextBox txtItemPrice;
        private TextBox txtItemName;
        private DataGridView gvItems;
        private ComboBox cmbCategory;
        private Button btnUser;
        private Button btnItems;
        private Button btnLogOut;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnAddCategory;
        private Label label1;
        private Label label3;
        private RichTextBox txtDescription;
        private CheckBox chkActive;
        private Label label7;
        private Label label8;
        private TextBox txtId;
        private Button btnOrder;
    }
}