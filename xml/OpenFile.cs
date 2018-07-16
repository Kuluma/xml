
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using xml.xml;

namespace xml
{
    class OpenFile
    {
        GetFilePath getFile = new GetFilePath();
       
            
            public  int GetFilesCount(DirectoryInfo dirInfo)
            {
                int totalFile = 0;
                totalFile += dirInfo.GetDirectories().Length;

            DirectoryInfo[] listdir = dirInfo.GetDirectories();//获取文件夹名称
            foreach (var item in listdir)
            {
                PublicValue.listdir.Add(item.ToString());
            }

            //FileInfo[] listfile = dirInfo.GetFiles();
            //foreach (DirectoryInfo subdir in dirInfo.GetDirectories())
            //{
            //    totalFile += GetFilesCount(subdir);
            //}
            PublicValue.FilesCount = totalFile;
            return totalFile;
            
            }
       
        public void openFile(string FilePath)
        {
            PublicValue.FilePath = null;
            getFile.getFilePath();
            if (PublicValue.FilePath != null)
            {
                
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

                    //MessageBox.Show(ex.Message, "读取文件错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //MessageBox.Show("已选择文件夹:" + PublicValue.FilePath, "选择文件夹提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                openFile(FilePath);
            }
        }
    }
        
}