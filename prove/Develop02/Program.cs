// For the creativity part, I included a _mood a ttribute to capture user emotion, and implemented File.Exists() for better loading.


class Program
{
    static void Main(string[] args)
    {
        Journal theJournal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        bool running = true;

        Console.WriteLine("Welcome to the Journal Program!");

        while (running)
        {
            Console.WriteLine("\nPlease select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // 1: Get an random prompt
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine($"\n{prompt}");
                    Console.Write("> ");
                    string response = Console.ReadLine();

                    // IMPROVE: ask for mood
                    Console.Write("How are you feeling today (1-10)? ");
                    string mood = Console.ReadLine();

                    // 2: Create a new Entry
                    Entry newEntry = new Entry();
                    newEntry._date = DateTime.Now.ToShortDateString();
                    newEntry._promptText = prompt;
                    newEntry._entryText = response;
                    newEntry._mood = mood;

                    // 3: save the entry to the journal
                    theJournal.AddEntry(newEntry);
                    break;

                case "2":
                    theJournal.DisplayAll();
                    break;

                case "3":
                    Console.Write("What is the filename? ");
                    string loadFile = Console.ReadLine();
                    if (File.Exists(loadFile))
                    {
                        theJournal.LoadFromFile(loadFile);
                    }
                    else
                    {
                        Console.WriteLine("File not found.");
                    }
                    break;

                case "4":
                    Console.Write("What is the filename? ");
                    string saveFile = Console.ReadLine();
                    theJournal.SaveToFile(saveFile);
                    break;

                case "5":
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid option, try again.");
                    break;
            }
        }
    }
}