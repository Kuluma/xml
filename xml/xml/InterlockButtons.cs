using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml.xml
{
    class InterlockButtons
    {
        public void Out()//数据读取
        {
         
            XElement xElement = XElement.Load(PublicValue.FilePath + "\\InterlockButtons.xml");
            IEnumerable<XElement> elements = from el in xElement.Elements("button")
                                             select el;
            foreach (var item in elements)
            {
                
                InterlockButtonsMode interlockButtonsMode = new InterlockButtonsMode();
                interlockButtonsMode.No = item.Attribute("no").Value;
                interlockButtonsMode.Name = item.Attribute("name").Value;
                PublicValue.interlockButtonsMode.Add(interlockButtonsMode);

              
            }
        }
       public void insert(string No,string Name)//数据插入
        {
            XElement xe = XElement.Load(PublicValue.FilePath + "\\InterlockButtons.xml");
                 XElement record = 
                 new XElement("button",
                 new XAttribute("no", "999"),
                 new XAttribute("name", "7-111-19149-1"));
                  xe.Add(record);
                  xe.Save(PublicValue.FilePath + "\\InterlockButtons.xml");
        }

    }
}
