namespace WarGames2.Tests
{
    public class ProgramTests
    {
        [Theory]
        [InlineData("5","3", "31524")]
        [InlineData("5","2", "24153")]
        [InlineData("5","1", "12345")]
        [InlineData("10","7", "74213610589")]
        public void OrderOfLeavingSoldiers_ForGivenInputs_ReturnsExpectedValue(string n, string k, string expected)
        {
            //arrange 

            //act
            var result = Program.OrderOfLeavingSoldiers(n, k);
            //assert 

            Assert.Equal(expected, result);
        }
    }
}