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
            Console.WriteLine("Enter first number");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second number");
            string b = Console.ReadLine();
            byte Ba;
            byte Bb;
            bool Resulta = byte.TryParse(a, out Ba);
            bool Resultb = byte.TryParse(b, out Bb);
            if(!Resulta || !Resultb)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine("and = " + (Ba & Bb));
                Console.WriteLine("or = " + (Ba | Bb));
                Console.WriteLine("xor = " + (Ba ^ Bb));
            }

        }
    }
}