using System;
using System.Drawing;
using System.Windows.Forms;
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (PublicValue.file == null)
        //    {
        //        getFile.GetFolder();
        //    }
        //    listBox1.Items.Clear();
        //    PublicValue.SecControls.Clear();
        //    SectionInfo sectionInfo = new SectionInfo();
        //    try
        //    {
        //        sectionInfo.OutSec();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    foreach (String SecControl in PublicValue.SecControls)
        //    {
        //        listBox1.Items.Add(SecControl);
        //    }
        //}

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
            DataGridViewTextBoxColumn col1 = new DataGridViewTextBoxColumn();
            col1.HeaderText = "DEV中的按钮";
            dataGridView1.Columns.Add(col1);
            DataGridViewTextBoxColumn col2 = new DataGridViewTextBoxColumn();
            col2.HeaderText = "Inter中的按钮";
            dataGridView1.Columns.Add(col2);

        }
        private void btnDevProps_Click(object sender, EventArgs e)
        {
            //getFile.GetFolder();
            //listBox1.Items.Clear();
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
                //listBox1.Items.Add(DevBtn);
            }
        }

        private void btnInterlockButtons_Click(object sender, EventArgs e)
        {  
            getFile.GetFolder();
           
            //listBox2.Items.Clear();
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
                //listBox2.Items.Add(InterLockBtn);
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            DevProps Dev = new DevProps();
            InterlockButtons InterLoc = new InterlockButtons();
           
            try
            {
                PublicValue.InterLocBtn.Clear();
                PublicValue.DevBtn.Clear();
                Dev.OutDev();
                InterLoc.Out();
                listBox3.Items.Clear();
                listBox3.Items.Add(PublicValue.FilePath);
                PublicValue.BtnCompare.Clear();
                BtnCompare btncompare = new BtnCompare();
                btncompare.Compare();
                winBtnCompare winbtncompare = new winBtnCompare();       
                winbtncompare.Show();
                foreach (String BtnCompare in PublicValue.BtnCompare)
                {
                    listBox3.Items.Add(BtnCompare);
                   
                   // MessageBox.Show(BtnCompare);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
             
            }
           
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
            //listBox3.Width=
        }

        private void tsbtnFile_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            PublicValue.FilePath = null;
            getFile.GetFilePath();
            if (PublicValue.FilePath != null)
            {
                listBox3.Items.Clear();
                listBox3.Items.Add(PublicValue.FilePath);
                DevProps Dev = new DevProps();
                InterlockButtons InterLoc = new InterlockButtons();
                StationDetail stationDetail = new StationDetail();
                try
                {
                    Dev.OutDev();
                    InterLoc.Out();
                    stationDetail.Out();
                    foreach (String BtnCompare in PublicValue.StationDeatail_Track)
                    {
                        listBox3.Items.Add(BtnCompare);

                        // MessageBox.Show(BtnCompare);
                    }
                    foreach (String BtnCompare in PublicValue.StationDeatail_MotorType)
                    {
                        listBox1.Items.Add(BtnCompare);

                        // MessageBox.Show(BtnCompare);
                    }
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "读取文件错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("已选择文件夹:" + PublicValue.FilePath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            this.Close();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count1=0;
            int count2 = 0;
            dataGridView1.Rows.Clear();
            
          
            foreach (String DevBtn in PublicValue.DevBtn1)
            {
                DataGridViewRow row = new DataGridViewRow();
                int index = dataGridView1.Rows.Add(row);
                dataGridView1.Rows[count1].Cells[0].Value = DevBtn;  
                if (DevBtn == null)
                {
                    dataGridView1.Rows[count1].Cells[0].Style.BackColor = Color.Yellow;
                }
                count1 += 1;
            }
            foreach (String InterLocBtn in PublicValue.InterLocBtn1)
            {
               
                if (count2<count1)
                {
                    dataGridView1.Rows[count2].Cells[1].Value = InterLocBtn;
                }
                else
                {
                    DataGridViewRow row = new DataGridViewRow();
                    int index = dataGridView1.Rows.Add(row);
                    dataGridView1.Rows[count2].Cells[1].Value = InterLocBtn;
                }
                if (InterLocBtn == null)
                {
                    dataGridView1.Rows[count2].Cells[1].Style.BackColor = Color.Yellow;
                }
                count2 += 1;
            }
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            PublicValue.DevBtn1.Clear();
            PublicValue.InterLocBtn1.Clear();
            foreach (char a in PublicValue.a.ToString())
            {
                listBox1.Items.Add(PublicValue.a);
            }
            
        }

        private void btnStationDetail_Click(object sender, EventArgs e)
        {

            formStationDetail formStationDetail = new formStationDetail();
            formStationDetail.Show();

        }
    }
    
  
}
 


