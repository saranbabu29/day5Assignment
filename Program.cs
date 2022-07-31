using System;

namespace day5
{
    class Program1
    {
        static void Main(string[] args)
        {
            int year;
            int inpput;
            Console.WriteLine("Enter the Year : " );
            int input =int.Parse (Console.ReadLine());
            if ((input%4 == 0 && input%100 != 0) || input%400==0) ;
            {
                Console.WriteLine("The Given year is Leap Year");
            }
            else
            {
                Console.WriteLine("This is not a Leap Year");
            }
        }
    }
}