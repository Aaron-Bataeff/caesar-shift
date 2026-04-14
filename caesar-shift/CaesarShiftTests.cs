using System;

public class CaesarShiftTests
{
    public static void RunTests()
    {
        Console.WriteLine("Running totally serious and professional tests...\n");

        Test("abc", 1, "bcd");
        Test("xyz", 1, "yza"); // wrap around check
        Test("hello", 1, "ifmmp");
        Test("i love cats", 2, "k nqxg ecvu");
        Test("bruh", 13, "oehu");
        Test("zzz", 1, "aaa");
        Test("why is this due at 11:59", 1, "xiz jt uijt evf bu 11:59");
        Test("HELLO!!!", 1, "IFMMP!!!");

        Console.WriteLine("\nTests completed (hopefully).");
    }

    private static void Test(string input, int shift, string expected)
    {
        string result = CaesarShift.Shift(input, shift);

        if (result == expected)
        {
            Console.WriteLine($"PASS: {input} -> {expected}");
        }
        else
        {
            Console.WriteLine($"FAIL: {input} -> Expected {expected}, got {result}");
        }
    }
}