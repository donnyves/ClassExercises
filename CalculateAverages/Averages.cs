using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverages
{
    class Averages
    {
        static  double TestAverages(double A, double B, double C)
        {
            int i = 3;
            double sum;

            sum = A + B + C;
            return sum / i;

        }
        static void Main(string[] args)
        {
            

            double Avg;
            Console.WriteLine("\n\tAverages.Main()");
            Avg = TestAverages(90.0, 95.0, 85.0);
            Console.WriteLine($"\t{Avg}");
            Console.ReadKey();
        }


    }
}
//"\n\tAverages.Main()" well let you know what project your working on.
//