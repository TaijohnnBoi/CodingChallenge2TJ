using System;

class Challenges
{
    public static void Main(string[] args)
    {
        Console.Write("Testing single function calls.\n");

        // Test the Sum function
        Console.WriteLine($"Testing Sum: Sum(1, 5) --> {Sum(1, 5)}");

        // Test Convert function
        Console.WriteLine($"Testing Convert: Convert(5) --> {Convert(5)}");

        // Test PlusOne function
        Console.WriteLine($"Testing PlusOne: PlusOne(3) --> {PlusOne(3)}");

        // Test CircuitPower function
        Console.WriteLine($"Testing CircuitPower: CircuitPower(230, 10) --> {CircuitPower(230, 10)}");

        // Test CalcAge function
        Console.WriteLine($"Testing CalcAge: CalcAge(65) --> {CalcAge(65)}");

        // Test triArea function
        Console.WriteLine($"Testing triArea: triArea(3, 2) --> {triArea(3, 2)}");

        // Test lessThanOrEqualToZero function
        Console.WriteLine($"Testing lessThanOrEqualToZero: lessThanOrEqualToZero(5) --> {lessThanOrEqualToZero(5)}");

        // Test lessThan100 function
        Console.WriteLine($"Testing lessThan100: lessThan100(22, 15) --> {lessThan100(22, 15)}");

        // Test IsEqual function
        Console.WriteLine($"Testing IsEqual: IsEqual(5, 6) --> {IsEqual(5, 6)}");
    }

    public static int Sum(int a, int b) => a + b;
    public static int Convert(int minutes) => minutes * 60;
    public static int PlusOne(int number) => number + 1;
    public static int CircuitPower(int voltage, int current) => voltage * current;
    public static int CalcAge(int years) => years * 365;
    public static double triArea(int baseLength, int height) => (baseLength * height) / 2.0;
    public static bool lessThanOrEqualToZero(int number) => number <= 0;
    public static bool lessThan100(int a, int b) => (a + b) < 100;
    public static bool IsEqual(int a, int b) => a == b;
}
