namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**************");
            Console.WriteLine();
            Console.WriteLine("Menu: ");
            Console.WriteLine("1 - New Game");
            Console.WriteLine("2 - Load Game");
            Console.WriteLine("3 - Options");
            Console.WriteLine("4 - Quit");
            Console.WriteLine();
            Console.WriteLine("**************");
            Console.WriteLine();

            Console.Write("Please enter your choice (1 - 4): ");
            int option = Convert.ToInt32(Console.ReadLine());

            if (option == 1)
            {
                Console.WriteLine("Creating a new game...");
            } else if (option == 2)
            {
                Console.WriteLine("Loading the saved game...");
            } else if (option == 3)
            {
                Console.WriteLine("Opening the options menu...");
            } else if (option == 4)
            {
                Console.WriteLine("Quiting the game...");
            } else
            {
                Console.WriteLine("Error: Invalid option entered");
            }

            Console.WriteLine();
            Console.WriteLine("Thank you for playing");
            Console.WriteLine();
        }
    }
}