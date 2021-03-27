using System;

namespace MinAndAverage
{
    class Program
    {
        static int findMin(int[] vs)
        {
            int min = int.MaxValue;

            for (int i = 0; i < vs.Length; i++)
            {
                if (vs[i] < min)
                {
                    min = vs[i];
                }
            }

            return min;
        }

        static int findAvg(int[] vs)
        {
            int avg;
            int total = 0;

            for (int i = 0; i < vs.Length; i++)
            {
                total += vs[i];
            }

            avg = total / vs.Length;

            return avg;
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();
            const int MAX_VALUE = 999;
            int[] vs = new int[3];
            int min;
            float avg;


            for (int i = 0; i < vs.Length; i++)
            {
                vs[i] = rnd.Next(maxValue: MAX_VALUE);
            }

            min = findMin(vs);
            avg = findAvg(vs);

            Console.WriteLine("The minimum value is: " + min);
            Console.WriteLine("The average value is: " + avg);
        }
    }
}
