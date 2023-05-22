using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace OOP_Homework.classes
{
    class Game
    {
        private Team Team1 { get; set; }
        private Team Team2 { get; set; }
        public List<Referee> Referees { get;private set; }
        public Team Winner { get;private set; }

        public Game(Team team1, Team team2,List<Referee> referees)
        {
            Team1 = team1;
            Team2 = team2;
            Referees = referees; 
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
            Greeting();
            while (true)
            {
                timer++;
                if(timer > 90) {
                    if(team1Goals.Count > team2Goals.Count)
                    {
                        Winner = Team1;
                    }
                    else if(team1Goals.Count < team2Goals.Count)
                    {
                        Winner = Team2;
                    }
                   break; 
                }

                if (isTeamOneTurn) AttackForScore(Team1, team1Goals);
                if (!isTeamOneTurn) AttackForScore(Team2, team2Goals);

                isTeamOneTurn = !isTeamOneTurn;
                Thread.Sleep(400);
            }
            GameResult();
        }
        void AttackForScore(Team team,List<Goal> teamGoals)
        {
            int randomPlayer = new Random().Next(0, team.Players.Count - 1);
            FootballPlayer scorePlayer = team.Players[randomPlayer];
            if (isScoredGoal(7))
            {
                Goal scoredGoal = new Goal(timer, scorePlayer);
                Console.WriteLine($"For {team.TeamName}, {scoredGoal.Player.Name} scored a goal at {scoredGoal.Minute} minute!");
                teamGoals.Add(scoredGoal);
            }
        }
        void Greeting()
        {
            Console.WriteLine($"Welcome everybody! Today we are going to witness a match between " +
                $"{Team1.TeamName} and {Team2.TeamName}.\n Coach of {Team1.TeamName} : {Team1.Coach.Name}" +
                $"\n Coach of {Team2.TeamName} : {Team2.Coach.Name} \n Referee : {Referees[0].Name} \n" +
                $" Side-Referee : {Referees[1].Name}");
            Console.WriteLine();
            Thread.Sleep(6000);
            Console.WriteLine("Let the match begin!");
            Console.WriteLine();
            Thread.Sleep(2000);
        }
        void GameResult()
        {
            Console.WriteLine();
            if(team1Goals.Count > team2Goals.Count)
            {
                Console.WriteLine($"The winner is {Team1.TeamName} with score {team1Goals.Count}:{team2Goals.Count}");
            }
            else if(team1Goals.Count < team2Goals.Count)
            {
                Console.WriteLine($"The winner is {Team2.TeamName} with score {team1Goals.Count}:{team2Goals.Count}");
            }
            else
            {
                Console.WriteLine($"This match was a tie! {team1Goals.Count}:{team2Goals.Count}");
            }
        }
    }
}
