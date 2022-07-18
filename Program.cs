
using Newtonsoft.Json;
using ReadJSON.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace ReadJSON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.GetExecutingAssembly();

            var json_message = GetJson($"ReadJSON.Resource.macaddress.json", assembly);

            JSONCollection collection = JsonConvert.DeserializeObject<JSONCollection>(json_message);

            List<string> macAddresses = new List<string>();

            foreach (var sub in collection.Settings.Module.Subsystems)
            {
                foreach (var elt in sub.Elements)
                {
                    if (elt.Name.Equals("EthMacAddress"))
                    {
                        macAddresses.Add(elt.Value);
                    }
                }
            }

            foreach (var value in macAddresses)
            {
                Console.WriteLine($"EthMacAddress: {value}");
            }

            string productMac = "00:02:4E:26:02:DB";

            bool found = macAddresses.Where(x => x.Equals(productMac)).Count() == 1;

            Console.WriteLine($"Result: {found}");
        }

        public static string GetJson(string resourceName, Assembly assembly)
        {
            string content = string.Empty;
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                content = reader.ReadToEnd();
            }
            return content;
        }
    }
}
