using System;

class Program
{
    static void Main(string[] args)
    {
        // Creatividad: Se implementó un sistema de menú robusto que no termina hasta que el usuario lo decide.
        string choice = "";
        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine(" 1. Start breathing activity");
            Console.WriteLine(" 2. Start reflecting activity");
            Console.WriteLine(" 3. Start listing activity");
            Console.WriteLine(" 4. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.Run();
            }
            // Aquí instanciarías las otras clases (ReflectingActivity y ListingActivity)
        }
    }
}