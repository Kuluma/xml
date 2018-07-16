using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace xml
{
    class GetFile
    {
        public void GetFolder()
        {

            
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = true;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "所有文件(*xml*)|*.xml*"; //设置要选择的文件的类型
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                PublicValue.file = fileDialog.FileName;//返回文件的完整路径    
                //button1_Click();
            }
           
        }
     
        public void GetFilePath(string path)
        {
      
            DirectoryInfo Dir = new DirectoryInfo(path);
            //Dir.GetFiles();
           
            foreach (var FilePath in Dir.GetFiles())
            {
                Console.WriteLine(FilePath);
            }
           
            Dir.GetDirectories();
        }

    }
}
