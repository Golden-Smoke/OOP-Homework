using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Homework.classes
{
    class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> players { get; set; }

        public Team() { this.players = new List<FootballPlayer>(); }
        public Team(Coach coach)
        {
            this.players = new List<FootballPlayer>();
            Coach = coach;
        }
        //public List<FootballPlayer> Players
        //{
        //    get { return players; }
        //    set
        //    {
        //        if(players.Count < 11 || players.Count > 22)
        //        {

        //        }
        //    }
        //}
        public double AverageAgeOfPlayers()
        {
            return Math.Round(players.Average(x => x.Age));
        }
    }
}
