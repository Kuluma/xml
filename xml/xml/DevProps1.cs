
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
            XElement root = xDocument.;
            XElement ele = root.Element("Devs");
        }
    }
}