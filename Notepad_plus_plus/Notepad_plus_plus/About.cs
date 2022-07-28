using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_plus_plus
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lbl_ProductName.Text = string.Format("Product Name: {0}", Application.ProductName);
            lbl_ProductVersion.Text = string.Format("Version: {0}", Application.ProductVersion);
            lbl_Copyright.Text = "Copyright ©  2021";
        }
    }
}
