using Xunit;

namespace ModulusCalculator.Tests
{
    public class Tests
    {
        [Fact]
        public void Mod10Test()
        {
            Assert.Equal(6, Mod10.GetControlNumber("234567"));
            Assert.Equal(9, Mod10.GetControlNumber("020130096"));
            Assert.Equal("2345676", Mod10.Calculate("234567"));
            Assert.Equal("0201300969", Mod10.Calculate("020130096"));
        }

        [Fact]
        public void Mod11Test()
        {
            Assert.Equal(6, Mod11.GetControlNumber("234567"));
            Assert.Equal(7, Mod11.GetControlNumber("020130096"));
            Assert.Equal("2345676", Mod11.Calculate("234567"));
            Assert.Equal("0201300967", Mod11.Calculate("020130096"));
        }
    }
}
