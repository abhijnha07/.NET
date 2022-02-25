using System;

namespace s2ConsoleApp4
{
    class Program2
    {
        static void Main(string[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0;
            Console.WriteLine("\n-----------AMICABLE NUMBERS-----------\n");
            Console.Write("\n Enter the first number:");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter the second number:");
            num2 = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sum1 += i;
                }

            }
            for(int i=1; i<num2; i++)
            {
                if(num2%i==0)
                {
                    sum2 += i;

                }
            }
            if(sum1==num2 && sum2==num1)
            {
                Console.WriteLine("\n The number {0} and {1} are amicable:", num1, num2);
            }
            else
            {
                Console.WriteLine("\n The numbers {0} and {1} are not amicable:", num1, num2);
            }
        }
    }
}
