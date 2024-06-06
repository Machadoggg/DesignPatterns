using DesignPatterns.StructuralPattern.Adapter;

XmlConverter xmlConverter = new XmlConverter();
IJsonConverter jsonConverter = new XmlToJsonAdapter(xmlConverter);

string jsonData = "{\"name\":\"John\", \"age\":30}";
string jsonResult = jsonConverter.ConvertToJson(jsonData);

Console.WriteLine($"Json format: {jsonResult}");