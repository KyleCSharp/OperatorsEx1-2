using System;

namespace Operators2._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ex1
            int a = 17;
            int b = 4;

            int quotient = a / b;
            int remainder = a % b;

            if (a == 17 && b == 4) ;

            Console.WriteLine($"{a}/{b}={quotient}");
            Console.WriteLine($"and the is remainder {remainder}");


            //ex 2
            Console.WriteLine("What is the radis of your circle?");
            var radius = double.Parse(Console.ReadLine());
            var AreaCircle = AreaOfCircle(radius);
            Console.WriteLine($"The area of your circle of {radius} is {AreaCircle}");

        }
        public static double AreaOfCircle(double radius)
        {


            return Math.PI * (radius * radius);

        }

    }
}
