using System.Xml.Linq;

namespace xml.xml
{
    class Layout
    {
        public void Out()
        {
            XDocument xDoc = XDocument.Load(PublicValue.file);
            XElement root = xDoc.Root;  //获取根节点
                                        //通过递归，获取所有下面的子元素
            GetXElement(root);
        }
        private void GetXElement(XElement root)
        {
            //返回IEnumerable接口的对象，都可以实现foreach循环遍历
            foreach (XElement element in root.Elements())
            {
                switch (element.Name.ToString())
                {
                    case "Device":
                        PublicValue.LayoutId.Add(element.Attribute("id").Value);
                        break;
                }
                GetXElement(element);
            }
        }


    }
}
