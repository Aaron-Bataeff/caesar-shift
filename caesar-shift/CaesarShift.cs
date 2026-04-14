using System;

public class CaesarShift
{
    public static string Shift(string input, int shift)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char c = input[i];

            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';

                int shifted = ((c - offset + shift) % 26 + 26) % 26;

                result[i] = (char)(offset + shifted);
            }
            else
            {
                result[i] = c; // keep spaces, numbers, punctuation
            }
        }

        return new string(result);
    }
}