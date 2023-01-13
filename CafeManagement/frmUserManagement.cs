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

namespace CafeManagement
{
    public partial class frmUserManagement : Form
    {
        public frmUserManagement()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-42HL7FQ;Initial Catalog=cafedb;Integrated Security=True");

        void Populate() 
        {
            Con.Open();

            string query = "select id, name, email, phone from tblUsers";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gvUsers.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frmLogin = new Form1();
            frmLogin.Show();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            Con.Open();
            string query = "insert into tblUsers " + 
                "(name, email, phone, password) "+
                "values('"+ txtUserName.Text +"', '"+ txtUserEmail.Text +"', '" + txtPhoneNumber.Text + "', '"+ txtPassword.Text +"')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("User Successfully Created.");
            Con.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmUserManagement_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void gvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvUsers.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtUserName.Text = gvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtUserEmail.Text = gvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPhoneNumber.Text = gvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please select a user");
            }
            else {

                string getId = txtId.Text;
                Con.Open();
                string query = "delete from tblUsers where id = "+ getId;
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User has been deleted.");
                Con.Close();
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please Select a User.");
            }
            else {

                string getId = txtId.Text;
                string getName = txtUserName.Text;
                string getEmail = txtUserEmail.Text;
                string getPhone = txtPhoneNumber.Text;
                string getPassword = txtPassword.Text;

                Con.Open();
                string query = "Update tblUsers set name = '" +getName+ "', email = '" +getEmail+ "', phone = '"+ getPhone +"' where id = "+getId;
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                
                if (getPassword != "") {

                    string query2 = "Update tblUsers set password = '" + getPassword + "' where id = " + getId;
                    SqlCommand cmd2 = new SqlCommand(query2, Con);
                    cmd2.ExecuteNonQuery();

                }

                MessageBox.Show("User Updated Successfully");
               
                Con.Close();

                Populate();

            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            frmGuestOrder frmOrder = new frmGuestOrder();
            this.Hide();
            frmOrder.ShowDialog();
        }
    }
}
