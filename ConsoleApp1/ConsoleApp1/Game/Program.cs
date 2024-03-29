using System;

class Program
{
    static void Main(string[] args)
    {
        Map map = new Map();
        AfficherCarteAvecJoueur(map);

        // Boucle de jeu
        while (true)
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey(true);

            // Vérifiez quelle touche a été appuyée
            switch (keyInfo.Key)
            {
                case ConsoleKey.UpArrow:
                    map.MovePlayer(Direction.Up);
                    break;
                case ConsoleKey.DownArrow:
                    map.MovePlayer(Direction.Down);
                    break;
                case ConsoleKey.LeftArrow:
                    map.MovePlayer(Direction.Left);
                    break;
                case ConsoleKey.RightArrow:
                    map.MovePlayer(Direction.Right);
                    break;
                default:
                    continue; // Ignorer les autres touches
            }

            // Effacer la console et afficher la carte mise à jour avec la position du joueur
            Console.Clear();
            AfficherCarteAvecJoueur(map);
        }
    }

    static void AfficherCarteAvecJoueur(Map map)
    {
        Console.WriteLine(map.myMap);
    }
}
