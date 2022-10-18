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
            Console.WriteLine("enter the first side");
            string a = Console.ReadLine();
            Double Da;
            bool Resulta = double.TryParse(a, out Da);
            if (!Resulta || Da <= 0)
            {
                Console.WriteLine("first side is false");
                return;
            }
            Console.WriteLine("enter the second side");
            string b = Console.ReadLine();
            double Db;
            bool Resultb = double.TryParse(b, out Db);
            if (!Resultb || Db <= 0)
            {
                Console.WriteLine("second side is false");
                return;
            }
            Console.WriteLine("enter the third side");
            string c = Console.ReadLine();
            double Dc;
            bool Resultc = double.TryParse(c, out Dc);
            if (!Resultc || Dc <= 0)
            {
                Console.WriteLine("third side is false");
                return;
            }
            if ((Da + Db) > Dc || (Db + Dc) > Da || (Dc + Da) > Db)
            {
                Console.WriteLine("the tringle does not exist");
                return;
            }
            {
                double P = (Da + Db + Dc) / 2;
                Console.WriteLine("S = " + Math.Sqrt(P * (P - Da) * (P - Db) * (P - Dc)));
            }
        }
    }
}