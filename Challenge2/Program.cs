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

        // Call the PlusOne function and print the result
        int number = 3;
        int incrementedValue = PlusOne(number);
        Console.WriteLine($"PlusOne({number}) --> {incrementedValue}");

        // Call the CircuitPower function and print the result
        int voltage = 230;
        int current = 10;
        int power = CircuitPower(voltage, current);
        Console.WriteLine($"CircuitPower({voltage}, {current}) --> {power}");

        // Call the CalcAge function and print the result
        int ageInYears = 65;
        int ageInDays = CalcAge(ageInYears);
        Console.WriteLine($"CalcAge({ageInYears}) --> {ageInDays}");

        // Call the triArea function and print the result
        int baseLength = 3;
        int height = 2;
        double area = triArea(baseLength, height);
        Console.WriteLine($"triArea({baseLength}, {height}) --> {area}");

        // Call the lessThanOrEqualToZero function and print the result
        int testNumber = 5;
        bool isLessThanOrEqualToZero = lessThanOrEqualToZero(testNumber);
        Console.WriteLine($"lessThanOrEqualToZero({testNumber}) --> {isLessThanOrEqualToZero}");

        // Call the lessThan100 function and print the result
        int num1 = 22;
        int num2 = 15;
        bool isSumLessThan100 = lessThan100(num1, num2);
        Console.WriteLine($"lessThan100({num1}, {num2}) --> {isSumLessThan100}");

        // Call the IsEqual function and print the results
        int a = 5;
        int b = 6;
        bool areEqual1 = IsEqual(a, b);
        Console.WriteLine($"IsEqual({a}, {b}) --> {areEqual1}");

        a = 1;
        b = 1;
        bool areEqual2 = IsEqual(a, b);
        Console.WriteLine($"IsEqual({a}, {b}) --> {areEqual2}");
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

    // Function that increments a number by +1 and returns the result
    public static int PlusOne(int number)
    {
        return number + 1;
    }

    // Function that calculates power from voltage and current
    public static int CircuitPower(int voltage, int current)
    {
        return voltage * current;
    }

    // Function that calculates age in days from age in years
    public static int CalcAge(int years)
    {
        return years * 365;
    }

    // Function that calculates the area of a triangle
    public static double triArea(int baseLength, int height)
    {
        return (baseLength * height) / 2.0;
    }

    // Function that checks if a number is less than or equal to zero
    public static bool lessThanOrEqualToZero(int number)
    {
        return number <= 0;
    }

    // Function that checks if the sum of two numbers is less than 100
    public static bool lessThan100(int a, int b)
    {
        return (a + b) < 100;
    }

    // Function that checks if two integers are equal
    public static bool IsEqual(int a, int b)
    {
        return a == b;
    }
}
