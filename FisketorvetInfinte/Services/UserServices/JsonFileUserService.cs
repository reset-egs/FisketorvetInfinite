namespace FisketorvetInfinte.Services
{
    public class JsonFileUserService
    {
        public static List<User> ReadJson(string jsonFilePath)
        {
            string output = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<User>>(output);
        }

        public static void WriteToJson(List<User> users, string jsonFilePath)
        {
            string output = JsonConvert.SerializeObject(users, Formatting.Indented);
            File.WriteAllText(jsonFilePath, output);
        }
    }
}
