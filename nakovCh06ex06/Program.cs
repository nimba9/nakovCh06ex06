using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nakovCh06ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciSequence();

        }

        private static void FibonacciSequence()
        {
            Console.WriteLine("Please enter a positive number: ");
            string userInp = Console.ReadLine();

            ulong n = 0;
            bool check = ulong.TryParse(userInp, out n);

            if (check != true)
            {
                Console.WriteLine("Please enter a positive number!");
            }

            ulong firstNum = 1;
            ulong secondNum = 0;
            ulong thirdNum = 0;
            ulong sum = 0;

            for (ulong i = 1; i <= n; i++)
            {
                thirdNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = thirdNum;
                sum += thirdNum;
                Console.WriteLine(i + ":" + thirdNum);

            }

            Console.WriteLine("The sum is: {0}", sum);
        }
    }
}
