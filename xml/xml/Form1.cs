using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using xml.xml;
using xml.界面;

namespace xml
{
    public partial class Form1 : Form
    {
        GetFile getFile = new GetFile();
        public winBtnCompare winbtncompare;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PublicValue.file == null)
            {
                getFile.GetFolder();
            }
                listBox1.Items.Clear();
                PublicValue.SecControls.Clear();
                SectionInfo sectionInfo = new SectionInfo();
                try
                {
                    sectionInfo.OutSec();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            foreach (String SecControl in PublicValue.SecControls)
            {
                listBox1.Items.Add(SecControl);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            getFile.GetFolder();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            winbtncompare = new winBtnCompare();
        }
        private void btnDevProps_Click(object sender, EventArgs e)
        {
            getFile.GetFolder();
            listBox1.Items.Clear();
            PublicValue.DevBtn.Clear();
            DevProps Dev = new DevProps();
            try
            {
                Dev.OutDev();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (String DevBtn in PublicValue.DevBtn)
            {
                listBox1.Items.Add(DevBtn);
            }
        }

        private void btnInterlockButtons_Click(object sender, EventArgs e)
        {  
            getFile.GetFolder();
            getFile.GetFilePath(@"C:\Users\ShenBoyi\Desktop\4.18数据\4.18数据\Station_DLD");
            listBox2.Items.Clear();
            PublicValue.InterLocBtn.Clear();
            InterlockButtons InterLoc = new InterlockButtons();
            try
            {
                InterLoc.Out();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            foreach (String InterLockBtn in PublicValue.InterLocBtn)
            {
                listBox2.Items.Add(InterLockBtn);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            PublicValue.BtnCompare.Clear();
            BtnCompare btncompare = new BtnCompare();
            btncompare.Compare();
            foreach (String BtnCompare in PublicValue.BtnCompare)
            {
                listBox3.Items.Add(BtnCompare);
            }
        }

        private void 打开OToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
    
  
}
 


