using System;

class Program
{
    static void Main()
    {
        int secret = 7;
        int attemptsLeft = 3; 
        bool guessedCorrect = false;
        Console.WriteLine("Guess a number 1-10!");
        Console.ReadLine(); 
        while (attemptsLeft > 0 || guessedCorrect == false)
        {
            Console.WriteLine();
            Console.WriteLine("Guess Again!!!", attemptsLeft, "remaining.");
            attemptsLeft --;
        }
        if (attemptsLeft == 0);
        {
            Console.WriteLine("Oh. You ran out of attempts");
        }


    }
}
