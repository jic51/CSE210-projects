using System;

class Program
{
    
    static void Main(string[] args)
    {
        // 1. Preparamos la referencia y la escritura
        Reference reference = new Reference("Juan", 3, 16);
        string text = "Porque de tal manera amo Dios al mundo que ha dado a su Hijo unigenito";
        Scripture scripture = new Scripture(reference, text);

        string input = "";

        // 2. El bucle principal: se repite hasta que escriban 'quit' o todo esté oculto
        while (input.ToLower() != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear(); // Limpia la pantalla para que parezca una app real
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPresiona Enter para ocultar palabras o escribe 'quit' para salir.");
            
            input = Console.ReadLine();

            if (input.ToLower() != "quit")
            {
                scripture.HideRandomWords(3); // Oculta 3 palabras al azar cada vez
            }
        }

        // Mensaje final si completó la memorización
        if (scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\n¡Felicidades! Has ocultado todas las palabras.");
        }
    }
}