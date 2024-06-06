namespace DesignPatterns.StructuralPattern.Adapter
{
    public interface IJsonConverter
    {
        string ConvertToJson(string xml);
    }
}
