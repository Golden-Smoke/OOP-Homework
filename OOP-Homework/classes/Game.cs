using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework.classes
{
    class Game
    {
        private Team team1 { get; set; }
        private Team team2 { get; set; }
        public Referee referee { get; set; }
        public int Goals { get;private set; }

        public Game(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }
    }
}
