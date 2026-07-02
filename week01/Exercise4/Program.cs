using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
       //saving numbers list
     List<int> numbers = new List<int>();
     Console.WriteLine ("Enter a list of numbers, type 0 when finished");
     int number = -1;
     
     while (number != 0)
        {
            Console.Write("Enter Number: ");
            number = int.Parse(Console.ReadLine());

            if (number != 0)
            {
                numbers.Add(number);
            }
        }

int sum = 0;
foreach(int num in numbers)
        {
            sum = sum + num;
        
        }
        //average

        double average = (double)sum / numbers.Count;

        int max = numbers[0];
        foreach(int num in numbers)
        {
            if (num > max)
            {
                max = num;
            }
        }
Console.WriteLine($"The sum is: {sum}");
Console.WriteLine($"The average is: {average}");
Console.WriteLine($"The largest number is: {max}");

int smallestPossitive = int.MaxValue;
foreach(int num in numbers)
        {
            if (num > 0 && num < smallestPossitive)
            {
                smallestPossitive = num;
            }
        }
if (smallestPossitive != int.MaxValue)
        {
            Console.WriteLine($"The smallest positive number is: {smallestPossitive}");
        }

numbers.Sort();
Console.WriteLine("Thesorted list is: ");
foreach(int num in numbers)
        {
            Console.WriteLine(num);
        }
    }
}
