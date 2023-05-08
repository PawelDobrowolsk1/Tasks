using System.Diagnostics;

namespace Order
{
    public class Program
    {
        /// <summary>
        /// Task: https://acm.timus.ru/problem.aspx?space=1&num=1510
        /// </summary>
        static void Main(string[] args)
        {
            var numbersList = new List<int>()
            {
                5,3,3,2,2,3,9,5,7,7,7,3,7,7,7,5,5,2,2,2,2
            };


            var mostCommonOne = MostCommonOne(numbersList);

            Console.WriteLine(mostCommonOne);
        }

        public static int MostCommonOne(IEnumerable<int> numbers)
        {
            return numbers.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key).First();
        }
    }
}