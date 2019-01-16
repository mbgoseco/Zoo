using System;
using Zoo.Classes;
using Zoo.Interfaces;

namespace Zoo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Brown bear instance
            BrownBear yogi = new BrownBear();
            yogi.AnimalCount++;
            Console.WriteLine($"{yogi.Speak()} I'm a brown bear!");
            Console.WriteLine($"There are {yogi.AnimalCount} brown bears in the Zoo.");
            Console.WriteLine($"Is the brown bear a warm blooded animal? {yogi.IsWarmBlooded}");
            Console.WriteLine(yogi.BearHug());
            Console.WriteLine(yogi.GuestFeedAnimal());

            Console.WriteLine();

            // Tiger instance
            Tiger tony = new Tiger();
            Console.WriteLine(tony.Feed());
            Console.WriteLine(tony.StaffFeedAnimal());
            Console.WriteLine(tony.Swim());

            Console.WriteLine();

            // Black bear instance
            BlackBear baloo = new BlackBear();
            Console.WriteLine($"{baloo.Speak()} I'm a black bear!");
            Console.WriteLine(baloo.Swim());

            Console.WriteLine();

            // Platypus instance
            Platypus abomination = new Platypus();
            Console.WriteLine($"I'm a platypus! Am I venomous? {abomination.IsVenomous}");
            Console.WriteLine(abomination.Feed());

            Console.WriteLine();

            // Alligator instance
            Alligator seeYaLater = new Alligator();
            Console.WriteLine($"There are {seeYaLater.AnimalCount} alligators in the zoo.");
            Console.WriteLine($"Do gators lay eggs? {seeYaLater.LaysEggs}");
            Console.WriteLine(seeYaLater.Feed());

            Console.WriteLine();

            // Sea Turtle instance
            SeaTurtle timmy = new SeaTurtle();
            Console.WriteLine($"I'm a sea turtle! Do I lay eggs? {timmy.LaysEggs}");
            Console.WriteLine(timmy.Swim());

            Console.WriteLine();

            // Box Turtle instance
            BoxTurtle michaelangelo = new BoxTurtle();
            Console.WriteLine($"I'm a box turtle! Can I swim? {michaelangelo.LivesInWater}");
            Console.WriteLine(michaelangelo.Feed());

            Console.WriteLine();

            // King Cobra instance
            KingCobra commander = new KingCobra();
            Console.WriteLine($"I'm a king cobra! Am I venomous? {commander.IsVenomous}");
            Console.WriteLine($"Do I lay eggs? {commander.LaysEggs}");
            Console.WriteLine(commander.Feed());
        }
    }
}
