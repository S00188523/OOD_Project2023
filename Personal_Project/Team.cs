using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Project
{
    public class Team
    {
        public string Position { get; set; }
        public string Name { get; set; }
        public string Played { get; set; }
        public string Winned { get; set; }
        public string Tie { get; set; }
        public string Loosed { get; set; }
        public string Points { get; set; }


        public string SquadLogo { get; set; }
        public List<Standings> Standings { get; set; }

        public Team()
        {
            Standings = new List<Standings>();
        }

        public void CalculateStats()
        {
         
           
            
            //int nPlayed = Standings.Sum(s => Convert.ToInt32(s.Played));
            //Won = Standings.Sum(s => s.Won);
            //Drawn = Standings.Sum(s => s.Drawn);
            //Lost = Standings.Sum(s => s.Lost);
            //Points = Standings.Sum(s => s.Points);
        }
    }



}
