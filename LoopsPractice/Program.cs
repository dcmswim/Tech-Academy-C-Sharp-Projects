using System;

namespace LoopsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number!");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 20:
                        Console.WriteLine("Wrong! Hint: You are very close to the number! Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 1:
                        Console.WriteLine("Wrong! Hint: The number is higher than this. Try again");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    case 100:
                        Console.WriteLine("Wrong! Hint: The number is much lower than this.");
                        number = Convert.ToInt32(Console.ReadLine());

                        break;
                    case 21:
                        Console.WriteLine("You guessed 21, that is correct!");
                        isGuessed = true;
                        break;

                    case 22: 
                            Console.WriteLine("Wrong! Hint: you are very close to the number.");
                            number = Convert.ToInt32(Console.ReadLine());
                            break;

                    case > 100:
                        Console.WriteLine("Too high! The number is between 1 and 100");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                    default:
                        Console.WriteLine("Wrong number, guess again!");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;

                }
            }

            while (!isGuessed);
            
               
            
            Console.ReadLine();
        }
    }
}
