using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class DataLoader
    {
        const string dbResourceName = "Data.db.json";

        public static AllData Load()
        {
            return JsonConvert.DeserializeObject<AllData>(getContent());
        }

        private static string getContent()
        {
            var assembly = Assembly.GetExecutingAssembly();

            using (Stream stream = assembly.GetManifestResourceStream(dbResourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
