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
            Console.WriteLine("enter height");
            string a = Console.ReadLine();
            Console.WriteLine("enter width");
            string b = Console.ReadLine();
            double Da;
            double Db;
            bool Resulta = double.TryParse(a, out Da);
            bool Resultb = double.TryParse(b, out Db);
            if (Resulta && Resultb && Da>0 && Db>0){
                Console.WriteLine("rectangle area = " + Da*Db);
            }
            else
            {
                Console.WriteLine("Non-correct data");
            }




        }
    }
}
