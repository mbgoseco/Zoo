using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    class BlackBear : Bear
    {
        public override int AnimalCount { get; set; } = 2;
        public override string FurColor { get; set; } = "black";

        public override string StaffFeedAnimal()
        {
            return "Employees are feeding the black bears.";
        }

        public override string CleanCage()
        {
            return "Employees are cleaning the black bear cage.";
        }

        public override string GuestFeedAnimal()
        {
            return "A guest is feeding the black bears. They love it!";
        }

        public override string BearHug()
        {
            return "BLACK BEAR HUG!!!";
        }
    }
}
