using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using xml.xml;
using xml.界面;

namespace xml
{
    public partial class Form1 : Form
    {
        GetFilePath getFile = new GetFilePath();
        OpenFile openFile = new OpenFile();
        public Form1()
        {
            InitializeComponent();
        }
        private void btnCompare_Click(object sender, EventArgs e)
        {
            DevProps Dev = new DevProps();
            InterlockButtons InterLoc = new InterlockButtons();
            OpenFile openFile = new OpenFile();
            lstForm1.Items.Clear();
            foreach (string FilePath in PublicValue.FilePaths)
            {

                PublicValue.FilePath = FilePath;
                try
                {
                    PublicValue.InterLocBtn.Clear();
                    PublicValue.DevBtn.Clear();
                    Dev.OutDev();
                    InterLoc.Out();
                    //lstForm1.Items.Add(PublicValue.FilePath);
                    lstForm1.Items.Add(new DirectoryInfo(FilePath).Name);
                    lstForm1.Items.Add("");
                    PublicValue.BtnCompare.Clear();
                    BtnCompare btncompare = new BtnCompare();
                    btncompare.Compare();
                    //winBtnCompare winbtncompare = new winBtnCompare();       
                    //winbtncompare.Show();
                    foreach (String BtnCompare in PublicValue.BtnCompare)
                    {
                        lstForm1.Items.Add(BtnCompare);
                        // MessageBox.Show(BtnCompare);
                    }
                    lstForm1.Items.Add("");
                    lstForm1.Items.Add("");
                    lstForm1.Items.Add("");

                }
                catch (Exception ex)
                {
                    lstForm1.Items.Add(new DirectoryInfo(FilePath).Name);
                    lstForm1.Items.Add("!!!!!" + ex.Message + "!!!!!");
                    lstForm1.Items.Add("");
                    lstForm1.Items.Add("");
                    lstForm1.Items.Add("");
                    //MessageBox.Show(ex.Message);

                }
            }
        }
        private void btnOpenFile_Click_1(object sender, EventArgs e)
        {
            PublicValue.FilePath = null;
            getFile.getFilePath();
            //DirectoryInfo dirInfo = new DirectoryInfo(PublicValue.FilePath);
            //openFile.GetFilesCount(dirInfo);
            if (PublicValue.FilePath != null)
            {
                lstForm1.Items.Clear();
                lstForm1.Items.Add(PublicValue.FilePath);
                
                DevProps Dev = new DevProps();
                InterlockButtons InterLoc = new InterlockButtons();
                StationDetail stationDetail = new StationDetail();
                try
                {
                    Dev.OutDev();
                    InterLoc.Out();
                    stationDetail.Out();
                   
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
        protected override void OnSizeChanged(EventArgs e)
        {
            //lstForm1.Font = new Font(lstForm1.Font.FontFamily, 12f * this.Height / 400,//自动变化自大小
            //                       lstForm1.Font.Style, GraphicsUnit.Pixel);
            //base.OnSizeChanged(e);
            lstForm1.Size = new Size(this.ClientSize.Width-50, this.ClientSize.Height-90);//修改窗体大小
            //lstForm1.Margin =new Padding(10,10,10,10);
            lstForm1.Dock = DockStyle.None;
            // .. and add it to the controls.
            this.Controls.Add(lstForm1);
        }
        private void Form_DragEnter(object sender, DragEventArgs e)
        {
            PublicValue.FilePaths.Clear();
            dragEnter(e);
        }

        private void Form_DragDrop(object sender, DragEventArgs e)
        {
            //ListBox lstForm1 = sender as ListBox;
            lstForm1.Items.Add(dragDrop(e));
            btnCompare_Click(null,null);
        }

        /// <summary>
        /// 文件拖进事件处理：
        /// </summary>
        public void dragEnter(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))    //判断拖来的是否是文件
                e.Effect = DragDropEffects.Link;                //是则将拖动源中的数据连接到控件
            else e.Effect = DragDropEffects.None;
        }

        /// <summary>
        /// 文件放下事件处理：
        /// 放下, 另外需设置对应控件的 AllowDrop = true; 
        /// 获取的文件名形如 "d:\1.txt;d:\2.txt"
        /// </summary>
        public string dragDrop(DragEventArgs e)
        {
            StringBuilder filesName = new StringBuilder("");
            Array file = (System.Array)e.Data.GetData(DataFormats.FileDrop);//将拖来的数据转化为数组存储
            StringBuilder str = new StringBuilder("");
            //string str1;
            foreach (object I in file)
            {
                 str.Append(I.ToString());
                PublicValue.FilePaths.Add(I.ToString());
                //System.IO.FileInfo info = new System.IO.FileInfo(str);
                ////若为目录，则获取目录下所有子文件名
                //if ((info.Attributes & System.IO.FileAttributes.Directory) != 0)
                //{
                //    str = getAllFiles(str);
                //    if (!str.Equals("")) filesName.Append((filesName.Length == 0 ? "" : ":") + str);
                //}
                ////若为文件，则获取文件名
                //else if (System.IO.File.Exists(str))
                //    filesName.Append((filesName.Length == 0 ? "" : ":") + str);
                //        str1.Append(Path.GetDirectoryName(str.ToString()));

            }

            return str.ToString();
        }

        /// <summary>
        /// 判断path是否为目录
        /// </summary>
        public bool IsDirectory(String path)
        {
            System.IO.FileInfo info = new System.IO.FileInfo(path);
            return (info.Attributes & System.IO.FileAttributes.Directory) != 0;
        }

        /// <summary>
        /// 获取目录path下所有子文件名
        /// </summary>
        public string getAllFiles(String path)
        {
            StringBuilder str = new StringBuilder("");
            if (System.IO.Directory.Exists(path))
            {
                //所有子文件名
                string[] files = System.IO.Directory.GetFiles(path);
                foreach (string file in files)
                    str.Append((str.Length == 0 ? "" : ";") + file);

                //所有子目录名
                string[] Dirs = System.IO.Directory.GetDirectories(path);
                foreach (string dir in Dirs)
                {
                    string tmp = getAllFiles(dir);  //子目录下所有子文件名
                    if (!tmp.Equals("")) str.Append((str.Length == 0 ? "" : ";") + tmp);
                }
            }
            return str.ToString();
        }
    }
    
  
}
 


