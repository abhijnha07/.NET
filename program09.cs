using System;
using System.Diagnostics;

namespace ConsoleApp9
{
    class Bma
    {
        const int _max = 10000;
        static void Main(string[] args)
        {
            var Arr2d = new int[100, 100];
            var ArrJagged = new int[100][];
            for(int i=0; i<100; i++)
            {
                ArrJagged[i] = new int[100];

            }
            var stopwatch2d = Stopwatch.StartNew();
            for(int i=0;i<_max;i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        Arr2d[j, k] = k;
                    }
                }
            }
            stopwatch2d.Stop();
            var stopwatchjagged = Stopwatch.StartNew();
            for(int i=0;i<_max;i++)
            {
                for (int j = 0; j < 100; j++)
                {
                    for (int k = 0; k < 100; k++)
                    {
                        ArrJagged[j][k] = k;

                    }
                }
            }
            stopwatchjagged.Stop();
            Console.Write("\n Time taken gor allocation in case of 2d array:");
            Console.WriteLine(stopwatch2d.Elapsed.TotalMilliseconds + "milliseconds");
            Console.Write("\nTime taken for allocation in case of jagged array:");
            Console.WriteLine(stopwatchjagged.Elapsed.TotalMilliseconds + "milliseconds");
        }
    }
}
