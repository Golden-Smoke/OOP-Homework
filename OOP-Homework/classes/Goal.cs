﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework.classes
{
    class Goal
    {
        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }

        public Goal(int minute,FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
