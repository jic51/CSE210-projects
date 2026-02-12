using System;
using System.Collections.Generic;

class Program
{
    
    static void Main(string[] args)
    {
        // 1. Creamos nuestra "Biblioteca" de escrituras
        List<Scripture> library = new List<Scripture>();

        // Agregamos unas cuantas para tener variedad
        library.Add(new Scripture(new Reference("John", 3, 16), "For God so loved the world that he gave his one and only Son"));
        library.Add(new Scripture(new Reference("Proverbs", 3, 5, 6), "Trust in the Lord with all your heart and lean not on your own understanding"));
        library.Add(new Scripture(new Reference("Philippians", 4, 13), "I can do all things through Christ who strengthens me"));

        // 2. Elegimos una al azar
        Random random = new Random();
        int randomIndex = random.Next(library.Count);
        Scripture selectedScripture = library[randomIndex];

        string input = "";

        // principle loop
        while (input.ToLower() != "quit" && !selectedScripture.IsCompletelyHidden())
        {
            Console.Clear(); // clean the console
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                selectedScripture.HideRandomWords(3); // Hide 3 words each time
            }
        }

        // message if all words are hidden
        if (selectedScripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(selectedScripture.GetDisplayText());
            Console.WriteLine("\n¡Felicidades! Has ocultado todas las palabras.");
        }
    }
}