using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OOP_Homework.classes
{
    class Team
    {
        public string TeamName { get; set; }
        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public Team(string teamName,Coach coach,List<FootballPlayer> players)
        {
            TeamName = teamName;
            this.Players = new List<FootballPlayer>();
            this.Players = players;
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
            return Math.Round(Players.Average(x => x.Age));
        }
    }
}
