using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FisketorvetInfinte.Helpers
{
    public class JsonFileReaderShop
    {
        public static List<Shop> ReadJson(string jsonFilePath)
        {
            string output = File.ReadAllText(jsonFilePath);
            return JsonConvert.DeserializeObject<List<Shop>>(output);
        }
    }
}
