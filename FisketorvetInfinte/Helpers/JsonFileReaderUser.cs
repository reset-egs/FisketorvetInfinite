namespace FisketorvetInfinte.Helpers
{
    public class JsonFileReaderUser
    {
        public static List<User> ReadJson (string jsonFilePath)
        {
            string output = File.ReadAllText (jsonFilePath);
            return JsonConvert.DeserializeObject<List<User>>(output);
        }
    }
}
