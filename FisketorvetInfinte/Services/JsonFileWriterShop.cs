using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisketorvetInfinte.Helpers
{
    public class JsonFileWriterShop
    {
        public static void WriteToJson(List<Shop> shops, string jsonFilePath)
        {
            string output = JsonConvert.SerializeObject(shops, Formatting.Indented);
            File.WriteAllText(jsonFilePath, output);
        }
    }
}
