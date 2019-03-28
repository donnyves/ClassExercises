using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTri
{
    class AreaOfTri
    {
        static void testAOT()
        {
            int howMany = 5;
            //nested for loop
            for (int b = 0; b < howMany; b++)
            {
                for (int h = 0; h < howMany; h++)
                {
                    Console.Write("\t");
                    Console.Write($"base: {b}, hieght: {h} area:");
                    Console.WriteLine($"{AreaOfTriangle(b,h)}");
                }
            }
        }

        static double AreaOfTriangle (double b, double ht)
        {
            return b * ht / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n\tAreaofTri.Main()");
            testAOT();
            Console.ReadKey();

        }
    }
}
//Start with this method first: 
//static double AreaOfTriangle (double b, double ht)
