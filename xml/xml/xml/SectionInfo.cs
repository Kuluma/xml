using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml
{
    public class SectionInfo
    {
        //List<String> SecControls = new List<string>();

        //Form1 f1 = new Form1();

        public void OutSec()
        {



            //XDocument xDoc = XDocument.Load(@"C:\Users\ShenBoyi\Desktop\SectionInfos-SN1T.xml"); //加载xml文件
            XDocument xDoc = XDocument.Load(PublicValue.file);
            XElement root = xDoc.Root;  //获取根节点
                                        //通过递归，获取所有下面的子元素
            GetXElement(root);
            //List<String> SecControls = new List<string>();


        }

        private void GetXElement(XElement root)
        {

            //返回IEnumerable接口的对象，都可以实现foreach循环遍历
            foreach (XElement element in root.Elements())
            {
                //递归 
                if (element.Elements().Count() > 0)
                {
                    string name = element.Name.ToString();
                    Console.Write(element.Name);



                    switch (element.Name.ToString())
                    {
                        case "SectionInfo":
                            Console.WriteLine(element.Attribute("SectionBrief").Value);
                            break;
                        case "Sta":
                            Console.WriteLine(element.Attribute("StaBrief").Value);

                            break;
                        //case "Control":
                        //    Console.WriteLine(element.Attribute("type").Value);

                        //    PublicValue.SecControls.Add(element.Attribute("type").Value.ToString());

                        //    break;

                    }

                    GetXElement(element);
                }
                else
                {
                    Console.WriteLine(element.Name);
                    switch (element.Name.ToString())
                    {
                        case "Control":
                            Console.WriteLine(element.Attribute("type").Value);
                            if (element.Attribute("type").Value == "1")
                            {
                                PublicValue.SecControls.Add("可控");
                            }
                            else
                            {
                                PublicValue.SecControls.Add("不可控");
                            }
                            //PublicValue.SecControls.Add(element.Attribute("type").Value.ToString());
                            break;
                        case "Mirror":
                            Console.WriteLine(element.Attribute("type").Value);
                            break;
                        case "PanoCoord":
                            Console.WriteLine(element.Attribute("x").Value);
                            Console.WriteLine(element.Attribute("y").Value);
                            break;
                        case "PanoStationLayout":
                            Console.WriteLine(element.Attribute("name").Value);
                            break;
                        case "SignalStationLayout":
                            Console.WriteLine(element.Attribute("name").Value);
                            break;
                        case "DeviceInfo":
                            Console.WriteLine(element.Attribute("type").Value);
                            break;
                    }
                }

            }
        }
    }
}
