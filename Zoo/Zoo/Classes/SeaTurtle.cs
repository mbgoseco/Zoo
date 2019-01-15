using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class SeaTurtle : Turtle
    {
        public override int AnimalCount { get; set; } = 5;
        public override bool LivesInWater { get; set; } = true;

        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the sea turtles.";
        }

        public override string CollectEggs()
        {
            return "Employees are collecting the sea turtle eggs.";
        }

        public override string ChangeWater()
        {
            return "Employees are changing the water in the sea turtle tank.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the sea turtle tank.";
        }

        public override string Speak()
        {
            return "...*gurgle*.";
        }
    }
}
