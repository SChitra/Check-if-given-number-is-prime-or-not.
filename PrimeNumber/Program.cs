using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    //To check if a given number is prime
    class Program
    {
        static void Main(string[] args)
        {
            //int n = 25;
            int n = 31;
            int isPrime = IsPrime(n);
            if(isPrime == -1)
                Console.WriteLine("The given number {0} is not a Prime number",n);
            else
                Console.WriteLine("The given number {0} is a Prime number",n);

        }

        public static int IsPrime(int n)
        {
            if (n == 0 || n == 1)
            {
                return -1;
            }
            else
            {
                for(int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if((n%i) == 0)
                    {
                        return -1;
                    }
                 }
                return 1;

            }
            

        }
    }
}
