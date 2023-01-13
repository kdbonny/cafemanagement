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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-42HL7FQ;Initial Catalog=cafedb;Integrated Security=True");

        void Populate() {

            Con.Open();

            string query = "select * from tblCategories";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            gvCategory.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {
            Populate();
        }

        private void gvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = gvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtDescription.Text = gvCategory.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string getName = txtName.Text;
            string getDescription = txtDescription.Text;
            
            Con.Open();
            string query = "insert into tblCategories (name, description) " +
                "values('"+ getName +"', '" + getDescription + "')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Category created Successfully!!");
            Con.Close();

            Populate();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string getId = txtId.Text;
            string getName = txtName.Text;
            string getDescription = txtDescription.Text;

            Con.Open();
            string query = "update tblCategories set name = '"+ getName +"', description = '" +getDescription+ "' where id =" + getId;
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            Populate();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string getId = txtId.Text;

            Con.Open();
            string query = "Delete from tblCategories where id =" + getId;
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            Populate();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
