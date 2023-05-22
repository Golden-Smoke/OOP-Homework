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
                new Striker("Stoqn",20,12,165),
                new Striker("Pesho",20,12,165),
                new Striker("Stilqn",20,12,165),
                new Midfield("Igor",20,12,165),
                new Midfield("Minko",20,12,165),
                new Midfield("Pavel",20,12,165),
                new Midfield("Miroslav",20,12,165),
                new Defender("Dobri",20,12,165),
                new Defender("Velin",20,12,165),
                new Defender("Vasil",20,12,165),
                new Goalkeeper("Stamat",20,12,165)
            });

            Team team2 = new Team("Vallhala",new Coach("Vladimir", 40), new List<FootballPlayer> {
                new Striker("Gencho",20,12,165),
                new Striker("Pesho",20,12,165),
                new Striker("Gosho",20,12,165),
                new Midfield("Igor",20,12,165),
                new Midfield("Plamen",20,12,165),
                new Midfield("Iliq",20,12,165),
                new Midfield("Miroslav",20,12,165),
                new Defender("Pancho",20,12,165),
                new Defender("Bojidar",20,12,165),
                new Defender("Vasil",20,12,165),
                new Goalkeeper("Stamat",20,12,165)
            });
            List<Referee> referees = new List<Referee>
            {
                new Referee("Blagoi",30),
                new Referee("Samuil",30)
            };
            Game game = new Game(team1,team2,referees);
            game.Match();
             
        }
    }
}
