using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("Please enter your grade: ");
        string gradeText = Console.ReadLine();
        int grade = int.Parse(gradeText);
        string letter;

        if (grade >= 90) 
        {
            letter = "A";
        }
        else if (grade >= 80) 
        {
            letter = "B";
        }
        else if (grade >= 70) 
        {
            letter = "C";
        }
        else if (grade >= 60) 
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string pass;
        if (grade >= 70)
        {
            pass = "Congratulations! You passed!";
        }
        else
        {
            pass = "Unfortunately, you did not pass.";
        }

        string sign;
        int lastDigit = grade % 10;
        if (lastDigit >= 7)
        {
            sign = "+";
        }
        else if (lastDigit < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        if (grade >= 93 || letter == "F")
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}.");
        Console.WriteLine(pass);
        Console.WriteLine();
    }
}