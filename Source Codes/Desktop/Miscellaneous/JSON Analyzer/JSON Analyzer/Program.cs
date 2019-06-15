using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSON_Analyzer
{
    public class League
    {
        public int id;
        public string name;
        public int sportId;
    }
    public class Sport
    {
        public int id;
        public string name;
        
    }
    public class Game
    {
        public string eventName;
        public string date;

        public Sport sport;
        public League league;

        public int homeTeamScore;
        public int awayTeamScore;
        public float homeTeamOdds;
        public float awayTeamOdds;
        public float drawOdds;

    }
    
    class Program
    {
        private static string jsonFilePath = "sport-events.json";
        static void Main(string[] args)
        {
            string json = File.ReadAllText(jsonFilePath);
            List<Game> list = JsonConvert.DeserializeObject<List<Game>>(json);

            
        }
    }
}
