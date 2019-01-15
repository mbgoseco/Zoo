using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class Platypus : Mammals
    {
        public override int AnimalCount { get; set; } = 2;
        public override bool LaysEggs { get; set; } = true;
        public override bool IsVenomous { get; set; } = true;
        public override bool GuestsCanFeed { get; set; } = false;
        public override string FurColor { get; set; } = "brown";
        
        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the platypi.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the platypus cage.";
        }

        public override string Speak()
        {
            return "Quack?";
        }
    }

}
