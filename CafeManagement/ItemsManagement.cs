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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CafeManagement
{
    public partial class ItemsManagement : Form
    {
        public ItemsManagement()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-42HL7FQ;Initial Catalog=cafedb;Integrated Security=True");

        void Populate() {

            Con.Open();
            string query = "select * from tblItems";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);

            var ds = new DataSet();
            sda.Fill(ds);
            gvItems.DataSource = ds.Tables[0];

            Con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();

            Form1 frmLogin = new Form1();

            frmLogin.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {

        }

        private void ItemsManagement_Load(object sender, EventArgs e)
        {

            Con.Open();

            string query = "select * from tblCategories";
            SqlCommand cmd = new SqlCommand(query, Con);

            Dictionary<int, string> ComboSource = new Dictionary<int, string>();

            using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {

                    int id = Convert.ToInt32(read["id"]);

                    if (read["name"] != null) {

                        ComboSource.Add(id, read["name"].ToString());
                    }
                    
       
                    }
                }

            cmbCategory.DataSource = new BindingSource(ComboSource, null);
            cmbCategory.DisplayMember = "Value";
            cmbCategory.ValueMember = "Key";

            Con.Close();

            Populate();

            gvItems.Columns["id"].Visible = false;
            gvItems.Columns["category_id"].Visible = false;
            
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            frmCategory category = new frmCategory();

            category.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {

            txtId.Text = cmbCategory.GetItemText(cmbCategory.SelectedValue);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int getCatId = Convert.ToInt32(cmbCategory.SelectedValue);
            string getName = txtItemName.Text;
            string getDescription = txtDescription.Text;
            string getPrice = txtItemPrice.Text;
            int is_active = Convert.ToInt32(chkActive.Checked);

            Con.Open();

            string query = "insert tblItems " +
                "(category_id, name, description, price, is_active) " +
                "values('"+getCatId+"', '" + getName+"', '"+getDescription+"', '"+getPrice+"', '"+is_active+"')";
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Item Added Successfully");
            Con.Close();

            Populate();

            txtId.Text = "";
            txtItemName.Text = "";
            txtDescription.Text = "";
            txtItemPrice.Text = "";
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int getCategoryId = (int)cmbCategory.SelectedValue;
            int getItemId = Convert.ToInt32(txtId.Text);
            string getName = txtItemName.Text;
            string getDescription = txtDescription.Text;
            string getPrice = txtItemPrice.Text;
            int is_active = Convert.ToInt32(chkActive.Checked);

            Con.Open();

            string query = "update tblItems set " +
                "category_id = '"+ getCategoryId + "'," +
                "name = '"+getName+"'," +
                "description = '"+getDescription+"', price='"+getPrice+"', " +
                "is_active = '"+is_active+"' where id = '"+getItemId+"'";

            SqlCommand cmd = new SqlCommand(query, Con);

            cmd.ExecuteNonQuery();

            Con.Close();

            MessageBox.Show("Item Edited Successfully!");

            Populate();

            txtId.Text = "";
            txtItemName.Text = "";
            txtDescription.Text = "";
            txtItemPrice.Text = "";
        }

        private void gvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = gvItems.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtItemName.Text = gvItems.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtDescription.Text = gvItems.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtItemPrice.Text = gvItems.Rows[e.RowIndex].Cells[4].Value.ToString();

            int cat_id = Convert.ToInt32(gvItems.Rows[e.RowIndex].Cells[1].Value);
            cmbCategory.SelectedValue = cat_id;

            int active = Convert.ToInt32(gvItems.Rows[e.RowIndex].Cells[5].Value);

            if (active == 1)
            {
                chkActive.Checked = true;
            }
            else { 
                chkActive.Checked = false;
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int getItemId = Convert.ToInt32(txtId.Text);

            Con.Open();
            string query = "delete from tblItems where id ="+getItemId;
            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.ExecuteNonQuery();
            Con.Close();

            MessageBox.Show("Item Deleted");

            Populate();

            txtId.Text = "";
            txtItemName.Text = "";
            txtDescription.Text = "";
            txtItemPrice.Text = "";

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmGuestOrder frmOrder = new frmGuestOrder();
            frmOrder.Show();
        }
    }
}
