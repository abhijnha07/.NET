*To print HELLO WORLD*

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

using System;<br>
namespace s1ConsoleApp4<br>
{<br>
    class Program<br>
    {<br>
        static void Main(string[] args)<br>
        {<br>
            int number, digit = 1;<br>
            Console.WriteLine("\n Enter the number of lines:");<br>
            number = Convert.ToInt32(Console.ReadLine());<br>
            for (int i = 1; i <= number; i++)<br>
            {<br>
                for (int space = number - i; space > 0; space--)<br>
                {<br>
                    Console.Write(" ");<br>
                }<br>
                for (int j = 0; j < i; j++)<br>
                {<br>
                    Console.Write(digit + " ");<br>
                    digit = (digit == 1) ? 0 : 1;<br>
                }<br>
                Console.Write("\n");<br>
                }<br>
           }<br>
     }<br>
}<br>


![image](https://user-images.githubusercontent.com/97939934/154634943-0f7284eb-6994-456f-8af8-98e7c1077583.png)


           


*2. C# Program to Check Whether the Entered Number is an Amicable Number or Not*

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
            for (int i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum2 += i;
                }
            }
            if (sum1 == num2 && sum2 == num1)
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

![image](https://user-images.githubusercontent.com/97939934/154636980-d2ac751d-ae68-4d47-ad99-a6ebfff27d34.png)





*3. C# Program to Illustrate Multilevel Inheritance with Virtual Methods (displaying student details).*

using System;

namespace Program4
{
    class PersonalDetails
    {
        string name;
        int age;
        string gender;
        public PersonalDetails(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }
        public virtual void Display()
        {
            Console.WriteLine("\n-----------Personal Details-----------");
            Console.WriteLine("Name         :" + name);
            Console.WriteLine("Age          :" + age);
            Console.WriteLine("Gender       :" + gender);
        }
    }
    class CourseDetails : PersonalDetails
    {
        int regno;
        string course;
        int semester;
        public CourseDetails(string name, int age, string gender, int regno, string course, int semester) : base(name, age, gender)
        {
            this.regno = regno;
            this.course = course;
            this.semester = semester;
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("\n -----------Course Details-----------\n");
            Console.WriteLine("Register Number          :" + regno);
            Console.WriteLine("Course                   :" + course);
            Console.WriteLine("Semester                 :" + semester);
        }
    }
    class MarksDetails : CourseDetails
    {
        int[] marks = new int[5];
        int total;
        float average;
        string grade;
        int flagFail;
        public MarksDetails(string name, int age, string gender, int regno, string course, int semester, int[] marks) : base(name,age, gender, regno, course, semester)
        {
            total = 0;
            for (int i = 0; i < 5; i++)
            {
                this.marks[i] = marks[i];
                total += marks[i];
                if (marks[i] < 35)
                {
                    flagFail = 1;
                }
            }
            Calculate();
        }
        private void Calculate()
        {
            average = total / 5;
            if (flagFail == 1 || average < 40)
                grade = "Fail";
            else if (average >= 70)
                grade = "Distinction";
            else if (average >= 60)
                grade = "First Class";
            else if (average >= 50)
                grade = "Second Class";
            else
                grade = "Pass Class";
        }
        public override void Display()
        {
            base.Display();
            Console.WriteLine("/n-----------Marks Details-----------/n");
            Console.Write("Marks in 5 subjects:");
            for (int i = 0; i < 5; i++)
            {
                Console.Write(marks[i] + " ");
                Console.WriteLine();
                Console.WriteLine("total            :" + total);
                Console.WriteLine("Average          :" + average);
                Console.WriteLine("Grade            :" + grade);
            }
        }
        class Multilevel
        {
            public static void Main(string[] args)
            {
                MarksDetails Student1 = new MarksDetails("Jay", 22, "male", 2022888, "MCs", 5, new int[] { 88, 97, 86, 89, 93 });
                Student1.Display();
            }
        }
    }
}







