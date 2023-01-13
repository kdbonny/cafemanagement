using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CafeManagement
{
    public partial class frmPosPrint : Form
    {
        //public static List<string> itemList = new List<string>();
        public string test = "";
        public frmPosPrint()
        {
            InitializeComponent();
        }

        private void frmPosPrint_Load(object sender, EventArgs e)
        {
            label1.Text = test;
        }
    }
}
