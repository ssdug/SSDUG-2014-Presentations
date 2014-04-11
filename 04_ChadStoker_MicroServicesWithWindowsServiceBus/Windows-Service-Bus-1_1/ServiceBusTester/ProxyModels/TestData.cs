using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ServiceBusTester.ProxyModels
{
    [XmlRoot("Chat", Namespace = root)]
    public class TestData
    {
        public const string xsd = "http://www.w3.org/2001/XMLSchema";
        public const string root = "http://windowsazure.cat.microsoft.com/samples/multicast";


        public TestData()
        {
            xmlns = new XmlSerializerNamespaces();
            xmlns.Add("", root);
        }

        [XmlNamespaceDeclarations]
        public XmlSerializerNamespaces xmlns;

        [XmlElement("nickname")]
        public string Nickname { get; set; }

        [XmlElement("text")]
        public string Text { get; set; }
    }
}
