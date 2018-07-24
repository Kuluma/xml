
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace xml.xml
{
    public class DevPropsMode
    {
        public DevPropsMode()
        { }
         /// <summary>
         /// 类型
          /// </summary>
        private string type;
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        private string id;
        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        
    }
    public class DevPropsMode_Button : DevPropsMode { 
}

    public class InterlockButtonsMode
    {
        public InterlockButtonsMode()
        {

        }
        private string no;
        public string No
        {
            get { return no; }
            set { no = value; }
        }
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
    }
}