namespace CafeManagement
{
    partial class frmGuestOrder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGuestOrder));
            this.panel1 = new System.Windows.Forms.Panel();
            this.orderDate = new System.Windows.Forms.DateTimePicker();
            this.pnlPrintPos = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvPosList = new System.Windows.Forms.DataGridView();
            this.qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtChange = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReceived = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.RichTextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.gvItemList = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.gvOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtSearchItem = new System.Windows.Forms.TextBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnItems = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label12 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.pnlPrintPos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.orderDate);
            this.panel1.Controls.Add(this.pnlPrintPos);
            this.panel1.Controls.Add(this.txtOrderNumber);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtChange);
            this.panel1.Controls.Add(this.txtPrice);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtReceived);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtTax);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtDiscount);
            this.panel1.Controls.Add(this.txtAmount);
            this.panel1.Controls.Add(this.txtCustomerAddress);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.txtQuantity);
            this.panel1.Controls.Add(this.gvItemList);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnPlaceOrder);
            this.panel1.Controls.Add(this.gvOrder);
            this.panel1.Controls.Add(this.txtCustomerPhone);
            this.panel1.Controls.Add(this.txtSearchItem);
            this.panel1.Location = new System.Drawing.Point(228, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(818, 486);
            this.panel1.TabIndex = 0;
            // 
            // orderDate
            // 
            this.orderDate.Location = new System.Drawing.Point(32, 49);
            this.orderDate.Name = "orderDate";
            this.orderDate.Size = new System.Drawing.Size(143, 23);
            this.orderDate.TabIndex = 29;
            // 
            // pnlPrintPos
            // 
            this.pnlPrintPos.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pnlPrintPos.Controls.Add(this.label9);
            this.pnlPrintPos.Controls.Add(this.dgvPosList);
            this.pnlPrintPos.Controls.Add(this.label10);
            this.pnlPrintPos.Controls.Add(this.label11);
            this.pnlPrintPos.Location = new System.Drawing.Point(32, 369);
            this.pnlPrintPos.Name = "pnlPrintPos";
            this.pnlPrintPos.Size = new System.Drawing.Size(200, 384);
            this.pnlPrintPos.TabIndex = 19;
            this.pnlPrintPos.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(0, 357);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(204, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Thank you for your shopping with us.";
            // 
            // dgvPosList
            // 
            this.dgvPosList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvPosList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPosList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qnt,
            this.item,
            this.price});
            this.dgvPosList.Location = new System.Drawing.Point(1, 79);
            this.dgvPosList.Name = "dgvPosList";
            this.dgvPosList.RowHeadersVisible = false;
            this.dgvPosList.RowTemplate.Height = 25;
            this.dgvPosList.Size = new System.Drawing.Size(199, 227);
            this.dgvPosList.TabIndex = 2;
            // 
            // qnt
            // 
            this.qnt.HeaderText = "Qnt";
            this.qnt.Name = "qnt";
            this.qnt.Width = 30;
            // 
            // item
            // 
            this.item.HeaderText = "Item";
            this.item.Name = "item";
            this.item.Width = 120;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.Width = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(3, 36);
            this.label10.MaximumSize = new System.Drawing.Size(200, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(194, 30);
            this.label10.TabIndex = 1;
            this.label10.Text = "Drek Street, Town Center, Rochdale, OL1 3WY, Ph: 07443148814";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(36, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 25);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cafe La Jawab";
            // 
            // txtOrderNumber
            // 
            this.txtOrderNumber.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtOrderNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtOrderNumber.Location = new System.Drawing.Point(32, 83);
            this.txtOrderNumber.Name = "txtOrderNumber";
            this.txtOrderNumber.Size = new System.Drawing.Size(143, 23);
            this.txtOrderNumber.TabIndex = 28;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.DeepPink;
            this.label8.Location = new System.Drawing.Point(534, 428);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Change";
            // 
            // txtChange
            // 
            this.txtChange.BackColor = System.Drawing.Color.DarkOrange;
            this.txtChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtChange.Location = new System.Drawing.Point(605, 427);
            this.txtChange.Name = "txtChange";
            this.txtChange.Size = new System.Drawing.Size(164, 23);
            this.txtChange.TabIndex = 26;
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrice.Location = new System.Drawing.Point(500, 47);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(97, 23);
            this.txtPrice.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.DeepPink;
            this.label7.Location = new System.Drawing.Point(533, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 24;
            this.label7.Text = "Received";
            // 
            // txtReceived
            // 
            this.txtReceived.BackColor = System.Drawing.Color.Chartreuse;
            this.txtReceived.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReceived.Location = new System.Drawing.Point(604, 398);
            this.txtReceived.Name = "txtReceived";
            this.txtReceived.Size = new System.Drawing.Size(164, 23);
            this.txtReceived.TabIndex = 7;
            this.txtReceived.TextChanged += new System.EventHandler(this.txtReceived_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.DeepPink;
            this.label6.Location = new System.Drawing.Point(533, 370);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 18);
            this.label6.TabIndex = 22;
            this.label6.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Location = new System.Drawing.Point(604, 369);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(165, 23);
            this.txtTotal.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.DeepPink;
            this.label5.Location = new System.Drawing.Point(533, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 20;
            this.label5.Text = "Vat/ Tax";
            // 
            // txtTax
            // 
            this.txtTax.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTax.Location = new System.Drawing.Point(604, 339);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(165, 23);
            this.txtTax.TabIndex = 19;
            this.txtTax.Text = "4";
            this.txtTax.TextChanged += new System.EventHandler(this.txtTax_TextChanged);
            this.txtTax.Leave += new System.EventHandler(this.txtTax_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DeepPink;
            this.label2.Location = new System.Drawing.Point(533, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(604, 307);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(165, 23);
            this.txtDiscount.TabIndex = 18;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.Leave += new System.EventHandler(this.txtDiscount_Leave);
            // 
            // txtAmount
            // 
            this.txtAmount.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Location = new System.Drawing.Point(604, 276);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(165, 23);
            this.txtAmount.TabIndex = 16;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerAddress.Location = new System.Drawing.Point(32, 192);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(143, 98);
            this.txtCustomerAddress.TabIndex = 3;
            this.txtCustomerAddress.Text = "Customer Address";
            this.txtCustomerAddress.Enter += new System.EventHandler(this.txtCustomerAddress_Enter);
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerName.Location = new System.Drawing.Point(32, 118);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(143, 23);
            this.txtCustomerName.TabIndex = 1;
            this.txtCustomerName.Text = "Customer Name";
            this.txtCustomerName.Enter += new System.EventHandler(this.txtCustomerName_Enter);
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtQuantity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQuantity.Location = new System.Drawing.Point(672, 47);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(97, 23);
            this.txtQuantity.TabIndex = 6;
            this.txtQuantity.Text = "1";
            this.txtQuantity.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQuantity_KeyDown);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // gvItemList
            // 
            this.gvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvItemList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gvItemList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvItemList.ColumnHeadersVisible = false;
            this.gvItemList.Location = new System.Drawing.Point(223, 72);
            this.gvItemList.Name = "gvItemList";
            this.gvItemList.RowHeadersVisible = false;
            this.gvItemList.RowTemplate.Height = 25;
            this.gvItemList.Size = new System.Drawing.Size(276, 105);
            this.gvItemList.TabIndex = 11;
            this.gvItemList.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DeepPink;
            this.label3.Location = new System.Drawing.Point(538, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Amount";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.DeepPink;
            this.btnPlaceOrder.ForeColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Location = new System.Drawing.Point(223, 278);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(194, 35);
            this.btnPlaceOrder.TabIndex = 8;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // gvOrder
            // 
            this.gvOrder.AllowUserToAddRows = false;
            this.gvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Delete});
            this.gvOrder.Location = new System.Drawing.Point(223, 76);
            this.gvOrder.Name = "gvOrder";
            this.gvOrder.RowHeadersVisible = false;
            this.gvOrder.RowTemplate.Height = 25;
            this.gvOrder.Size = new System.Drawing.Size(546, 178);
            this.gvOrder.TabIndex = 5;
            this.gvOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gvOrder_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Sl";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Price";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Quantity";
            this.Column4.Name = "Column4";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.Text = "X";
            this.Delete.UseColumnTextForButtonValue = true;
            this.Delete.Width = 50;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.BackColor = System.Drawing.SystemColors.Control;
            this.txtCustomerPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCustomerPhone.Location = new System.Drawing.Point(32, 156);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(143, 23);
            this.txtCustomerPhone.TabIndex = 2;
            this.txtCustomerPhone.Text = "Customer Phone";
            this.txtCustomerPhone.Enter += new System.EventHandler(this.txtCustomerPhone_Enter);
            // 
            // txtSearchItem
            // 
            this.txtSearchItem.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSearchItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearchItem.Location = new System.Drawing.Point(223, 47);
            this.txtSearchItem.Name = "txtSearchItem";
            this.txtSearchItem.Size = new System.Drawing.Size(194, 23);
            this.txtSearchItem.TabIndex = 4;
            this.txtSearchItem.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchItem_KeyDown);
            this.txtSearchItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOrderNumber_KeyPress);
            this.txtSearchItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchItem_KeyUp);
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.White;
            this.btnUser.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnUser.ForeColor = System.Drawing.Color.DeepPink;
            this.btnUser.Location = new System.Drawing.Point(45, 364);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(135, 35);
            this.btnUser.TabIndex = 17;
            this.btnUser.Text = "Users";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnItems
            // 
            this.btnItems.BackColor = System.Drawing.Color.White;
            this.btnItems.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnItems.ForeColor = System.Drawing.Color.DeepPink;
            this.btnItems.Location = new System.Drawing.Point(45, 246);
            this.btnItems.Name = "btnItems";
            this.btnItems.Size = new System.Drawing.Size(135, 36);
            this.btnItems.TabIndex = 1;
            this.btnItems.Text = "Items";
            this.btnItems.UseVisualStyleBackColor = false;
            this.btnItems.Click += new System.EventHandler(this.btnItems_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.White;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.ForeColor = System.Drawing.Color.DeepPink;
            this.btnLogOut.Location = new System.Drawing.Point(45, 600);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(135, 35);
            this.btnLogOut.TabIndex = 15;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Baskerville Old Face", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(499, 44);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 34);
            this.label12.TabIndex = 20;
            this.label12.Text = "Place Order";
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.Color.White;
            this.btnOrder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOrder.ForeColor = System.Drawing.Color.DeepPink;
            this.btnOrder.Location = new System.Drawing.Point(45, 305);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(135, 35);
            this.btnOrder.TabIndex = 21;
            this.btnOrder.Text = "Place Order";
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DeepPink;
            this.label1.Location = new System.Drawing.Point(1023, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 24);
            this.label1.TabIndex = 23;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmGuestOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(1090, 700);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnItems);
            this.Controls.Add(this.btnLogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmGuestOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guest Order";
            this.Load += new System.EventHandler(this.frmGuestOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPrintPos.ResumeLayout(false);
            this.pnlPrintPos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPosList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItemList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel1;
        private Label label3;
        private Button btnPlaceOrder;
        private DataGridView gvOrder;
        private TextBox txtCustomerPhone;
        private TextBox txtSearchItem;
        private Button btnUser;
        private Button btnItems;
        private Button btnLogOut;
        private DataGridView gvItemList;
        private TextBox txtCustomerName;
        private TextBox txtQuantity;
        private Label label2;
        private TextBox txtDiscount;
        private TextBox txtAmount;
        private TextBox txtTax;
        private Label label7;
        private TextBox txtReceived;
        private Label label6;
        private TextBox txtTotal;
        private Label label5;
        private RichTextBox txtCustomerAddress;
        private TextBox txtPrice;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewButtonColumn Delete;
        private Label label8;
        private TextBox txtChange;
        private TextBox txtOrderNumber;
        private DateTimePicker orderDate;
        private Panel pnlPrintPos;
        private Label label9;
        private DataGridView dgvPosList;
        private DataGridViewTextBoxColumn qnt;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn price;
        private Label label10;
        private Label label11;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private Label label12;
        private Button btnOrder;
        private Label label1;
    }
}