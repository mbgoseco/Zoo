using System;
using System.Collections.Generic;
using System.Text;
using Zoo.Interfaces;

namespace Zoo.Classes
{
    public class BrownBear : Bear, IFeed, ISwim
    {
        public override int AnimalCount { get; set; } = 2;
        public override string FurColor { get; set; } = "brown";

        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the brown bears.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the brown bear cage.";
        }

        public override string GuestFeedAnimal()
        {
            return "A guest is feeding the brown bears. They love it!";
        }

        public override string BearHug()
        {
            return "BROWN BEAR HUG!!!";
        }

        public string Feed()
        {
            return "The brown bears are hungry! Feed them!";
        }

        public string Swim()
        {
            return "I'm a brown bear and I can swim!";
        }
    }
}
