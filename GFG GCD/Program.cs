using System;
using System.Collections;

/// <summary>
/// https://www.geeksforgeeks.org/practice-for-cracking-any-coding-interview/#math
/// </summary>
namespace GFG_GCD
{
    class Program
    {
        delegate void Del(int n1, int n2);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Del handler = new Del(PrintAlgoGCD);
            for (int i = 0; i < 3; i++)
            {
                DoOnceAlgo(handler);
            }

            handler = new Del(PrintAlgoLCM);
            for (int i = 0; i < 3; i++)
            {
                DoOnceAlgo(handler);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        private static void DoOnceAlgo(Del ptr)
        {
            Console.WriteLine("Enter A number ");

            int n1 = Convert.ToInt32(Console.ReadLine());
 
            Console.WriteLine("Enter A number ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            ptr(n1, n2);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        private static int FindGCD(int n1, int n2)
        {
            int gcd=1;
            int bounds = n1 < n2 ? n1 : n2;

            if (n1 <= n2 / 2)
                bounds = n1;
            else if (n2 <= n1 / 2)
                bounds = n2;

            for (int i = bounds; i > 0; i--)
            {
                int rem1 = n1 % i;
                int rem2 = n2 % i;

                if (rem1 == 0 && rem2 == 0 && rem1 == rem2)
                {
                    if (gcd < i)
                        gcd = i;
                }
            }
            return gcd;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void PrintAlgoGCD(int n1, int n2)
        {
            int gcd = FindGCD(n1, n2);

            Console.WriteLine("GCD of {0} and {1} is {2}", n1, n2, gcd);

        }

        private static int FindLCM(int n1, int n2)
        {
            int lcm = 1;
            int max = Math.Max(n1, n2);
            int min = Math.Min(n1, n2);
            ArrayList multiplierMin = new ArrayList();
            ArrayList multiplierMax = new ArrayList();
            for (int i = 1; i <= min; i++)
            {
                multiplierMax.Add(max * i);
            }
            for (int i = 1; i <= max; i++)
            {
                multiplierMin.Add(min * i);
            }
            foreach (int prod in multiplierMax)
            {
                if (multiplierMin.Contains(prod))
                {
                    lcm = prod;
                    break;
                }
            }

            return lcm;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void PrintAlgoLCM(int n1, int n2)
        {
            int lcm = FindLCM(n1, n2);
            Console.WriteLine("LCM of {0} and {1} is {2}", n1, n2, lcm);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        private static void PrintAlgoLCMImproved(int n1, int n2)
        {
            int gcd = FindGCD(n1, n2);
            int lcm = (n1 * n2) / gcd;

            Console.WriteLine("LCM of {0} and {1} is {2}", n1, n2, lcm);

        }
    }

}
