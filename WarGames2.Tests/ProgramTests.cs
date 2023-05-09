namespace WarGames2.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("5","3", "31524")]
        public void OrderOfLeavingSoldiers(string n, string k, string expected)
        {
            //arrange 

            //act
            var result = Program.OrderOfLeavingSoldiers(n, k);
            //assert 

            Assert.Equal(expected, result);
        }
    }
}