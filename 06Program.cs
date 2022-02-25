using System;

namespace vs06
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0, m;
            Console.WriteLine("Enter the number:");
            n = int.Parse(Console.ReadLine());
            while(n>0)
            {
                m = n % 10;
                sum = sum + m;
                n = n / 10;
            }
            Console.WriteLine("Sum is=" + sum);
        }
    }
}
