using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class rptSales : Form
    {
        public rptSales()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection("Data Source=DESKTOP-42HL7FQ;Initial Catalog=cafedb;Integrated Security=True");


        private void btnShow_Click(object sender, EventArgs e)
        {

            string getFromDate = (dateFrom.Value).ToString("MM/dd/yyyy");
            
            string getToDate = (dateFrom.Value).ToString("MM/dd/yyyy"); ;
            


            Con.Open();
            
            string reportQuery = "select o.order_id, c.name, c.phone, c.address, " +
                "o.total_amount, o.discount, o.tax, o.received," +
                " o.due, format(o.date, 'dd-MM-yyyy') as date from tblOrders o left join tblCustomers c on o.customer_id = c.id " +
                "where o.date between '"+ getFromDate + "' and '"+ getToDate + "'";
            
            SqlDataAdapter sda = new SqlDataAdapter(reportQuery, Con);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            dgvSalesReport.DataSource = dtbl;
            
            Con.Close();
        }
    }
}
