public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What is your favorite thing about this experience?",
        "What did you learn about yourself through this experience?"
    };

    private List<string> _unusedQuestions;

    public ReflectingActivity() : base("Reflection Activity", 
        "This activity will help you reflect on times in your life when you have shown strength and resilience.")
    {
        _unusedQuestions = new List<string>(_questions);
    }

    public void Run()
    {
        DisplayStartingMessage();
        
        // Mostrar Prompt Aleatorio
        Random random = new Random();
        Console.WriteLine("\nConsider the following prompt:");
        Console.WriteLine($"--- {_prompts[random.Next(_prompts.Count)]} ---");
        Console.WriteLine("\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");
        ShowCountDown(5);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        Console.Clear();

        while (DateTime.Now < endTime)
        {
            string question = GetRandomQuestion();
            Console.Write($"\n> {question} ");
            ShowSpinner(5); // Pausa para reflexionar
        }

        DisplayEndingMessage();
    }

    private string GetRandomQuestion()
    {
        Random random = new Random();
        
        // Lógica de Creatividad: Reiniciar lista si se agotan las preguntas
        if (_unusedQuestions.Count == 0)
        {
            _unusedQuestions = new List<string>(_questions);
        }

        int index = random.Next(_unusedQuestions.Count);
        string question = _unusedQuestions[index];
        _unusedQuestions.RemoveAt(index); // Evita repetición inmediata
        
        return question;
    }
}