using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace EXAM_Problem_6
{
    internal class Program
    {
        public class Singleton
        {
            private static Singleton instance = new Singleton();

            public string PlayerName { get; set; }
            public int Level { get; set; }
            public int HP { get; set; }
            public List<string> Inventory { get; set; }
            public string LicenseKey { get; set; }

            private Singleton()
            {
                PlayerName = "DefaultUser";
                Level = 1;
                HP = 100;
                Inventory = new List<string> { "sword", "shield", "potion" };
                LicenseKey = "DEFAULT-KEY";

            }

            public static Singleton GetInstance()
            {
                return instance;
            }

            public void Load(string file)
            {
                try
                {
                    var loadedSettings = JsonConvert.DeserializeObject<Singleton>(file);
                    PlayerName = loadedSettings.PlayerName;
                    Level = loadedSettings.Level;
                    HP = loadedSettings.HP;
                    Inventory = loadedSettings.Inventory;
                    LicenseKey = loadedSettings.LicenseKey;

                    Console.WriteLine("Settings loaded successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading settings: {ex.Message}");
                }

            }

            public void Save(string file)
            {
                try
                {
                    string json = JsonConvert.SerializeObject(instance, Formatting.Indented);
                    System.IO.File.WriteAllText(file, json);
                    Console.WriteLine("Settings saved successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error saving settings: {ex.Message}");
                }

            }
        }

        static void Main(string[] args)
        {
            string json = @"{""player_name"":""dschuh"",""level"":4,""hp"":99,""inventory"":[""spear"",""water bottle"",""hammer"",""sonic screwdriver"",""cannonball"",""wood"",""Scooby snack"",""Hydra"",""poisonous potato"",""dead bush"",""repair powder""],""license_key"":""DFGU99-1454""}";

            Singleton singleton = Singleton.GetInstance();

            //load
            singleton.Load(json);

            //save
            singleton.Save(json);



        }
    }
}
