using System;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter a Number : ");
                string input = Console.ReadLine();

                int n1;
                Int32.TryParse(input, out n1);

                Console.WriteLine("{0} Factorial: {1}", n1, FindFactorial(n1));


                Console.WriteLine("Enter a Perm/com Number : ");
                input = Console.ReadLine();

                int r;
                Int32.TryParse(input, out r);
                if (n1 >= r && n1 > 0 && r > 0)
                {
                    Console.WriteLine("{0},{1} nPr: {2}", n1, r, NPR(n1, r));
                    Console.WriteLine("{0},{1} nCr: {2}", n1, r, NCR(n1, r));
                }
            }

        }

        private static int NPR(int n1, int r)
        {
            int npr = FindFactorial(n1) / FindFactorial(n1-r);
            return npr;
        }

        private static int NCR(int n1, int r)
        {
            int ncr = FindFactorial(n1) / (FindFactorial(r) * FindFactorial(n1 - r));
            return ncr;
        }

        private static int FindFactorial(int n1)
        {
            int fact = 1;

            for(int i=n1; i>1; i--)
            {
                fact = fact * i;
            }

            return fact;
        }
    }
}
