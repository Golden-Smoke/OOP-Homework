using OOP_Homework.classes;
using System;
using System.Collections.Generic;

namespace OOP_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team1 = new Team("Botev-Plovdiv",new Coach("Ivan",50),new List<FootballPlayer> { 
                new FootballPlayer("Stoqn",20,12,165),
                new FootballPlayer("Pesho",20,12,165),
                new FootballPlayer("Stilqn",20,12,165),
                new FootballPlayer("Igor",20,12,165),
                new FootballPlayer("Minko",20,12,165),
                new FootballPlayer("Pavel",20,12,165),
                new FootballPlayer("Miroslav",20,12,165),
                new FootballPlayer("Dobri",20,12,165),
                new FootballPlayer("Velin",20,12,165),
                new FootballPlayer("Vasil",20,12,165),
                new FootballPlayer("Stamat",20,12,165)
            });

            Team team2 = new Team("Vallhala",new Coach("Vladimir", 40), new List<FootballPlayer> {
                new FootballPlayer("Gencho",20,12,165),
                new FootballPlayer("Pesho",20,12,165),
                new FootballPlayer("Gosho",20,12,165),
                new FootballPlayer("Igor",20,12,165),
                new FootballPlayer("Plamen",20,12,165),
                new FootballPlayer("Iliq",20,12,165),
                new FootballPlayer("Miroslav",20,12,165),
                new FootballPlayer("Pancho",20,12,165),
                new FootballPlayer("Bojidar",20,12,165),
                new FootballPlayer("Vasil",20,12,165),
                new FootballPlayer("Stamat",20,12,165)
            });

            Game game = new Game(team1,team2);
            game.Match();
            //for (int i = 1; i <= 2; i++)
            //{
            //    for (int j = 1; j < 12; j++)
            //    {
            //        Console.WriteLine($"Enter {j} - player from Team {i} (name,age,number and height)");
            //        string[] player = Console.ReadLine().Split(',');
            //        string playerName = player[0];
            //        int playerAge = int.Parse(player[1]);
            //        int playerNumber = int.Parse(player[2]);
            //        int playerHeight = int.Parse(player[3]);
            //        FootballPlayer footballPlayer = new FootballPlayer(playerName, playerAge, playerNumber, playerHeight);
            //        if(i == 1)
            //        {
            //            team1.players.Add(footballPlayer);
            //        }
            //        else
            //        {
            //            team2.players.Add(footballPlayer);
            //        }
            //    }
            //}

            //foreach (var item in team1.players)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age + " " + item.Number + " " + item.Height);
            //    Console.WriteLine();
            //}
            //foreach (var item in team2.players)
            //{
            //    Console.WriteLine(item.Name + " " + item.Age + " " + item.Number + " " + item.Height);
            //    Console.WriteLine();
            //}

        }
    }
}
