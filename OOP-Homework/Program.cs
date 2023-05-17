using OOP_Homework.classes;
using System;

namespace OOP_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach coach1 = new Coach("Igor",12);
            Team team1 = new Team(coach1);

            team1.players.Add(new FootballPlayer("Ivan",15,10,162));
            team1.players.Add(new FootballPlayer("Stoqn",25, 5, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 45, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 31, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 40, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 5, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 14, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 16, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 30, 162));
            team1.players.Add(new FootballPlayer("Ivan", 15, 20, 162));

            Console.WriteLine(team1.AverageAgeOfPlayers());
            Coach coach2 = new Coach("Petar", 45);
            Team team2 = new Team(coach2);

            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Stoqn", 25, 5, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
            team2.players.Add(new FootballPlayer("Ivan", 15, 10, 162));
        }
    }
}
