namespace FisketorvetInfinte.Helpers
{
    public class JsonFileWriterUser
    {
        public static void WriteToJson (List<User> users, string jsonFilePath)
        {
            string output = JsonConvert.SerializeObject (users, Formatting.Indented);
            File.WriteAllText (jsonFilePath, output);
        }
    }
}
