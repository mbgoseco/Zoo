using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class Tiger : Mammals
    {
        public override int AnimalCount { get; set; } = 3;
        public override bool LaysEggs { get; set; } = false;
        public override bool IsVenomous { get; set; } = false;
        public override bool GuestsCanFeed { get; set; } = false;
        public override string FurColor { get; set; } = "orange/white/black";

        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the tigers.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the tiger cage.";
        }

        public override string Speak()
        {
            return "Raaaaawr! Meow.";
        }
    }
}
