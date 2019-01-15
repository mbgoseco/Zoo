using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class Alligator : Reptiles, IFeed, ISwim
    {
        public override int AnimalCount { get; set; } = 6;
        public override bool LaysEggs { get; set; } = true;
        public override bool IsVenomous { get; set; } = false;
        public override bool LivesInWater { get; set; } = true;

        public override string CollectEggs()
        {
            return "Employees are collecting the alligator eggs.";
        }

        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the alligators.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the aliigator cage.";
        }

        public override string Speak()
        {
            return "Rrrrrrrrrrrrrrrrr...";
        }

        public string Feed()
        {
            return "The alligators are hungry! Feed them!";
        }

        public string Swim()
        {
            return "I'm an alligator and I can swim!";
        }
    }
}
