using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    abstract public class Animals
    {
        abstract public int MaxGuests { get; set; }
        abstract public int AnimalCount { get; set; }
        abstract public bool IsWarmBlooded { get; set; }
        virtual public bool LaysEggs { get; set; }
        virtual public bool IsVenomous { get; set; }
        virtual public string OpenHours { get; set; } = "9am - 8pm";

        abstract public string Speak();
        abstract public string CleanCage();

        virtual public string StaffFeedAnimal()
        {
            return "The employees are off to feed the animals.";
        }

    }
}
