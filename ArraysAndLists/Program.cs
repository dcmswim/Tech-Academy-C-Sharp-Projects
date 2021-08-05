using System;
using System.Collections.Generic;


class Program
{
    static void Main()
    {


        string[] stringArray1 = { "Hello there!", "Howdy.", "Hey." };
        Console.WriteLine("Please select your greeting. Enter 0, 1 or 2 for a message.");
        int response1 = Convert.ToInt32(Console.ReadLine());
        if (response1 > 2)
        {
            Console.WriteLine("Invalid Response, please follow instructions next time. Goodbye.");
        }
        else
        {
            Console.WriteLine(stringArray1[response1]);
        }

        int[] intArray1 = { 7, 25, 553, 234, 1, 567, 1 };
        Console.WriteLine("Please enter a number between 0-6");
        int response2 = Convert.ToInt32(Console.ReadLine());
        if (response2 > 6)
        {
            Console.WriteLine("Invalid response. Please follow the instructions next time. Goodbye.");
        }
        else
        {
            Console.WriteLine("The value contained in the array at that position is " + intArray1[response1]);
        }

        List<string> stringList = new List<string> { "Goodbye", "See ya!", "Good riddance!", "Until next time." };
        Console.WriteLine("Select your farewell message. Please input a number between 0-3");
        int response3 = Convert.ToInt32(Console.ReadLine());
        if (response3 > 3)
        {
            Console.WriteLine("Invalid response. Please follow the instructions next time.");
        }
        else
        {
            Console.WriteLine(stringList[response3]);
            Console.ReadLine();
        }

        
        
        
        //List<int> intList = new List<int>();
        //intList.Add(4);
        //intList.Add(5);
        //intList.Add(6);
        //intList.Remove(6);

        //Console.WriteLine(intList[0]);
        //Console.ReadLine();


        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        ////easier was to instantiate an array 
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };

        ////even easier way to instantiate an array
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };

        ////edit existing array value
        //numArray2[5] = 650;


        
    }
}

