using System;

class Program
{
    static void Main(string[] args)
    {
        // Llamada a las funciones y almacenamiento de valores
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        
        // Uso de parámetro 'out' para obtener el año de nacimiento
        int birthYear;
        PromptUserBirthYear(out birthYear);

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, squaredNumber, birthYear);
    }

    // 1. Muestra un mensaje de bienvenida
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    // 2. Pide y devuelve el nombre del usuario
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    // 3. Pide y devuelve el número favorito como entero
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    // 4. Obtiene el año de nacimiento usando un parámetro 'out'
    static void PromptUserBirthYear(out int birthYear)
    {
        Console.Write("Please enter the year you were born: ");
        birthYear = int.Parse(Console.ReadLine());
    }

    // 5. Devuelve el cuadrado de un número
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    // 6. Muestra los resultados finales y calcula la edad
    static void DisplayResult(string name, int square, int birthYear)
    {
        int currentYear = DateTime.Now.Year; // Obtiene el año actual (2026)
        int age = currentYear - birthYear;

        Console.WriteLine($"{name}, the square of your number is {square}");
        Console.WriteLine($"{name}, you will turn {age} this year.");
    }
}