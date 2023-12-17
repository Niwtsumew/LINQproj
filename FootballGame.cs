using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Linq
{
    public class FootballGame
    {
        public DateTime Date { get; set; }
        public string Home_team { get; set; }
        public string Away_team { get; set; }
        public int Home_score { get; set; }
        public int Away_score { get; set; }
        public string Tournament { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public bool Neutral { get; set; }

        public string InfoToString()
        {
            return $"{Date.ToString("dd.MM.yyyy")} {Home_team} - {Away_team}, Score: {Home_score} - {Away_score}, Country: {Country}";
        }
    }
}
