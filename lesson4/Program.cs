﻿using System;
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
            int summ=0;
            for(int i = 1; i < 1000; i++)
            {
                if((i%3==0) || (i % 5 == 0))
                {
                    summ = summ + i;
                }
            }
            Console.WriteLine("Summa = " + summ);
        }
    }
}