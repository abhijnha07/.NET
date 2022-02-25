using System;

namespace vs07
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, rev = 0, rem;
            Console.WriteLine("Enter a number");
            n = int.Parse(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed number:" + rev);
        }
    }
}
