/*Write a program that, depending on the user’s choice, inputs an int, double or string variable.
If the variable is int or double, the program increases it by one.
If the variable is a string, the program appends * at the end.
Print the result at the console. Use switch statement.*/
using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.WriteLine("Enter 1 for int, 2 for double or 3 string:");
        int input = int.Parse(Console.ReadLine());

        switch (input)
        {
            case 1:
                int firstInput = int.Parse(Console.ReadLine());
                Console.WriteLine(firstInput + 1); break;
            case 2:
                double secondInput = double.Parse(Console.ReadLine());
                Console.WriteLine(secondInput + 1); break;
            case 3:
                string thirdInput = Console.ReadLine();
                Console.WriteLine(thirdInput + "*"); break;
        }
    }
}

