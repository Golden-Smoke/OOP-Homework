using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Homework.classes
{
    abstract class Person
    {
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public string Name { get; protected set; }
        public int Age { get; protected set; }
    }
}
