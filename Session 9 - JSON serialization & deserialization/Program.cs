// 1. Installer nuget: Newtonsoft.Json

using Newtonsoft.Json;
using System;
using System.IO;
namespace Session_9___JSON_serialization___deserialization
{
    internal class Program
    {

        static void Main(string[] args)
        {
            /*string json = @"{
              'Name': 'Jose Luis',
              'Channel': 'ParametricCamp',
              'Active': true,
             'Age': 3,
              'Members': [
                'Richard',
                'Tim',
                'Victor',
                'Chandra',
                'Andres',
                'Nicholas'
              ]
            }";*/

            // 2. Hente Json fra fil - HUSK præcis placering
            string json = null;
            
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "myFile.json");

            try
            {
                json = System.IO.File.ReadAllText(jsonFilePath);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            // 3.Deserialization
            Youtuber deserialized = JsonConvert.DeserializeObject<Youtuber>(json);

            // 4. Deserialized JSON printes
            Console.WriteLine(deserialized.Name);
            Console.WriteLine(deserialized.Channel);
            Console.WriteLine(deserialized.Active);
            Console.WriteLine(deserialized.Age);
            foreach (var member in deserialized.Members)
            {
                Console.WriteLine(member);
            }

            //? Hvis man vil serialize et objekt til JSON filformat
            string serialize = JsonConvert.SerializeObject(deserialized);
            
            Console.WriteLine(serialize);
        }


        // 2. Class opretes med properties der matcher Json properties
        // HUSK property navne SKAL matche JSON name properties
        public class Youtuber
        {
            public string Name { get; set; }
            public string Channel { get; set; }
            public bool Active { get; set; }
            public int Age { get; set; }
            public List<String> Members { get; set; }
        }
    }
}
