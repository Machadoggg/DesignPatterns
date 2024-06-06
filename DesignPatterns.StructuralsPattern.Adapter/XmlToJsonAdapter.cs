using Newtonsoft.Json;
using System.Xml;

namespace DesignPatterns.StructuralPattern.Adapter
{
    public class XmlToJsonAdapter : IJsonConverter
    {
        private readonly XmlConverter _xmlConverter;

        public XmlToJsonAdapter()
        {
            _xmlConverter = new XmlConverter();
        }


        public string ConvertToJson(string xml)
        {
            // first convert XML to JSON using old system
            string xmlData = _xmlConverter.ConvertToXml(xml);

            // Convert XML to JSON
            XmlDocument document = new XmlDocument();
            document.LoadXml(xmlData);
            string json = JsonConvert.SerializeXmlNode(document);
            return json;
        }
    }
}
