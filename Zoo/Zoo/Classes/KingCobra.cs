using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class KingCobra : Reptiles
    {
        public override int AnimalCount { get; set; } = 3;
        public override bool LaysEggs { get; set; } = true;
        public override bool IsVenomous { get; set; } = true;
        public override bool LivesInWater { get; set; } = false;

        public override string CollectEggs()
        {
            return "Employees are collecting the cobra eggs.";
        }

        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the cobras some tasty rats.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the cobra cage.";
        }

        public override string Speak()
        {
            return "Hssssssssssssssssssss.";
        }
    }
}
