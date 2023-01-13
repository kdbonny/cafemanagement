
using System.Data.SqlClient;

namespace CafeManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-42HL7FQ;Initial Catalog=cafedb;Integrated Security=True");
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmGuestOrder guestOrder = new frmGuestOrder();

            guestOrder.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string getUserEmail = txtUserEmail.Text;
            string getPassword = txtPassword.Text;
            string userEmail = "";
            string userPassword = "";

            if (getUserEmail == "" || getPassword == "") {

                MessageBox.Show("Please provide User Email and Password.");
                return;
            }

            Con.Open();
            string query = "select * from tblUsers where email = '"+getUserEmail+"' and password = '"+getPassword+"'";
            SqlCommand cmd = new SqlCommand(query, Con);

            using (SqlDataReader read = cmd.ExecuteReader())
            {

                while (read.Read())
                {

                    userEmail = Convert.ToString(read["email"]);
                    userPassword = Convert.ToString(read["password"]);

                }
            }
            
            Con.Close();

            if (userEmail == getUserEmail && userPassword == getPassword)
            {

                frmGuestOrder frmGuest = new frmGuestOrder();

                frmGuest.Show();
                this.Hide();
            }
            else {

                MessageBox.Show("Sorry! User name or password is wrong. Try again.");
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

    }
}