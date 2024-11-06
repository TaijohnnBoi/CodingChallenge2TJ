using System;

class Challenges
{
    public static void Main(string[] args)
    {
        // Existing code...

        // Example call to the new function
        Console.Write("Enter a number to check if it's less than or equal to zero: ");
        int numberToCheck = GetValidInteger();
        bool result = IsLessThanOrEqualToZero(numberToCheck);
        Console.WriteLine($"Is {numberToCheck} less than or equal to zero? {result}");

        // Continue with the rest of the program...
    }

    // New function to check if a number is less than or equal to zero
    public static bool IsLessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }

    // Existing methods...

    public static (int, int) GetTwoNumbers(string prompt1 = "Enter the first number: ", string prompt2 = "Enter the second number: ")
    {
        Console.Write(prompt1);
        int number1 = GetValidInteger();

        Console.Write(prompt2);
        int number2 = GetValidInteger();

        return (number1, number2);
    }

    public static int GetValidInteger()
    {
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out int result))
            {
                return result;
            }
            else
            {
                Console.Write("Invalid input. Please enter a valid integer: ");
            }
        }
    }

    public static int Sum(int number1, int number2) => number1 + number2;

    public static int Convert(int minutes) => minutes * 60;

    public static int PlusOne(int number) => number + 1;

    public static int CircuitPower(int voltage, int current) => voltage * current;

    public static int CalcAge(int ageInYears) => ageInYears * 365;

    public static double TriArea(int baseLength, int height) => (baseLength * height) / 2.0;
}
