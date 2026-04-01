using System;

class Program 
{
    static void Main(string[] args) 
    {
        SearchEngine searchEngine = new SearchEngine();
        User user = new User("Student Explorer");

        // Datos de ejemplo
        Address hotelAddr = new Address("123 Bark St", "Portland", "USA");
        Accommodation pawsHotel = new Accommodation("Paws Hotel", hotelAddr.GetFullAddress(), 4.5, 0, true);
        
        Address parkAddr = new Address("456 Green Way", "Seattle", "USA");
        Activity coolPark = new Activity("Central Pet Park", parkAddr.GetFullAddress(), 4.8, true);

        searchEngine.AddPlace(pawsHotel);
        searchEngine.AddPlace(coolPark);

        bool isRunning = true;
        while (isRunning) 
        {
            Console.WriteLine("\n--- 🐾 PET-FRIENDLY TRAVEL PLANNER ---");
            Console.WriteLine("1. View All Locations");
            Console.WriteLine("2. Add Paws Hotel to Favorites");
            Console.WriteLine("3. View Favorites");
            Console.WriteLine("4. Exit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1") 
            {
                foreach (Place p in searchEngine.GetAllPlaces()) 
                {
                    Console.WriteLine(p.GetDetails());
                    Console.WriteLine($"   Pet Score: {p.CalculatePetScore()}");
                }
            }
            else if (choice == "2") 
            {
                user.AddToFavorites(pawsHotel);
            }
            else if (choice == "3") 
            {
                user.DisplayFavorites();
            }
            else if (choice == "4") 
            {
                isRunning = false;
            }
            else 
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}