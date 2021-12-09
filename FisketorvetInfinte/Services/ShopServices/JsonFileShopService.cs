namespace FisketorvetInfinte.Services
{
    public class JsonFileShopService
    {
        public static List<Shop> ReadJson(string jsonFilePath)
        {
            string output = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<Shop>>(output);
        }
        public static void WriteToJson(List<Shop> shops, string jsonFilePath)
        {
            string output = JsonConvert.SerializeObject(shops, Formatting.Indented);
            File.WriteAllText(jsonFilePath, output);
        }
    }
}