namespace FisketorvetInfinte.Services.StoreServices
{
    public class JsonFileProductService
    {
        public static List<Product> ReadJson(string jsonFilePath)
        {
            string output = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<Product>>(output);
        }

        public static void WriteToJson(List<Product> products, string jsonFilePath)
        {
            string output = JsonConvert.SerializeObject(products, Formatting.Indented);
            File.WriteAllText(jsonFilePath, output);
        }
    }
}
