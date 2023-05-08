using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj ciąg znaków: ");

            var x = Console.ReadLine();

            // Sposób 1:
            Console.WriteLine("Odwrócony ciąg znaków:\n{0}", ReverseString(x));
            Console.ReadLine();


            // Sposób 2:
            var y = x.ToCharArray();
            Array.Reverse(y);
            var x2 = new string(y);
            Console.WriteLine("Odwrócony ciąg znaków, sposob 2:\n{0}", x2);
            Console.ReadLine();

            // Sposób 3:
            var x3 = new string(x.Reverse().ToArray());
            Console.WriteLine("Odwrócony ciąg znaków, sposob 3:\n{0}", x3);

        }

        public static string ReverseString(string x)
        {
            var charArray = x.ToCharArray();

            for (int i = 0,  j = x.Length - 1; i < j; i++, j--)
            {
                charArray[i] = x[j];
                charArray[j] = x[i];
            }

            var reversedString = new string(charArray);
            return reversedString;
        }
    }
}
