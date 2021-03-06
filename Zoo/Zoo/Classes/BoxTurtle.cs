﻿using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class BoxTurtle : Turtle, IFeed
    {
        public override int AnimalCount { get; set; } = 4;
        public override bool LivesInWater { get; set; } = false;

        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the box turtles.";
        }

        public override string CollectEggs()
        {
            return "Employees are collecting the box turtle eggs.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the box turtle cage.";
        }

        public override string Speak()
        {
            return "...";
        }

        public string Feed()
        {
            return "The box turtles are hungry! Feed them!";
        }
    }
}
