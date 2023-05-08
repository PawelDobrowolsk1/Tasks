using FluentAssertions;
using Microsoft.VisualStudio.TestPlatform.TestHost;

namespace Order.Tests
{
    public class ProgramTests
    {
        public static IEnumerable<object[]> GetNumbersLists()
        {
            yield return new object[]
            {
                new List<int>()
                {
                    1,2,3,4,4,4,5,1,1,1
                }, 
                1
            };

            yield return new object[]
            {
                new List<int>()
                {
                    5,3,3,2,2,3,9,5,7,
                },
                3
            };

            yield return new object[]
            {
                new List<int>()
                {
                    5,3,3,2,2,3,9,5,7,7,7,3,7,7,7,5,5,2,2,2,2
                },
                2
            };
        }

        [Theory]
        [MemberData(nameof(GetNumbersLists))]
        public void MostCommonOne_ForGivenNumbers_ReturnsMostCommonOne(IEnumerable<int> numbersList, int expectedValue)
        {
            //arrange

            //act
            var result = Program.MostCommonOne(numbersList);
            //assert
            result.Should().Be(expectedValue);
        }
    }
}