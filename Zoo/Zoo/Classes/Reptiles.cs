using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Reptiles : Animals
    {
        public override int MaxGuests { get; set; } = 4000;
        public override string OpenHours { get; set; } = "9am - 6pm";
        public override bool IsWarmBlooded { get; set; } = false;

        public abstract bool LivesInWater { get; set; }

        public virtual string ChangeWater()
        {
            return "Employees are preparing to change the water in the reptile tanks.";
        }
        public abstract string CollectEggs();
    }
}
