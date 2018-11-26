using System;
using System.Text;

namespace ClosestPalidrome
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a Number : ");
                string input = Console.ReadLine();


                Console.WriteLine("Closest palindrome : {0}", ClosestPalidromeAlgo(input));
            }
        }

        private static string ClosestPalidromeAlgo(string input)
        {
            char[] digits = input.ToCharArray();
            int halfway = (int)Math.Ceiling((double)digits.Length / 2);
            int index = 0;
            for (int i = digits.Length-1; i >=halfway; i--)
            {
                digits[i] = digits[index++];
            }
            return new string(digits);
        }
    }
}
