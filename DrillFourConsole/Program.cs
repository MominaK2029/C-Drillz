using System;

class Program
{
    static void Main()
    {
        int secret = 7;
        int attemptsLeft = 3; 
        bool guessedCorrect = false;

        while (attemptsLeft > 0 || guessedCorrect == false)
        {
            Console.WriteLine("Guess a number 1-10!");
            Console.ReadLine(); 
            Console.WriteLine();
            Console.WriteLine("Guess Again!!!", attemptsLeft, "remaining.");
            attemptsLeft --;
        }
        if (guessedCorrect == true)
        {
            Console.WriteLine("Congrats!! You won!");
        }
        else
        {
            attemptsLeft = 0;
            Console.WriteLine();
        }

    }
}
