using System;
using System.Collections.Generic;
using System.Text;

namespace Zoo.Classes
{
    public abstract class Mammals : Animals
    {
        public override int MaxGuests {get; set;} = 5000;
        public override bool IsWarmBlooded { get; set; } = true;
        public abstract bool GuestsCanFeed { get; set; }
        public abstract string FurColor { get; set; }

        public virtual string GuestFeedAnimal()
        {
            return "Guests are getting food to feed the animals.";
        }
    }
}
