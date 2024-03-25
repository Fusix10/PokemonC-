using System;

class MenuFight
{
    public void ShowMenuFight()
    {
        bool quitGameFight = false;

        while (!quitGameFight)
        {
            Console.Clear(); // To clear the screen on each menu iteration

            Console.WriteLine("\r\n  _____      _                                        _____ _                   \r\n |  __ \\    | |                                      / ____| |                  \r\n | |__) |__ | | _____ _ __ ___   ___  _ __   __  __ | |    | |__   ___  ___ ___ \r\n |  ___/ _ \\| |/ / _ \\ '_ ` _ \\ / _ \\| '_ \\  \\ \\/ / | |    | '_ \\ / _ \\/ __/ __|\r\n | |  | (_) |   <  __/ | | | | | (_) | | | |  >  <  | |____| | | |  __/\\__ \\__ \\\r\n |_|   \\___/|_|\\_\\___|_| |_| |_|\\___/|_| |_| /_/\\_\\  \\_____|_| |_|\\___||___/___/\r\n                                                                                \r\n                                                                                \r\n");
            Console.WriteLine("=== Fight Menu ===");
            Console.WriteLine("1. Move");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Bag");
            Console.WriteLine("4. Run Away");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Clear(); // Clear the screen to display the sub-menu
                    Console.WriteLine("=== Choose the Pokémon to move ===");
                    Console.WriteLine("1. Pikachu");
                    Console.WriteLine("2. Bulbasaur");
                    Console.WriteLine("3. Charmander");
                    Console.WriteLine("4. Squirtle");
                    Console.Write("Your choice: ");

                    string pokemonChoice = Console.ReadLine();

                    // You can add logic to handle Pokémon choice here
                    switch (pokemonChoice)
                    {
                        case "1":
                            Console.WriteLine("You chose Pikachu to move.");
                            break;
                        case "2":
                            Console.WriteLine("You chose Bulbasaur to move.");
                            break;
                        case "3":
                            Console.WriteLine("You chose Charmander to move.");
                            break;
                        case "4":
                            Console.WriteLine("You chose Squirtle to move.");
                            break;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                    break;
                case "2":
                    Console.WriteLine("Select the attack to use.");
                    // Code for attacks
                    break;
                case "3":
                    Console.WriteLine("Select the item to use.");
                    // Code for items
                    break;
                case "4":
                    Console.WriteLine("You chose to run away. Thanks for playing!");
                    quitGameFight = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine(); // For spacing
        }
    }
}
