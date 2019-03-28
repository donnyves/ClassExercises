using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalculateAverages;

//This code has the incorrect output.  23JAN2019

namespace SumOdds
{
    public class SumOdds
    {
       

            public static int CollectSumOdds(int maxValue)
            {
                int sum = 0;

                if (maxValue > 0 && maxValue < 256)
                    for (int i = 0; i < 256; i++)

                        if (i % 2 == 1)
                        {
                            sum += i;
                        }
                return sum;
            }
            public static int CollectSumOdds(int minValue, int maxValue)
            {
                int sum = 0;

                if (maxValue > 0 && maxValue < 256)
                    for (int i = minValue; i < maxValue; i++)
                        if (i % 2 == 1)
                        {
                            sum += i;
                        }
                return sum;
            }
            public static void Main(string[] args)
            {
                Console.WriteLine("\n\tSum.Odds.Main()");

                CollectSumOdds(5);
                Console.WriteLine($"\tSumOfOdds: {CollectSumOdds(5)}");

               

                Console.ReadKey();
            }
        }
    }

