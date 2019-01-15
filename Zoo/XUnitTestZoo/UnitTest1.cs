using System;
using Xunit;
using Zoo;
using Zoo.Classes;

namespace XUnitTestZoo
{
    public class UnitTest1
    {
        [Fact]
        public void TigerCanSpeakAndEat()
        {
            Tiger tony = new Tiger();

            Assert.Equal("Raaaaawr! Meow.", tony.Speak());
            Assert.Equal("Employees are feeding the tigers.", tony.StaffFeedAnimal());
        }
    }
}
