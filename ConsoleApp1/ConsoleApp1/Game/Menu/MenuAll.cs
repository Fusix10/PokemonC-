using System;

class MenuAll
{
    public void ShowMainMenu()
    {
        bool quitGame = false;

        while (!quitGame)
        {
            Console.WriteLine("\r\n  _____      _                                        _____ _                   \r\n |  __ \\    | |                                      / ____| |                  \r\n | |__) |__ | | _____ _ __ ___   ___  _ __   __  __ | |    | |__   ___  ___ ___ \r\n |  ___/ _ \\| |/ / _ \\ '_ ` _ \\ / _ \\| '_ \\  \\ \\/ / | |    | '_ \\ / _ \\/ __/ __|\r\n | |  | (_) |   <  __/ | | | | | (_) | | | |  >  <  | |____| | | |  __/\\__ \\__ \\\r\n |_|   \\___/|_|\\_\\___|_| |_| |_|\\___/|_| |_| /_/\\_\\  \\_____|_| |_|\\___||___/___/\r\n                                                                                \r\n                                                                                \r\n");
            Console.WriteLine("quu..__\r\n $$$b  `---.__\r\n  \"$$b        `--.                          ___.---uuudP\r\n   `$$b           `.__.------.__     __.---'      $$$$\"              .\r\n     \"$b          -'            `-.-'            $$$\"              .'|\r\n       \".                                       d$\"             _.'  |\r\n         `.   /                              ...\"             .'     |\r\n           `./                           ..::-'            _.'       |\r\n            /                         .:::-'            .-'         .'\r\n           :                          ::''\\          _.'            |\r\n          .' .-.             .-.           `.      .'               |\r\n          : /'$$|           .@\"$\\           `.   .'              _.-'\r\n         .'|$u$$|          |$$,$$|           |  <            _.-'\r\n         | `:$$:'          :$$$$$:           `.  `.       .-'\r\n         :                  `\"--'             |    `-.     \\\r\n        :##.       ==             .###.       `.      `.    `\\\r\n        |##:                      :###:        |        >     >\r\n        |#'     `..'`..'          `###'        x:      /     /\r\n         \\                                   xXX|     /    ./\r\n          \\                                xXXX'|    /   ./\r\n          /`-.                                  `.  /   /\r\n         :    `-  ...........,                   | /  .'\r\n         |         ``:::::::'       .            |<    `.\r\n         |             ```          |           x| \\ `.:``.\r\n         |                         .'    /'   xXX|  `:`M`M':.\r\n         |    |                    ;    /:' xXXX'|  -'MMMMM:'\r\n         `.  .'                   :    /:'       |-'MMMM.-'\r\n          |  |                   .'   /'        .'MMM.-'\r\n          `'`'                   :  ,'          |MMM<\r\n            |                     `'            |tbap\\\r\n             \\                                  :MM.-'\r\n              \\                 |              .''\r\n               \\.               `.            /\r\n                /     .:::::::.. :           /\r\n               |     .:::::::::::`.         /\r\n               |   .:::------------\\       /\r\n              /   .''               >::'  /\r\n              `',:                 :    .'\r\n                                   `:.:'");
            Console.WriteLine("=== Main Menu ===");
            Console.WriteLine("1. New Play");
            Console.WriteLine("2. Load Play");
            Console.WriteLine("3. Exit");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Creating a new save and player...");
                    // Code to create a new save and player
                    break;
                case "2":
                    Console.WriteLine("Loading saved game...");
                    // Code to load saved game
                    break;
                case "3":
                    Console.WriteLine("Exiting game. Goodbye!");
                    quitGame = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine(); // Just for spacing
        }
    }


}
