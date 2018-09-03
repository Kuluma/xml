using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml.xml
{
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



    class InterlockButtons
    {
        public static List<InterlockButtonsMode> interlockButtonsMode = new List<InterlockButtonsMode>();
        public void Out()//数据读取
        {
         
            XElement xElement = XElement.Load(PublicValue.FilePath + "\\InterlockButtons.xml");
            IEnumerable<XElement> elements = from el in xElement.Elements("button")
                                             select el;
            foreach (var item in elements)
            {
                
                InterlockButtonsMode interlockButtonsModes = new InterlockButtonsMode();
                interlockButtonsModes.No = item.Attribute("no").Value;
                interlockButtonsModes.Name = item.Attribute("name").Value;
                interlockButtonsMode.Add(interlockButtonsModes);

              
            }
        }
       public void insert()//数据插入
        {
            XElement xe = XElement.Load(PublicValue.FilePath + "\\InterlockButtons.xml");
                 XElement record = 
                 new XElement("button",
                 new XAttribute("no", "999"),
                 new XAttribute("name", "7-111-19149-1"));
                  xe.Add(record);
                  xe.Save(PublicValue.FilePath + "\\InterlockButtons.xml");
        }

        public void replace()
        {
            
        }
    }
}
