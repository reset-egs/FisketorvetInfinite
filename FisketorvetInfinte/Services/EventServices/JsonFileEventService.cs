namespace FisketorvetInfinte.Services.EventServices
{
    public class JsonFileEventService
    {
        public static List<Event> ReadJson(string jsonFilePath)
        {
            string output = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<Event>>(output);
        }

        public static void WriteToJson(List<Event> events, string jsonFilePath)
        {
            string output = JsonConvert.SerializeObject(events, Formatting.Indented);
            File.WriteAllText(jsonFilePath, output);
        }
    }
}