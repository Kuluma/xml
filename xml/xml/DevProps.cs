using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml.xml
{
    class DevProps
    {
        public void OutDev()
        {
            XDocument xDoc = XDocument.Load(PublicValue.FilePath+ "\\DevProps.xml");
            XElement root = xDoc.Root;  //获取根节点
                                        //通过递归，获取所有下面的子元素
            GetXElement(root);
        }
        private void GetXElement(XElement root)
        {
            //返回IEnumerable接口的对象，都可以实现foreach循环遍历
            int i = 0;
            //int j = 0;
            foreach (XElement element in root.Elements())
            {        
                    switch (element.Name.ToString())
                    {
                        case "FuncButton":
                                PublicValue.DevBtn.Add(element.Attribute("name").Value);
                            break;
                        case "SignalButton":
                                PublicValue.DevBtn.Add(element.Attribute("name").Value);
                            break;
                        case "SectionButton":
                                 PublicValue.DevBtn.Add(element.Attribute("name").Value);
                            break;
                        case "SwitchButton":
                                 PublicValue.DevBtn.Add(element.Attribute("name").Value);
                            break;
                    case "Switch":
                        string[] test = new string[] {  i.ToString(), (i + 1).ToString()  };
                        //test[i] = element.Attribute("name").Value;
                        PublicValue.a.Add(test);
                            //PublicValue.a[i, 0] = element.Attribute("name").Value;
                        //PublicValue.a[i, 1] = element.Attribute("SwitchNo").Value;
                        i++;
                        break;

                }
                GetXElement(element);

            }
        }
    }
}
