using System;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number : ");
            string input = Console.ReadLine();

            int n1;
            Int32.TryParse(input, out n1);

            FindPrimeFactors(n1);
        }

        private static void FindPrimeFactors(int n1)
        {
            int largest = -1;

            while (n1 % 2 == 0)
            {
                Console.Write("2, ");
                n1 = n1 / 2;
                largest = 2;
            }

            int sqrt = (int)Math.Sqrt(n1);
            for (int i = 3; i <= sqrt; i = i + 2)
            {
                while (n1 % i == 0)
                {
                    Console.Write("{0}, ", i);
                    largest = i;
                    n1 = n1 / i;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Largest of them all = {0}", largest);


        }
    }
}
