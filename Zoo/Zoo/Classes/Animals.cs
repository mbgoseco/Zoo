using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Animals
    {
        public abstract int MaxGuests { get; set; }
        public abstract int AnimalCount { get; set; }
        public abstract bool IsWarmBlooded { get; set; }
        public virtual bool LaysEggs { get; set; }
        public virtual bool IsVenomous { get; set; }
        public virtual string OpenHours { get; set; } = "9am - 8pm";

        public abstract string Speak();
        public abstract string CleanCage();

        public virtual string StaffFeedAnimal()
        {
            return "The employees are off to feed the animals.";
        }

    }
}
