using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // 1. Inicializar el motor de búsqueda
        SearchEngine engine = new SearchEngine();
        User currentUser = new User("Student Explorer");

        // 2. Crear datos de prueba (Objetos)
        Address addr1 = new Address("123 Bark St", "Portland", "USA");
        Accommodation hotel = new Accommodation("Paws Hotel", addr1.GetFullAddress(), 4.5, 25.0, true);
        
        Address addr2 = new Address("456 Park Ave", "Seattle", "USA");
        Activity park = new Activity("Green Lake Park", addr2.GetFullAddress(), 5.0, true);

        engine.AddPlace(hotel);
        engine.AddPlace(park);

        // 3. Menú de Interacción
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n--- 🐾 PET-FRIENDLY TRAVEL PLANNER ---");
            Console.WriteLine("1. View All Locations");
            Console.WriteLine("2. Search by Type");
            Console.WriteLine("3. Add to Favorites");
            Console.WriteLine("4. View Favorites");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    foreach (var p in engine.GetAllPlaces()) Console.WriteLine(p.GetDetails());
                    break;
                case "2":
                    Console.WriteLine("Searching for Parks...");
                    var parks = engine.FilterByType<Activity>();
                    foreach (var p in parks) Console.WriteLine(p.GetDetails());
                    break;
                case "3":
                    currentUser.AddToFavorites(hotel);
                    break;
                case "4":
                    currentUser.DisplayFavorites();
                    break;
                case "5":
                    running = false;
                    break;
            }
        }
    }
}