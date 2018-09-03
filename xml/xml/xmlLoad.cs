
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace xml.xml
{
   
    public class DevPropsMode_Button : DevPropsMode { 
}

  
    public class LayoutMode
    {
        public LayoutMode()
        {

        }
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
}