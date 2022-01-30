using System;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            


            int userWrongGuess = 0;

            bool guessing = true;


            // calling my random class to predict random numbers

            Random computerGuess = new Random();

            int randomGuess;

            int min = 1;
            int max = 11;

    
           
            while (guessing)
            {

                randomGuess = computerGuess.Next(min, max);

                //collecting user guesses

                Console.WriteLine("Guess a number between 1-10: ");

                int userGuess = Convert.ToInt32(Console.ReadLine());


                if (userGuess == randomGuess)
                {
                    Console.WriteLine("Congratulations ! Correct Guess");
                    Console.WriteLine("");
                    Console.Write($"You guessed= {userGuess}\t");
                    Console.WriteLine($"The computer guessed = {randomGuess}");

                    break;

                }

                if (userGuess < randomGuess)
                {
                    Console.WriteLine($"Wrong! guess is too low");

                    Console.Write($"You guessed= {userGuess}\t");
                    Console.WriteLine($"The computer guessed = {randomGuess}");

                    userWrongGuess++;

                    continue;


                }


                if (userGuess > randomGuess)
                {
                    Console.WriteLine("Wrong ! Guess is too high");

                    Console.Write($"You guessed= {userGuess}\t");
                    Console.WriteLine($"The computer guessed = {randomGuess}");

                    userWrongGuess++;
                    continue;
                }


            }
            //end of while loop

            Console.WriteLine($"You guessed {userWrongGuess} times before making the right guess");

            Console.ReadKey();
        }
    }
}
