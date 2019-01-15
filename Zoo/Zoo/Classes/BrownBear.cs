using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public class BrownBear : Bear
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
    }
}
