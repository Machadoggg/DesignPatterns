namespace DesignPatterns.StructuralPattern.Adapter
{
    public class XmlConverter
    {
        public string ConvertToXml(string data)
        {
            // Conversion JSON to XML
            return $"<data>{data}</data>";
        }
    }
}
