namespace WarGames2
{
    public class Program
    {
        /// <summary>
        /// Task: https://acm.timus.ru/problem.aspx?space=1&num=1521
        /// </summary>
        static void Main(string[] args)
        {
            var n = Console.ReadLine();
            var k = Console.ReadLine();

            var orderLeavingSoldiers = OrderOfLeavingSoldiers(n, k);

            Console.WriteLine(orderLeavingSoldiers);
        }

        public static string OrderOfLeavingSoldiers(string n, string k)
        {
            int N = int.Parse(n);
            int K = int.Parse(k);
            int x = K - 1;

            var soldiersLine = new List<int>();
            var soliderLeavingList = new List<string>();

            for (int i = 1; i <= N; i++)
            {
                soldiersLine.Add(i);
            }

            while (soldiersLine.Count > 0)
            {
                soliderLeavingList.Add(soldiersLine[x].ToString());
                soldiersLine.RemoveAt(x);
                x = x - 1;
                if (x < 0)
                {
                    x = soldiersLine.Count - 1;
                }
                for (int j = K; j > 0; j--)
                {
                    x++;

                    if (x > soldiersLine.Count - 1 || soldiersLine.Count - 1 == 0)
                    {
                        x = 0;
                    }
                }
            }

            return string.Join("", soliderLeavingList);
        }
    }
}