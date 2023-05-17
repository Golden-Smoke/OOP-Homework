using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework.classes
{
    class FootballPlayer : Person
    {
        public FootballPlayer(string name,int age,int number,int height) : base(name,age)
        {
            Number = number;
            Height = height;
        }
        public int Number { get;protected set; }
        public int Height { get;protected set; }
    }
}
