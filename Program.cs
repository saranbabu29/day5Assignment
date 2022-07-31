using System;

namespace day5
{
    class Program1
    {
        static void Main(string[] args)
        {
            int headcount = 0;
            int tailcount = 0;
            int count = 6;

            int temp = count;
            Random r = new Random();
            while (count != 0)
            {
                double random = r.NextDouble();
                if (random <= 0.5)
                {
                    headcount = headcount + 1;
                }
                else
                {
                    tailcount++;
                }

                count = count - 1;

            }
            Console.WriteLine(headcount * 100 / temp);
            Console.WriteLine(tailcount * 100 / temp);

        }
    }
}