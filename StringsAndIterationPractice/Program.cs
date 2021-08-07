using System;
using System.Collections.Generic;
using System.Linq;

namespace StringsAndIterationPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////example of a situation that would cause an infinite loop
            ////if the bool is always true the loop will continue indefinitely
            //bool objectiveTruth = true;
            //while (objectiveTruth)
            //{
            //    Console.WriteLine("We are stuck in a loop, please end the program to cease my suffering");
            //    //without the below line of code changing bool to false, the loop will run forever
            //    objectiveTruth = false;
            //    Console.WriteLine("Thank you for adding an exit to this eternal loop.");
            //}


            // --------------- STRING ARRAY AND APPENDING  -------------- //
            string[] array1 = { "Your name is ", "I like the name ", "Have a good day, " };
            
            //initial console output
            Console.WriteLine("What is your name?");
            string response = Console.ReadLine();
            //adds user input to the end of each string in existing array1
            for (int i = 0; i < array1.Length; i++)
            {
                array1[i] = array1[i] + response;
            }
            //iterates through appended array and prints each result on new line
            for (int i = 0; i < array1.Length; i++)
            {
                Console.Write("\n" + array1[i]);
            }
            // --------------- END STRING ARRAY AND APPENDING  ------------- //

            // ---------------- INTEGER ARRAY COMPARISONS  ------------- //
            int[] dailyTemps = {54, 55, 75, 70, 68, 65, 82, 76, 79, 85, 93, 89 };
            Console.WriteLine("\nLet's check the weather forecast...");
            for (int i = 0; i < dailyTemps.Length; i++)
            {
                if (dailyTemps[i] > 80 )
                {
                    Console.WriteLine("\n" + dailyTemps[i] + " degrees? Sounds like a hot day!");
                }
                else if (dailyTemps[i] <= 55)
                {
                    Console.WriteLine("\n" + dailyTemps[i] + " degrees? Might be a bit chilly, remember to pack a sweater!");
                }
                else
                {
                    Console.WriteLine("\n" + dailyTemps[i] + " degrees? Sounds pretty comfortable!");
                }
            }
            // ------------------------ END INTEGER ARRAY COMPARISONS ------------------- //


            // ------------------- UNIQUE STRINGS SECTION ------------------------//
            List<string> favColors = new List<string>() { "red", "black", "blue", "green" };
            Console.WriteLine("\nCan you guess one of my favorite colors?");
            string guess = Console.ReadLine();
            bool isGuessed = false;
            
            foreach (string color in favColors)
            {   //if user input matches a string in the list favColors it will return a message 
                // and the string that matched
                if (color == guess)
                {
                    Console.WriteLine("You guessed one of my favorite colors! It was " + color);
                    isGuessed = true;
                    //defines and sets a variable as an integer at the index value of wherever 
                    //the match occurred during the iteration through the list
                    int index = favColors.IndexOf(color);
                    //I'm not sure this is needed since the previous if statement only will run if 
                    //there is a match in the list. If there was no match the IndexOf() returns -1 
                    if (index != -1)
                    {
                        Console.WriteLine("Index element {0} is found at index position {1}", color, index);
                    }
                    break;
                }
            }
            // if user input did not match any strings from favColors then the bool will still be false
            // this will display a message stating the input did not match any strings in the list
            if (isGuessed == false)
            {
                Console.WriteLine("Too bad, you didn't guess correctly.");
            }
            
            // ------------------ END UNIQUE STRINGS SECTION ------------------ //

            // ------------------ IDENTICAL STRINGS SECTION 1 ------------------- //


            List<string> studentNames = new List<string>() { "David", "Steve", "Bob", "David", "Ryan" };
            Console.WriteLine("Please input a name to check if there is a match in the database.");
            string responseName = Console.ReadLine();
            bool nameGuess = false;
            // for loop that iterates through each item in the list 
            for (int index = 0; index < studentNames.Count; index++)
            {   // value of name will change depending on which index is being checked
                string name = studentNames[index];
                // checks if user input matches existing string in list
                if (name == responseName)
                {
                    nameGuess = true;
                    if (index != -1)
                        Console.WriteLine("The name \"{0}\" had a match at index {1}", name, index);    
                }  
            }
            if (nameGuess == false)
            {
                Console.WriteLine("There were no matches for that name.");
            }
            else
{
                Console.WriteLine("There is at least 1 match with the following name: " + responseName);
            }

            // ------------------ END IDENTICAL STRINGS SECTION 1 ------------------- //


            // ------------------ IDENTICAL STRINGS SECTION 2 ------------------- //

            List<string> favFoods = new List<string>() { "pizza", "nachos", "icecream", "burger", "pizza", "pasta" };

            for (int i = 0; i < favFoods.Count; i++)
            {
                string food = favFoods[i];
                Console.WriteLine(food);
                //checks all items in list ahead of the current item being checked
                for (int j = i+1; j < favFoods.Count; j++)
                {
                    string checkMatch = favFoods[j];
                    //checks if any items in list match current item
                    if (checkMatch.Contains(food))
                    {
                        Console.WriteLine(checkMatch + " has appeared more than once on this list.");
                        
                    }
                }
            }
            Console.ReadLine();

            // ------------------ END IDENTICAL STRINGS SECTION 2 ------------------- //










            //foreach (string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //    bool b = favFoods.Any(food.Contains);
            //    if (b == true) {
            //        Console.WriteLine("The entry " + food + " appears at least once in this list.");
            //    }
            //}

        }
    }
}
