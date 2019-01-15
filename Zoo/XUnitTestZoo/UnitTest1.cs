using System;
using Xunit;
using Zoo;
using Zoo.Classes;

namespace XUnitTestZoo
{
    public class UnitTest1
    {
        // Tiger tests
        [Fact]
        public void TigerCanSpeakAndEat()
        {
            Tiger tony = new Tiger();

            Assert.Equal("Raaaaawr! Meow.", tony.Speak());
            Assert.Equal("Employees are feeding the tigers.", tony.StaffFeedAnimal());
        }
        [Fact]
        public void TigerIsAHungryAnimal()
        {
            Tiger tony = new Tiger();

            Assert.Equal("The tigers are hungry! Feed them!", tony.Feed());
            Assert.IsAssignableFrom<Animals>(tony);
        }

        // Brown bear tests
        [Fact]
        public void BrownBearCanSpeakAndEatFromGuests()
        {
            BrownBear yogi = new BrownBear();

            Assert.Equal("RAR!", yogi.Speak());
            Assert.Equal("A guest is feeding the brown bears. They love it!", yogi.GuestFeedAnimal());
        }
        [Fact]
        public void BrownBearIsASwimmingAnimal()
        {
            BrownBear yogi = new BrownBear();

            Assert.Equal("I'm a brown bear and I can swim!", yogi.Swim());
            Assert.IsAssignableFrom<Animals>(yogi);
        }

        // Black bear tests
        [Fact]
        public void BlackBearCanSpeakAndEat()
        {
            BlackBear baloo = new BlackBear();

            Assert.Equal("RAR!", baloo.Speak());
            Assert.Equal("Employees are feeding the black bears.", baloo.StaffFeedAnimal());
        }
        [Fact]
        public void BlackBearIsAHungryAnimal()
        {
            BlackBear baloo = new BlackBear();

            Assert.Equal("The black bears are hungry! Feed them!", baloo.Feed());
            Assert.IsAssignableFrom<Animals>(baloo);
        }

        // Platypus tests
        [Fact]
        public void PlatypusCanSpeakAndIsVenomous()
        {
            Platypus abomination = new Platypus();

            Assert.Equal("Quack?", abomination.Speak());
            Assert.True(abomination.IsVenomous);
        }
        [Fact]
        public void PlatypusIsASwimmingAnimal()
        {
            Platypus abomination = new Platypus();

            Assert.Equal("I'm a platypus and I can swim!", abomination.Swim());
            Assert.IsAssignableFrom<Animals>(abomination);
        }

        // Gator tests
        [Fact]
        public void AlligatorCanSpeakAndEat()
        {
            Alligator seeYaLater = new Alligator();

            Assert.Equal("Rrrrrrrrrrrrrrrrr...", seeYaLater.Speak());
            Assert.Equal("Employees are feeding the alligators.", seeYaLater.StaffFeedAnimal());
        }
        [Fact]
        public void AlligatorIsASwimmingAnimal()
        {
            Alligator seeYaLater = new Alligator();

            Assert.Equal("I'm an alligator and I can swim!", seeYaLater.Swim());
            Assert.IsAssignableFrom<Animals>(seeYaLater);
        }

        // Sea Turtle tests
        [Fact]
        public void SeaTurtleEatsAndLivesInWater()
        {
            SeaTurtle timmy = new SeaTurtle();

            Assert.Equal("Employees are feeding the sea turtles.", timmy.StaffFeedAnimal());
            Assert.True(timmy.LivesInWater);
        }
        [Fact]
        public void SeaTurtleIsASwimmingAnimal()
        {
            SeaTurtle timmy = new SeaTurtle();

            Assert.Equal("I'm a sea turtle and I can swim!", timmy.Swim());
            Assert.IsAssignableFrom<Animals>(timmy);
        }

        // Box Turtle tests
        [Fact]
        public void BoxTurtleEatsAndIsColdBlooded()
        {
            BoxTurtle michaelangelo = new BoxTurtle();

            Assert.Equal("Employees are feeding the box turtles.", michaelangelo.StaffFeedAnimal());
            Assert.False(michaelangelo.IsWarmBlooded);
        }
        [Fact]
        public void BoxTurtleIsAHungryAnimal()
        {
            BoxTurtle michaelangelo = new BoxTurtle();

            Assert.Equal("The box turtles are hungry! Feed them!", michaelangelo.Feed());
            Assert.IsAssignableFrom<Animals>(michaelangelo);
        }

        // King Cobra tests
        [Fact]
        public void KingCobraSpeaksAndIsVenomous()
        {
            KingCobra commander = new KingCobra();

            Assert.Equal("Hssssssssssssssssssss.", commander.Speak());
            Assert.True(commander.IsVenomous);
        }
        [Fact]
        public void KingCobraIsAHungryAnimal()
        {
            KingCobra commander = new KingCobra();

            Assert.Equal("The cobras are hungry! Feed them!", commander.Feed());
            Assert.IsAssignableFrom<Animals>(commander);
        }
    }
}
