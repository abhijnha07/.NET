using System;

namespace ConsoleApp7
{
    class RegisterNum
    {
        int regno;
        static int startnum;
        static RegisterNum()
        {
            startnum = 2022000;
        }
        RegisterNum()
        {
            regno = ++startnum;
        }




        public static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                RegisterNum student = new RegisterNum();

                Console.WriteLine("Student {0}: {1}", i + 1, student.regno);
            }
        }
    }
}
