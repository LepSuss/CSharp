using System;

namespace ProgChallengeStart
{
    class Program
    {
        static void Main(string[] args)
        {
            // Choose a random number between 0 and 20
            int theNumber = new Random().Next(20);

            // Print the game greeting and instructions
            Console.WriteLine("Let's Play 'Guess the Number'!");
            Console.WriteLine("I'm thinking of a number between 0 and 20.");
            Console.WriteLine("Enter your guess, or -1 to give up.");

            // Keep track of the number of guesses and the current user guess
            int guessamount = 0;
            int realguess = 0;

            do {
                guessamount++;

                Console.WriteLine("What's your guess?");
                string guess = Console.ReadLine();
                try {
                    realguess = int.Parse(guess);
                } catch {
                    Console.WriteLine("Hmm that doesn't look like a number.");
                }
                if (realguess == -1) {
                    Console.WriteLine("Bye Bye!");
                    break;
                }
                if (realguess > 20 || realguess < 0) {
                    Console.WriteLine("Not a number between 0 and 20. Guess again!");
                    continue;
                } else {
                    if (realguess == theNumber){
                        Console.WriteLine($"You got it in {guessamount} guesses!!");
                        break;
                    }
                    if (realguess > theNumber) {
                        Console.WriteLine("Nope. Lower than that.");
                    }
                    if (realguess < theNumber) {
                        Console.WriteLine("Nope. Higher than that.");
                    }
                }
            }while(realguess != theNumber);

            // Start the game and run until user quits or guesses correctly
            // HINT: You'll need a way to convert the user's input to an integer
            
        }
    }
}
