using System;


namespace s3ConsoleApp4
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
    int flagTail;
    public MarksDetails(string name, int age, string gender, int regno, string course, int semester, int[] marks) : base(name, gender, regno, course, semester)
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

   

