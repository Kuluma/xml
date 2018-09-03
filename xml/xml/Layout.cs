using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml.xml
{
    class Layout
    {
        public void Out()
        {

            XDocument xDocument = XDocument.Load(PublicValue.FilePath + "\\DevProps.xml");
            XElement xElement = XElement.Load(PublicValue.FilePath + "\\DevProps.xml");
            IEnumerable<XElement> elements = from el in xElement.Elements("Devs")
                                             select el;
            foreach (var item in elements)
            {
                IEnumerable<XElement> elementss = from el in item.Elements(item.Attribute("DevType").Value)
                                                  select el;


                foreach (var ele in elementss)
                {
                    DevPropsMode devPropsMode = new DevPropsMode();
                    devPropsMode.Type = item.Attribute("DevType").Value;
                    devPropsMode.Id = ele.Attribute("id").Value;
                    devPropsMode.Name = ele.Attribute("name").Value;

                    PublicValue.modelList.Add(devPropsMode);
                }
            }
        }



    }
}
