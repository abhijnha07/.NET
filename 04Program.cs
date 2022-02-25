using System;

namespace vs04
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, num;
            Console.WriteLine("Enter any number:");
            num = int.Parse(Console.ReadLine());
            for(i=1;i<=num;i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of " + num + "is:" + fact);
        }
    }
}
