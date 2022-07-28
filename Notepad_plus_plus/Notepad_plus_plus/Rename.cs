using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepad_plus_plus
{
    public partial class Rename : Form
    {
        Main main;

        public Rename(Main m)
        {
            InitializeComponent();
            this.main = m;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string name = tb_rename.Text;
            main.Rename = name;
            this.Close();
        }
    }
}
