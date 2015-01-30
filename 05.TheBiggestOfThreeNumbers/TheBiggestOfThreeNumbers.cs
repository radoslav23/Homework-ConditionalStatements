/*Write a program that finds the biggest of three numbers.*/
using System;

class TheBiggestOfThreeNumbers
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        if (a == b && a == c)
        {
            Console.WriteLine("Numbers are equal!");
        }
        else
        {
            if (a >= b && a >= c)
            {
                Console.WriteLine(a);
            }
            else if (b >= a && b >= c)
            {
                Console.WriteLine(b);
            }
            else 
            {
                Console.WriteLine(c);
            }
        }
    }
}

