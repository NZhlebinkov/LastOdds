using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Analyzer
{
    public class Game
    {
        public int homeScore;
        public int awayScore;
       

        public string eventName;
        public string date;

        public Tuple<int, string> Sport;

        class League
        {
            int id;
            string name;
            int sportId;
        }

        float homeOdds;
        float awayOdds;
        float drawOdds;

    }
    
    class Program
    {
        private static string jsonFilePath = "sport-events.json";
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            string json = File.ReadAllText(jsonFilePath);
            List<Game> list = JsonConvert.DeserializeObject<List<Game>>(json);
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i].Sport.Item1);
            }
        }
    }
}
