using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Salary
{
    public class Program
    {
        /// <summary>
        /// Task: https://acm.timus.ru/problem.aspx?space=1&num=1123
        /// </summary>
        static void Main(string[] args)
        {
            var salary = Console.ReadLine();


            Console.WriteLine(SalaryToPalindrom(salary));

        }

        public static string SalaryToPalindrom(string salary)
        {
            var hightToLow = salary[salary.Length - 1] > salary[0];
            int z = salary.Length % 2 == 0 ? 1 : 2;


            var salaryAsStringBuilder = new StringBuilder(salary);

            salaryAsStringBuilder[salary.Length - 1] = salary[0];

            for (int i = 1, j = salary.Length - 2; i < j; i++, j--)
            {
                var x = Convert.ToInt32(salaryAsStringBuilder[i].ToString());
                var y = Convert.ToInt32(salaryAsStringBuilder[j].ToString());

                if (hightToLow && x > y)
                {
                    hightToLow = false;
                }

                if (hightToLow && j - i == z)
                {
                    if (z == 2)
                    {
                        var w = Convert.ToInt32(salaryAsStringBuilder[i++]);
                        w++;
                        salaryAsStringBuilder[i++] = w.ToString()[0];
                    }
                    else if (z == 1)
                    {
                        x++;
                        salaryAsStringBuilder[i] = x.ToString()[0];
                        salaryAsStringBuilder[j] = x.ToString()[0];
                        continue;
                    }

                }

                salaryAsStringBuilder[j] = salaryAsStringBuilder[i];
            }

            return salaryAsStringBuilder.ToString();
        }
    }
}