using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the numbers of lines");
            string N = Console.ReadLine();
            int intN;
            bool Result = int.TryParse(N, out intN);
            if (intN <= 0 && !Result)
            {
                Console.WriteLine("Error");
            }
            else
            {
                int a = 1;
                for (int i = 0; i <= intN; i++)
                {
                    Console.WriteLine(new String(' ', (intN-i)) + new String('*', a) + new String(' ', intN-i));
                    a =a + 2;
                }
            }
        }
    }
}