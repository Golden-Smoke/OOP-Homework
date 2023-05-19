using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOP_Homework.classes
{
    class Game
    {
        private Team team1 { get; set; }
        private Team team2 { get; set; }
        public Referee referee { get; set; }
        public Team Winner { get;private set; }

        public Game(Team team1, Team team2)
        {
            this.team1 = team1;
            this.team2 = team2;
        }

        bool isTeamOneTurn = true;
        int timer = 0;
        List<Goal> team1Goals = new List<Goal>();
        List<Goal> team2Goals = new List<Goal>();

        bool isScoredGoal(int value)
        {
            int randomNum = new Random().Next(0, 100);
            if(randomNum <= value)
            {
                return true;
            }
            return false;
        }
        public void Match()
        {
            while (true)
            {
                timer++;
                if(timer > 90) {
                    if(team1Goals.Count > team2Goals.Count)
                    {
                        Winner = team1;
                    }
                    else if(team1Goals.Count < team2Goals.Count)
                    {
                        Winner = team2;
                    }
                   break; 
                }

                if (isTeamOneTurn)
                {
                    int randomPlayer = new Random().Next(0,team1.Players.Count - 1);
                    FootballPlayer scorePlayer = team1.Players[randomPlayer];
                    if (isScoredGoal(20))
                    {
                        Goal scoredGoal = new Goal(timer,scorePlayer);
                        Console.WriteLine($"For {team1.TeamName},{scoredGoal.Player.Name} scored a goal at {scoredGoal.Minute} minute!");
                        team1Goals.Add(scoredGoal);
                    }
                }

                if (!isTeamOneTurn)
                {
                    int randomPlayer = new Random().Next(0, team2.Players.Count - 1);
                    FootballPlayer scorePlayer = team2.Players[randomPlayer];
                    if (isScoredGoal(20))
                    {
                        Goal scoredGoal = new Goal(timer, scorePlayer);
                        Console.WriteLine($"For {team2.TeamName},{scoredGoal.Player.Name} scored a goal at {scoredGoal.Minute} minute!");
                        team2Goals.Add(scoredGoal);
                    }
                    
                }
                isTeamOneTurn = !isTeamOneTurn;
                Thread.Sleep(400);
            }
            GameResult();
        }

        void Greeting()
        {
            Console.WriteLine("Welcome everybody! Today we are going to witness a match between");
        }
        void GameResult()
        {
            if(team1Goals.Count > team2Goals.Count)
            {
                Console.WriteLine($"The winner is {team1.TeamName} with score {team1Goals.Count}:{team2Goals.Count}");
            }
            else if(team1Goals.Count < team2Goals.Count)
            {
                Console.WriteLine($"The winner is {team2.TeamName} with score {team1Goals.Count}:{team2Goals.Count}");
            }
            else
            {
                Console.WriteLine($"This match was a tie! {team1Goals.Count}:{team2Goals.Count}");
            }
        }
    }
}
