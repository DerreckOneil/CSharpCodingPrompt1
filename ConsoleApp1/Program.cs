using System;

public class Program
{

    /*
    Create a function that takes a string. The function must return the given string in reverse order. 
    The Reverse method from the Array class is not allowed to be used. Comment: if reverse was available this would've been over in two seconds. 
    */


    static void Main()
    {
        Console.WriteLine("Enter A string");
        string randomString = Console.ReadLine();

        Console.WriteLine("Soluton = " + PassInAString(randomString));
    }

    static string PassInAString(string str)
    {
        char[] chars = str.ToCharArray();
        string solution = "";

        for(int i = chars.Length-1; i >= 0; i-- )
        {
            solution += chars[i];
        }

        return solution;
    }
}