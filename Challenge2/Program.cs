using System;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.Write("HEY BOO! Did I scare you? Anyway, hello hi! Picking numbers is fun! \n");

        // Call the Sum function and print the result
        int result = Sum(1, 5);
        Console.WriteLine($"The sum of 1 and 5 is: {result}");

        // Convert minutes to seconds
        int minutes = 5;
        int seconds = Convert(minutes);
        Console.WriteLine($"{minutes} minutes is equal to {seconds} seconds.");
    }

    // Function that takes two integers and returns their sum
    public static int Sum(int a, int b)
    {
        return a + b;
    }

    // Function that converts minutes to seconds
    public static int Convert(int minutes)
    {
        return minutes * 60;
    }
}
