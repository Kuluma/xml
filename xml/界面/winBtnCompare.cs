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
        private void winBtnCompare_Load(object sender, EventArgs e)
        {
            foreach (String BtnCompare in PublicValue.BtnCompare)
            {
                listBox1.Items.Add(BtnCompare);
            }
        }
    }
}
