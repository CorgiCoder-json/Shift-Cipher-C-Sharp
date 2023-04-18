using System;

namespace Shift_Cipher
{
    class Program
    {
        public static void Main(string[] args)
        {
            string shiftedAlphabet = "", finalStr = "", alphabet = "abcdefghijklmnopqrstuvwxyz";
            Console.Write("Enter a string to be shifted: ");
            string input = Console.ReadLine();
            Console.Write("Enter an amount to shift the string between 1 and 25 inclusive: ");
            string shiftS = Console.ReadLine();
            int shift = Convert.ToInt32(shiftS);
            shiftedAlphabet += alphabet.Substring(shift) + alphabet.Substring(0, shift);
            input = input.ToLower();
            for(int i = 0; i < input.Length; i++)
            {
                if (input.Substring(i, 1).Equals(" "))
                {
                    finalStr += " ";
                    continue;
                }
                for(int j = 0; j < alphabet.Length; j++)
                {
                    if (input.Substring(i, 1).Equals(alphabet.Substring(j, 1)))
                        finalStr += shiftedAlphabet.Substring(j, 1);
                }
            }
            Console.WriteLine("Shifted String: " + finalStr);

        }
    }
}
