using System;

namespace ConsoleApp19<br>
{<br>
    class Program<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            Console.WriteLine("Hello World!");<br>
        }<br>
    }<br>
}<br>
<br>
![image](https://user-images.githubusercontent.com/97939934/154633081-3913abbe-ad9f-4c56-b4ec-e1228d00d574.png)

<br>
<br>


*1. C# Program to Print a Binary Triangle.*

using System;
namespace Exercises
{
 class BinaryTriangle
 {
 static void Main(string[] args)
 {
 int number,digit=1;
 Console.Write("\nEnter the number of lines: ");
 number = Convert.ToInt32(Console.ReadLine());
 for(int i=1; i<=number; i++)
 {
 for(int space=number-i; space>0; space--)
 {
 Console.Write(" ");
 }
 for(int j=0; j<i; j++)
 {
 Console.Write(digit + " ");
 digit = (digit==1) ? 0:1;
 }
 Console.Write("\n");
 }
 }
 }
}



*2. C# Program to Check Whether the Entered Number is an Amicable Number or Not*
