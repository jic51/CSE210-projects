using System;

class Program
{
    static void Main(string[] args)
    {
        // 1.
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // 2.
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());      // inherited
        Console.WriteLine(a2.GetHomeworkList()); // owned

        // 3.
        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());           // Inherited method
        Console.WriteLine(a3.GetWritingInformation()); // owned method
    }
}