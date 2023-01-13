namespace CafeManagement
{
    partial class rptSales
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
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnShow = new System.Windows.Forms.Button();
            this.dgvSalesReport = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dateFrom
            // 
            this.dateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateFrom.Location = new System.Drawing.Point(449, 12);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(100, 23);
            this.dateFrom.TabIndex = 0;
            // 
            // dateTo
            // 
            this.dateTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTo.Location = new System.Drawing.Point(726, 12);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(100, 23);
            this.dateTo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(349, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "From Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(647, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "To Date";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(885, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // dgvSalesReport
            // 
            this.dgvSalesReport.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesReport.Location = new System.Drawing.Point(12, 57);
            this.dgvSalesReport.Name = "dgvSalesReport";
            this.dgvSalesReport.RowTemplate.Height = 25;
            this.dgvSalesReport.Size = new System.Drawing.Size(1040, 478);
            this.dgvSalesReport.TabIndex = 5;
            // 
            // rptSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 561);
            this.Controls.Add(this.dgvSalesReport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Name = "rptSales";
            this.Text = "Sales Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker dateFrom;
        private DateTimePicker dateTo;
        private Label label1;
        private Label label2;
        private Button btnShow;
        private DataGridView dgvSalesReport;
    }
}