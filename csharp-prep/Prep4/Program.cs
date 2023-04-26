using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("\nEnter a list of numbers, type 0 when finished.");
        Console.Write("Enter number: ");
        string numInput = Console.ReadLine();
        int num = int.Parse(numInput);

        while (num != 0)
        {
            numbers.Add(num);

            Console.Write("Enter number: ");
            numInput = Console.ReadLine();
            num = int.Parse(numInput);
        }

        int sum = numbers.Sum();

        double average = numbers.Average();

        int largest = 0;
        foreach (int number in numbers)
        {
            if (number > largest)
            {
                largest = number;
            }
        }
        
        int smallestPositive = 999999;
        foreach (int number in numbers)
        {
            if (number > 0 && number < smallestPositive)
            {
                smallestPositive = number;
            }
        }

        List<int> sorted = numbers;
        sorted.Sort();


        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largeset number is: {largest}");
        Console.WriteLine($"The smallest positive number is: {smallestPositive}");
        Console.WriteLine("The sorted list is:");
        for (int i = 0; i < sorted.Count; i++)
        {
            Console.WriteLine(sorted[i]);
        }
    }
}