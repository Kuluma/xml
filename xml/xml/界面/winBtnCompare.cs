using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xml;

namespace xml.界面
{
    public partial class winBtnCompare : Form
    {
        public winBtnCompare()
        {
            InitializeComponent();
        }

        private void winBtnCompare_FormClosing(object sender, FormClosingEventArgs e)
        {
            //this.Owner{ get;set; }


            Form1 form1 = new Form1();
            form1.Show();
            
        }
    }
}
