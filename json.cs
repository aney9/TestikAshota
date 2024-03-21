using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace Test
{
    public class json
    {
        public void Ser<T>(T data, string fileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string json = JsonConvert.SerializeObject(data, Formatting.Indented);
            File.WriteAllText(desktop + "\\" + fileName, json);
        }

        public static T Deser<T>(string fileName)
        {
            string desktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            try
            {
                string jsonData = File.ReadAllText(desktop + "\\" + fileName);
                return JsonConvert.DeserializeObject<T>(jsonData);
            }
            catch (Exception)
            {
                //он не работает без try catch
            }
            return default;
        }
    }
}
