using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace xml.xml
{
    class StationDetail
    {
        public void Out()
        {
            XDocument xDoc = XDocument.Load(PublicValue.FilePath + "\\StationDetail.xml");
            XElement root = xDoc.Root;  //获取根节点
                                        //通过递归，获取所有下面的子元素
            GetXElement(root);
        }
        public void LoadTrack(XElement element)
        {
            switch (element.Attribute("Type").Value.ToString())
            {
                case "Wagon":
                    if (element.Attribute("Enable").Value== "Y")
                    {
                        PublicValue.StationDeatail_MotorType.Add("货车");
                    }
                break;
                case "Passenger":
                    if (element.Attribute("Enable").Value == "Y")
                {
                    PublicValue.StationDeatail_MotorType.Add("客车");
                }
                   break;
                case "OutLoad":
                    if (element.Attribute("Enable").Value == "Y")
                    {
                        PublicValue.StationDeatail_MotorType.Add("超限车");
                    }
                break;
                case "Motor":
                    if (element.Attribute("Enable").Value == "Y")
                    {
                        PublicValue.StationDeatail_MotorType.Add("动车");
                    }
                    break;
            }
            
        }
        
        private void GetXElement(XElement root)
        {
            //返回IEnumerable接口的对象，都可以实现foreach循环遍历
            foreach (XElement element in root.Elements())
            {
                if (element.Elements().Count() > 0)
                {
                    switch (element.Name.ToString())
                    {
                        case "Track":
                            PublicValue.StationDeatail_Track.Add(element.Attribute("DevName").Value);
                            break;
                        case "Prop":
                            LoadTrack(element);
                            break;

                    }
                    GetXElement(element);
                }
                PublicValue.StationDeatail_MotorType.Clear();
                PublicValue.StationDeatail_Track.Clear();
            }
        }
    }
}
