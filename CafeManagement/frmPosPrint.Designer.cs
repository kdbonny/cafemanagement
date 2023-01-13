namespace CafeManagement
{
    partial class frmPosPrint
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.qnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dgvItemList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(331, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 384);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cafe La Jawab";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1, 37);
            this.label2.MaximumSize = new System.Drawing.Size(200, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "Drek Street, Town Center, Rochdale, OL1 3WY, Ph: 07443148814";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dgvItemList
            // 
            this.dgvItemList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.qnt,
            this.item,
            this.price});
            this.dgvItemList.Location = new System.Drawing.Point(1, 79);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.RowHeadersVisible = false;
            this.dgvItemList.RowTemplate.Height = 25;
            this.dgvItemList.Size = new System.Drawing.Size(199, 227);
            this.dgvItemList.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(0, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(204, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Thank you for your shopping with us.";
            // 
            // frmPosPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "frmPosPrint";
            this.Text = "frmPosPrint";
            this.Load += new System.EventHandler(this.frmPosPrint_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private DataGridView dgvItemList;
        private DataGridViewTextBoxColumn qnt;
        private DataGridViewTextBoxColumn item;
        private DataGridViewTextBoxColumn price;
    }
}