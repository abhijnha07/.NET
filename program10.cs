using System;

namespace ConsoleApp11
{
    class Sumofdiagonals
    {
        static void Main(string[] args)
        {
            int Maxrow, Maxcol, sum = 0;
            int[,] Matrix;
            Console.Write("\n-----SUM OF DIAGONAL OF A MATRIX-----\n");
            Console.WriteLine("Enter the number of rows:");
            Maxrow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of columns:");
            Maxcol = Convert.ToInt32(Console.ReadLine());
            if(Maxrow!=Maxcol)
            {
                Console.WriteLine("The dimensions entered are not of a square matrix");
                Console.WriteLine("Exiting the program");
                return;
            }
            Matrix = new int[Maxrow, Maxrow];
            for(int i=0;i<Maxrow;i++)
            {
                for(int j=0;j<Maxcol;j++)
                {
                    Console.WriteLine("Enter the {0},{1} th element of the matrix:", (i + 1), (j + 1));
                    Matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("The entered matrix is:");
            for(int i=0;i<Maxrow;i++)
            {
                for (int j = 0; j < Maxcol; j++)
                {
                    Console.Write(" " + Matrix[i, j]);
                    if(i==j)
                    {
                        sum += Matrix[i, j];

                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("The sum of diagonal is "+ sum); 
        }
    }
}
