using System;

class MenuFigth  
{
    public void ShowMenuFigth()
    {
        bool quitGameFight = false;

        while (!quitGameFight)
        {
            Console.WriteLine("\r\n░▒▓████████▓▒░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░▒▓████████▓▒░ \r\n░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░      ░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n░▒▓██████▓▒░ ░▒▓█▓▒░▒▓█▓▒▒▓███▓▒░▒▓████████▓▒░  ░▒▓█▓▒░     \r\n░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n░▒▓█▓▒░      ░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n░▒▓█▓▒░      ░▒▓█▓▒░░▒▓██████▓▒░░▒▓█▓▒░░▒▓█▓▒░  ░▒▓█▓▒░     \r\n                                                            \r\n                                                            \r\n");
            Console.WriteLine("                  _        _        _        __       __       _\r\n        /\\       |_)      /        | \\      |_       |_       /        |_|\r\n       /--\\      |_)      \\_       |_/      |__      |        \\_?      | |\r\n\r\n  _           #########         #########         #########         #########\r\n (_)   [`'`'] ##\\`.'/##  ':v:`  ##/\\:/\\##  |:+:|  ##':v:`##  \\`.'/  ##[`'`']#\r\n (_)    |::|  ##(o:o)##  (o:0)  #/(o:o)\\#  (o:o)  ##(o:0)##  (o:o)  ###|::|##\r\n        |::|  ###\\:/:\\#   (:)   ###(:)###   (:)   ###(:)###   \\:/:\\ ###|::|##\r\n              ####\"####         #########         #########    \"    #########\r\n  __ #########    _    #########    _    #########    _    #########    _\r\n   / ###(:)###   (:)   ###(:)###   (:)   ###(:)###   (:)   ###(:)###   (:)\r\n  /  ###|:|###   |:|   ###|:|###   |:|   ###|:|###   |:|   ###|:|###   |:|\r\n     ###|:|###   |:|   ###|:|###   |:|   ###|:|###   |:|   ###|:|###   |:|\r\n     #########         #########         #########         #########\r\n              #########         #########         #########         #########\r\n  /           #########         #########         #########         #########\r\n (_)          #########         #########         #########         #########\r\n              #########         #########         #########         #########\r\n              #########         #########         #########         #########\r\n  _  #########         #########         #########         #########\r\n |_  #########         #########         #########         #########\r\n  _) #########         #########         #########         #########\r\n     #########         #########         #########         #########\r\n     #########         #########         #########         #########\r\n   .          #########         #########         #########         #########\r\n  /|          #########         #########         #########         #########\r\n '-|          #########         #########         #########         #########\r\n              #########         #########         #########         #########\r\n              #########         #########         #########         #########\r\n  _  #########         #########         #########         #########\r\n  _) #########         #########         #########         #########\r\n  _) #########         #########         #########         #########\r\n     #########         #########         #########         #########\r\n     #########         #########         #########         #########\r\n  _      _    #########    _    #########    _    #########    _    #########\r\n   )    (_)   ###(_)###   (_)   ###(_)###   (_)   ###(_)###   (_)   ###(_)###\r\n  /_    | |   ###| |###   | |   ###| |###   | |   ###| |###   | |   ###| |###\r\n        |_|   ###|_|###   |_|   ###|_|###   |_|   ###|_|###   |_|   ###|_|###\r\n              #########         #########         #########         #########\r\n     #########         #########   ___   #########         #########\r\n  /| ##[`'`']#  \\`~'/  ##'\\v/`##  /\\*/\\  ##|`+'|##  '\\v/`  ##\\`~'/##  [`'`']\r\n   | ###|  |##  (o o)  ##(o 0)## /(o o)\\ ##(o o)##  (o 0)  ##(o o)##   |  |\r\n     ###|__|##   \\ / \\ ###(_)###   (_)   ###(_)###   (_)   ###\\ / \\#   |__|\r\n     #########    \"    #########         #########         ####\"####");
            Console.WriteLine("=== Menu Fight ===");
            Console.WriteLine("1. Dépacement");
            Console.WriteLine("2. Attack");
            Console.WriteLine("3. Bag");
            Console.WriteLine("4. Prendre la Fuite");
            Console.Write("Please select an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("=== choisisé le pokemon qui va se deplacé ===");
                    Console.WriteLine("1. Poke 1");
                    Console.WriteLine("2. Poke 2");
                    Console.WriteLine("3. Poke 3");
                    Console.WriteLine("4. Poke 4");
                    // Code to create a new save and player
                    break;
                case "2":
                    Console.WriteLine("=== Quelle attack vous voulez utilisé ===");
                    Console.WriteLine("1. Atack 1");
                    Console.WriteLine("2. Atack 2");
                    Console.WriteLine("3. Atack 3");
                    Console.WriteLine("4. Atack 4");
                    // Code to load saved game
                    break;
                case "3":
                    Console.WriteLine("=== Quel object souhaité vous utilisé ===");
                    Console.WriteLine("1. Object 1");
                    Console.WriteLine("2. Object 2");
                    Console.WriteLine("3. Object 3");
                    Console.WriteLine("4. Object 4");
                    //
                    break;
                case "4":
                    Console.WriteLine(" ratio + cheh + Gros Noobs");
                    quitGameFight = true;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

            Console.WriteLine(); // Just for spacing
        }
    }


}