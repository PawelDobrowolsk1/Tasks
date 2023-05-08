using FluentAssertions;

namespace Salary.Tests
{
    public class ProgramTests
    {

        [Theory]
        [InlineData("123","131")]
        [InlineData("1","1")]
        [InlineData("1234","1331")]
        [InlineData("12","22")]
        [InlineData("199","202")]
        [InlineData("399","404")]
        [InlineData("3999","4004")]
        [InlineData("12341321", "12344321")]
        [InlineData("99992111", "99999999")]
        [InlineData("19999999", "20000002")]
        [InlineData("49999999", "50000005")]
        [InlineData("99999999", "99999999")]
        [InlineData("999959999", "999959999")]
        [InlineData("999995999", "999999999")]
        public void SalaryToPalindrome_GetSalary_ReturnSalaryAsPalindrome(string salary, string expected)
        {
            //arrange

            //act
            var result = Program.SalaryToPalindrom(salary);

            //assert
            result.Should().Be(expected);
        }
    }
}