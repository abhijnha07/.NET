using System;

namespace project5
{
    class GrayCode
    {
        static int getGray(int n)
        {
            return n ^ (n >> 1);


        }
        static void Main(string[] args)
        {
            int inputnum, graynum;
            Console.Write("\n Enter the decimal number: ");
            inputnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n Binary equivalent of {0} : {1}", inputnum, Convert.ToString(inputnum, 2));
            graynum = getGray(inputnum);
            Console.WriteLine("\n Gray code equivalent of {0} : {1}", inputnum, Convert.ToString(graynum, 2));
        }

    }
}