using System;

/* CREATIVITY RECORD:
1. Added logic to ReflectingActivity to ensure questions are not repeated 
   until all questions in the list have been used at least once in the session.
2. Implemented a file-based logging system (activity_log.txt) to track 
   and save the user's progress across different sessions.
*/

class Program
{
    static void Main(string[] args)
    {
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

            else if (choice == "2")
            {
                // Instanciamos y ejecutamos Reflexión
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.Run();
            }
            else if (choice == "3")
            {
                // Instanciamos y ejecutamos Listado
                ListingActivity listing = new ListingActivity();
                listing.Run();
            }
        }
    }

    static void LogActivity(string activityName)
    {
        string fileName = "activity_log.txt";
        string logEntry = $"{DateTime.Now}: Completed {activityName}\n";
        File.AppendAllText(fileName, logEntry);
    }

    static void ShowStats()
    {
        string fileName = "activity_log.txt";
        if (File.Exists(fileName))
        {
            string[] lines = File.ReadAllLines(fileName);
            Console.WriteLine($"\n--- Your Progress ---");
            Console.WriteLine($"Total activities completed: {lines.Length}");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }
    }
}