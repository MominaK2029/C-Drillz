using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive number: ");
        int number = int.Parse(Console.ReadLine());

        // TODO: Write a while loop that keeps asking for input 
        // as long as 'number' is less than or equal to 0.
        while (number <= 0)
        {
            Console.Write("Enter a positive number: ");
            number = int.Parse(Console.ReadLine());
        }

        Console.WriteLine($"Thank you! You entered: {number}");
    }
}
 

