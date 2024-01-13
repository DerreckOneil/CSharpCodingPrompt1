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

        CountOccurances(randomString);

    }

    static void CountOccurances(string str)
    {

        char[] chars = str.ToCharArray();

        foreach (char c in chars)
        {
            Console.WriteLine("Occurances for char " + c + " is " + chars.Count(x => x == c));
        }



    }
}