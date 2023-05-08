using System.Diagnostics;

namespace Order
{
    internal class Program
    {
        /// <summary>
        /// Task: https://acm.timus.ru/problem.aspx?space=1&num=1510
        /// </summary>
        static void Main(string[] args)
        {
            var numberList = new List<int>()
            {
                5,3,3,2,2,3,9,5,7,7,7,3,7,7,7,5,5
            };

            Debugger.Break();

            var mostCommonOne = numberList.GroupBy(x => x)
                .OrderByDescending(x => x.Count())
                .Select(x => x.Key)
                .First();

            Console.WriteLine(mostCommonOne);
        }
    }
}