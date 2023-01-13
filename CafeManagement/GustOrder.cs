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
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.RegularExpressions;
using System.Collections;
using System.Drawing.Printing;


namespace CafeManagement
{
    public partial class frmGuestOrder : Form
    {
        public frmGuestOrder()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-42HL7FQ;Initial Catalog=cafedb;Integrated Security=True");

        double totalAmount = 0; 
        private void frmGuestOrder_Load(object sender, EventArgs e)
        {

            ActiveControl = txtSearchItem;

            newOrderNumber();
        }

        private void newOrderNumber() {

            Con.Open();
            string chkTblOrders = "select count(id) from tblOrders";
            SqlCommand chkOrders = new SqlCommand(chkTblOrders, Con);
            int rows = (int)chkOrders.ExecuteScalar();

            int totalRows = 0;

            if (rows > 0)
            {

                string query = "select max(id) as totalRows from tblOrders";
                SqlCommand cmd = new SqlCommand(query, Con);
                int maxId = (int)cmd.ExecuteScalar();
                totalRows = maxId + 1;

            }
            else
            {

                totalRows = 1;
            }

            Con.Close();

            txtOrderNumber.Text = totalRows.ToString();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frmLogin = new Form1();

            frmLogin.Show();
        }

        private void btnItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            ItemsManagement frmItem = new ItemsManagement();
            frmItem.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmUserManagement frmUser = new frmUserManagement();
            frmUser.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void txtOrderNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            
           
        }

        private void txtSearchItem_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Up && e.KeyCode != Keys.Down && e.KeyCode != Keys.Enter)
            {
                gvItemList.Visible = true;
                string getName = txtSearchItem.Text;

                Con.Open();
                string query = "select name, price from tblItems where name like '" + getName + "%' order by name offset 0 rows fetch first 6 rows only";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);

                var ds = new DataSet();
                sda.Fill(ds);

                gvItemList.DataSource = ds.Tables[0];

                Con.Close();
            }

        }

        private void gvItemList_KeyDown(object sender, KeyEventArgs e)
        {
            //when i press enter,bellow code never run?
            /*if (e.KeyCode.Equals(Keys.Down))
            {
                MessageBox.Show("You press Enter");
            }*/
        }


        private void txtSearchItem_KeyDown(object sender, KeyEventArgs e)
        {

            if (gvItemList.Visible == true)
            {
                if (e.KeyCode.Equals(Keys.Up))
                {
                    selectUpRow();
                }
                if (e.KeyCode.Equals(Keys.Down))
                {
                    selectDownRow();
                }
                if (e.KeyCode.Equals(Keys.Enter))
                {
                    selectCellValue();
                }
                e.Handled = true;
            }
        }

        private void selectUpRow()
        {
            DataGridView dgv = gvItemList;
            int totalRows = dgv.Rows.Count;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            if (rowIndex == 0)
                return;
            int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
            DataGridViewRow selectedRow = dgv.Rows[rowIndex];
            dgv.ClearSelection();
            dgv.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
        }

        private void selectDownRow()
        {
            DataGridView dgv = gvItemList;
            int totalRows = dgv.Rows.Count;
            int rowIndex = dgv.SelectedCells[0].OwningRow.Index;
            if (rowIndex == totalRows - 1)
                return;
            int colIndex = dgv.SelectedCells[0].OwningColumn.Index;
            DataGridViewRow selectedRow = dgv.Rows[rowIndex];
            dgv.ClearSelection();
            dgv.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
        }

        private void selectCellValue()
        {

            int selectedRowIndex = gvItemList.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = gvItemList.Rows[selectedRowIndex];
            string itemName = Convert.ToString(selectedRow.Cells[0].Value);
            string itemPrice = Convert.ToString(selectedRow.Cells[1].Value);

            txtSearchItem.Text = itemName;
            txtPrice.Text = itemPrice;

            txtQuantity.Focus();

            gvItemList.Visible = false;

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {

        }

        private void txtCustomerName_Enter(object sender, EventArgs e)
        {
            txtCustomerName.BackColor = Color.White;
            txtCustomerName.Text = "";
        }

        private void txtCustomerPhone_Enter(object sender, EventArgs e)
        {
            txtCustomerPhone.BackColor = Color.White;
            txtCustomerPhone.Text = "";
        }

        private void txtCustomerAddress_Enter(object sender, EventArgs e)
        {
            txtCustomerAddress.BackColor = Color.White;
            txtCustomerAddress.Text = "";
        }

        private void txtQuantity_KeyDown(object sender, KeyEventArgs e)
        {
            string chkPrice = txtPrice.Text;

            if (!(Double.TryParse(chkPrice, out Double Prc))) {

                MessageBox.Show("Please Enter a Valid Price!");

                return;
            
            }

            
            if (e.KeyCode.Equals(Keys.Enter))
            {

                string getName = txtSearchItem.Text;
                double getPrice = Convert.ToDouble(txtPrice.Text);
                double getQuantity = Convert.ToDouble(txtQuantity.Text);
                double getTax = Convert.ToDouble(txtTax.Text);


                int n = gvOrder.Rows.Add();
                int sl = n + 1;

                var amount = Math.Round((getPrice * getQuantity), 2);
                totalAmount = totalAmount + amount;
                if (getTax > 0)
                {
                    double taxAmount = ((totalAmount * getTax) / 100);
                    double totalAmountWithTax = (totalAmount + taxAmount);
                    txtTotal.Text = totalAmountWithTax.ToString();
                }
                else {

                    txtTotal.Text = totalAmount.ToString();
                }


                gvOrder.Rows[n].Cells[0].Value = sl;
                gvOrder.Rows[n].Cells[1].Value = getName;
                gvOrder.Rows[n].Cells[2].Value = amount;
                gvOrder.Rows[n].Cells[3].Value = getQuantity;

                txtPrice.Text = "";
                txtSearchItem.Text = "";
                txtQuantity.Text = "1";
                txtSearchItem.Focus();
                txtAmount.Text = Convert.ToString(totalAmount);
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            string chkQuantity = txtQuantity.Text;

            if (!(Double.TryParse(chkQuantity, out Double Qnt)))
            {

                MessageBox.Show("Please Enter a Valid Quantity!");

                return;

            }
        }

        private void gvOrder_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gvOrder.Columns[e.ColumnIndex].Name == "Delete") {

                if (MessageBox.Show("Are yoy sure to delete?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes) {

                    foreach (DataGridViewCell oneCell in gvOrder.SelectedCells)
                    {
                        int selectedrowindex = gvOrder.SelectedCells[0].RowIndex;
                        DataGridViewRow selectedRow = gvOrder.Rows[selectedrowindex];
                        double cellValue = Convert.ToDouble(selectedRow.Cells[2].Value);
                        
                        totalAmount = (totalAmount - cellValue);

                        txtTotal.Text = totalAmount.ToString();

                        txtAmount.Text = Convert.ToString(totalAmount);

                        if (oneCell.Selected)
                            
                            gvOrder.Rows.RemoveAt(oneCell.RowIndex);


                    }
                }
            }
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {

            string chkDiscount = txtDiscount.Text;
            string chkTax = txtTax.Text;
            Double.TryParse(chkTax, out Double getTax);

            if (!(Double.TryParse(chkDiscount, out Double Dis))) {

                return;
            }

            if(chkDiscount != "" )
            {
                Double Discount = Convert.ToDouble(txtDiscount.Text);

                    Double total = (totalAmount - Discount);

                    if (getTax > 0)
                    {
                        Double taxAmount = ((totalAmount * getTax) / 100);
                        total = (total + taxAmount);
                    }

                    txtTotal.Text = total.ToString();
                
            }
        }

        private void txtDiscount_Leave(object sender, EventArgs e)
        {
            string chkDiscount = txtDiscount.Text;

            if (chkDiscount == "" || !(Double.TryParse(chkDiscount, out Double Dis)))
            {

                txtDiscount.Text = String.Format("{0:0}", 0);
            }
        }

        private void txtTax_TextChanged(object sender, EventArgs e)
        {
            string chkTax = txtTax.Text;
            string Discount = txtDiscount.Text;
            Double.TryParse(Discount, out Double getDiscount);

            if (!(Double.TryParse(chkTax, out Double Tx))) {

                return;
            } 

            if (chkTax != "")
            {
                double getTax = Convert.ToDouble(txtTax.Text);
                var taxedAmount = (totalAmount + ((totalAmount * getTax)/100));

                if (getDiscount > 0) {
                    taxedAmount = (taxedAmount - getDiscount);
                }

                txtTotal.Text = taxedAmount.ToString();
            }
        }

        private void txtTax_Leave(object sender, EventArgs e)
        {
            string chkTax = txtTax.Text;

            if (chkTax == "" || !(Double.TryParse(chkTax, out Double Tx)))
            {

                txtTax.Text = String.Format("{0:0}", 0);
            }
        }

        private void txtReceived_TextChanged(object sender, EventArgs e)
        {
            string chkReceived = txtReceived.Text;

            if (!(Double.TryParse(chkReceived, out Double Rec)))
            {

                return;
            }

            if (chkReceived != "")
            {
                double getReceived = Convert.ToDouble(txtReceived.Text);
                double getTotal = Convert.ToDouble(txtTotal.Text);
                var changedAmount = (getReceived - getTotal);
                txtChange.Text = changedAmount.ToString();
            }

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

            int chkOrderList = gvOrder.RowCount;

            if(chkOrderList == 0) {

                MessageBox.Show("Please Take Item to Order List.");
                return;
            }

            if (txtReceived.Text == "") {

                MessageBox.Show("Please Receive Payment.");
                return; 
            }

            var getOrderNumber = txtOrderNumber.Text;
            var getCustomerName = txtCustomerName.Text;
            var getCustomerPhone = txtCustomerPhone.Text;
            int getCustomerId = 0;
            var getCustomerAddress = txtCustomerAddress.Text;
            Double getAmount = Convert.ToDouble(txtAmount.Text);
            if (Double.TryParse(txtDiscount.Text, out Double getDiscount));
            if (Double.TryParse(txtTax.Text, out Double getTax));
            if (Double.TryParse(txtTotal.Text, out Double getTotalAmount));
            if (Double.TryParse(txtReceived.Text, out Double getReceived));
            if (Double.TryParse(txtChange.Text, out Double getChange));
            var getDate = orderDate.Text;
            Double taxAmount = ((totalAmount * getTax)/100);
            Double getDue = (getTotalAmount - getReceived);

            btnPlaceOrder.Enabled= false;

            Con.Open();

            ////////// Customer Part //////////

            if (getCustomerPhone != "Customer Phone" && getCustomerPhone != "")
            {
                
                string chkCustomerQuery = "SELECT phone FROM tblCustomers WHERE ([phone] = @phone)";
                SqlCommand chkCustomer = new SqlCommand(chkCustomerQuery, Con);
                chkCustomer.Parameters.AddWithValue("@phone", getCustomerPhone);
                string isCustomer = (string)chkCustomer.ExecuteScalar();


                if (isCustomer != null)
                {
                    
                    string getCustomerQuery = "select * from tblCustomers where phone =" + getCustomerPhone;
                    SqlCommand getCustomer = new SqlCommand(getCustomerQuery, Con);

                    using (SqlDataReader read = getCustomer.ExecuteReader())
                    {

                        while (read.Read())
                        {
                            getCustomerId = Convert.ToInt32(read["id"]);

                        }
                    }
                }
                else
                {

                    string createCustomerQuery = "insert into tblCustomers " +
                        "(name, phone, address) " +
                        "values('" + getCustomerName + "', '" + getCustomerPhone + "', '" + getCustomerAddress + "')";
                    SqlCommand createCustomer = new SqlCommand(createCustomerQuery, Con);
                    createCustomer.ExecuteNonQuery();

                    string getCustomoerIdQuery = "select max(id) from tblCustomers";
                    SqlCommand getMaxCustomerId = new SqlCommand(getCustomoerIdQuery, Con);
                    getCustomerId = (int)getMaxCustomerId.ExecuteScalar();
                    
                }

            }


            //////// End Customer Part ////////
          
            //////// Insert into tblOrders and tblOrderDetails ///////////

            
            string insertIntoOrders = "insert into tblOrders " +
                "(order_id, customer_id, amount, discount, tax, " +
                "total_amount, received, change, due, date) " +
                "values('"+getOrderNumber+"', '"+getCustomerId+"', '"+getAmount+"', " +
                "'"+getDiscount+"', '"+ taxAmount + "', '"+getTotalAmount+"', '"+getReceived+"'," +
                "'"+getChange+"', '"+getDue+"', '"+getDate+"')";

            SqlCommand intoOrders= new SqlCommand(insertIntoOrders, Con);
            intoOrders.ExecuteNonQuery();

            for (int i = 0; i < gvOrder.Rows.Count; i++) {

                DataGridViewRow selectedRow = gvOrder.Rows[i];
                string itemName = Convert.ToString(selectedRow.Cells[1].Value);
                double itemPrice = Convert.ToDouble(selectedRow.Cells[2].Value);
                double itemQuantity = Convert.ToDouble(selectedRow.Cells[3].Value);

                string insertIntoOrderDetails = "insert into tblOrderDetails " +
                    "(order_id, product_name, price, quantity) " +
                    "values('" + getOrderNumber + "', '" + itemName + "', '" + itemPrice + "', " +
                    "'" + itemQuantity + "')";
                SqlCommand intoOrderDetails = new SqlCommand(insertIntoOrderDetails, Con);
                intoOrderDetails.ExecuteNonQuery();

            }

            btnPlaceOrder.Enabled = true;
            
            Con.Close();
            

            //////////////////End Insert to Orders & Order_details Table ////////////

            printReceipt();

            reset();
        }

        private void printReceipt() {
            
            pnlPrintPos.Visible = true;
            dgvPosList.Rows.Clear();
            //then you can copy the rows values one by one (working on the selectedrows collection)
            int iterate = gvOrder.Rows.Count;

            for (int i = 0; i < iterate; i++)
            {
             
                string item = gvOrder.Rows[i].Cells[1].Value.ToString();
                string price = gvOrder.Rows[i].Cells[2].Value.ToString();
                int quantity = Convert.ToInt32(gvOrder.Rows[i].Cells[3].Value);

                dgvPosList.Rows.Add(quantity, item, price);

            }

            print(pnlPrintPos);

        }

        private void print(Panel pnl)
        {

            PrinterSettings ps = new PrinterSettings();
            pnlPrintPos = pnl;
            getprintarea(pnlPrintPos);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }

        private Bitmap memoryimage;

        private void getprintarea(Panel pnl)
        {

            memoryimage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            //e.Graphics.DrawImage(memoryimage, (pagearea.Width / 2) - (this.panel1.Width / 2), this.panel1.Location.Y);
            e.Graphics.DrawImage(memoryimage, pagearea);
        }

        private void reset() {

            gvOrder.Rows.Clear();
            txtSearchItem.Text = "";
            txtPrice.Text = "";
            txtQuantity.Text = "1";
            txtTotal.Text = "";
            txtAmount.Text = "";
            txtReceived.Text = "";
            txtDiscount.Text = "";
            txtTax.Text = "";
            txtChange.Text = "";
            totalAmount = 0;
            txtCustomerName.Text = "Customer Name";
            txtCustomerPhone.Text = "Customer Phone";
            txtCustomerAddress.Text = "Customer Address";
            dgvPosList.Visible = false;
            txtSearchItem.Focus();
            newOrderNumber();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuestOrder frmOrder = new frmGuestOrder();
            frmOrder.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
