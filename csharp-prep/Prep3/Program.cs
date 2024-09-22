using System;

class Program
{
    static void Main(string[] args)
    {  // First part
      //Console.Write("What is your magic number? ");
      //int response = int.Parse(Console.ReadLine());

        // Second part
        Random randomGenerator = new Random();
        int theNumber = randomGenerator.Next(1, 10);
    

        int guess = -1;

        while (guess != theNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (theNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (theNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }

        }                    
    }
}