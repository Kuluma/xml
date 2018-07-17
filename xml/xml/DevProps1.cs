
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace xml.xml
{
    class DevProps1
    {
        public void Out()
        {
            XDocument xDocument= XDocument.Load(PublicValue.FilePath + "\\DevProps.xml");
            XElement xElement = XElement.Load(PublicValue.FilePath + "\\DevProps.xml");
            IEnumerable<XElement> childlist = from el in xElement.Elements("Devs")
                                              where el.Attribute("DevType").Value== "IndicationLamp"
                                              
                                              select el;
        
                foreach (XElement e in childlist)
                Console.WriteLine(e);
            XElement root = xDocument.Root;
       
            //XElement ele = root.Element("Devs");
        }
    }
}