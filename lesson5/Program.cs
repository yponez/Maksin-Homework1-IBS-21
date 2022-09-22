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
            Console.WriteLine("enter a");
            string a = Console.ReadLine();
            Console.WriteLine("enter b");
            string b = Console.ReadLine();
            Console.WriteLine("enter c");
            string c = Console.ReadLine();
            double Da;
            double Db;
            double Dc;
            bool Resulta = double.TryParse(a, out Da);
            bool Resultb = double.TryParse(b, out Db);
            bool Resultc = double.TryParse(c, out Dc);
            double P = (Da + Db + Dc) / 2;
            if (Da <= 0 || !Resulta || Db <= 0 || !Resultb || Dc <= 0 || !Resultc)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                Console.WriteLine("S = " + Math.Sqrt(P * (P - Da) * (P - Db) * (P - Dc)));
            }
        }
    }
}