using System;

namespace vs03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            temp = n;
            while(n>0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine("Number is a Palindrome");
            else
                Console.WriteLine("Number is not a Palindrome");
        }
    }
}
