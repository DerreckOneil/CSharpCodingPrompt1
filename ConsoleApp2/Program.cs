using System;

public class Program
{

    /*
    Create a function that takes a string. Count the occurrence of each character in the string.
    The user should be able to input their own string and see the results after the user hits submit.
    Ex. “DigitalCM” - Character “D” has occurred 1 time, Character “i” has occurred 2 times, etc.
    */

    static void Main()
    {
        Console.WriteLine("Enter A string");
        string randomString = Console.ReadLine();

        CountOccurrences(randomString);

    }

    static void CountOccurrences(string str)
    {

        foreach (char c in str)
        {
            Console.WriteLine("Occurrences for char " + c + " is " + str.Count(x => x == c));
        }



    }
}