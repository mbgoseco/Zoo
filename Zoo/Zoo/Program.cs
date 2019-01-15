using System;
using Zoo.Classes;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Brown bear instance
            BrownBear yogi = new BrownBear();
            yogi.AnimalCount++;
            Console.WriteLine(yogi.Speak());
            Console.WriteLine($"There are {yogi.AnimalCount} brown bears in the Zoo.");
            Console.WriteLine($"Is the brown bear a warm blooded animal? {yogi.IsWarmBlooded}");
            Console.WriteLine(yogi.BearHug());
            Console.WriteLine(yogi.GuestFeedAnimal());

            // Tiger instance
        }
    }
}
