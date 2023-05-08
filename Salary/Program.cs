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
            bool onlyNine = true;

            var salaryAsStringBuilder = new StringBuilder(salary);



            for (var i = 1; i <= salary.Length - 1; i++)
            {
                if (salary[i] != '9')
                    onlyNine = false;
            }

            if (hightToLow && onlyNine)
            {
                var x = Convert.ToInt32(salaryAsStringBuilder[0].ToString());
                x++;
                salaryAsStringBuilder[0] = x.ToString()[0];
                salaryAsStringBuilder[salary.Length - 1] = salaryAsStringBuilder[0];

                for (int i = 0, j = salary.Length - 1; i < j; i++, j--)
                {
                    if (j - i == z)
                    {
                        if (z == 2)
                        {
                            salaryAsStringBuilder[i += 1] = '0';
                            continue;
                        }
                        else if (z == 1)
                        {
                            salaryAsStringBuilder[i] = '0';
                            salaryAsStringBuilder[j] = '0';
                            continue;
                        }
                    }

                    if (i == 0)
                    {
                        salaryAsStringBuilder[i += 1] = '0';
                        salaryAsStringBuilder[j -= 1] = '0';
                        continue;
                    }
                    salaryAsStringBuilder[i] = '0';
                    salaryAsStringBuilder[j] = '0';
                }
            }
            else
            {
                salaryAsStringBuilder[salary.Length - 1] = salary[0];

                for (int i = 0, j = salary.Length - 1; i < j; i++, j--)
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
                            var w = Convert.ToInt32(salaryAsStringBuilder[i += 1].ToString());
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
            }

            return salaryAsStringBuilder.ToString();
        }
    }
}