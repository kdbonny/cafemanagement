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
using System.Drawing.Printing;

namespace CafeManagement
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-42HL7FQ;Initial Catalog=cafedb;Integrated Security=True");

        private void Form2_Load(object sender, EventArgs e)
        {

          

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

       
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.print(panel1);
        }

        private void print(Panel pnl) { 
            
            PrinterSettings ps = new PrinterSettings();
            panel1 = pnl;
            getprintarea(panel1);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();

        }

        private Bitmap memoryimage;

        private void getprintarea(Panel pnl) {

            memoryimage = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimage, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimage, (pagearea.Width/ 2) - (this.panel1.Width/2), this.panel1.Location.Y);
        }
    }
}
