using ConsoleApp1;
internal class Program
{
    
    private static void Main(string[] args)
    {
        Engine engine = new Engine();
        engine.Update();
        Character character = new Character("NPC");
        character.AddDialogue(new Dialogue("Hello, traveler!"));
        character.AddDialogue(new Dialogue("How can I help you?"));

        DialogueManager dialogueManager = new DialogueManager();
        dialogueManager.StartDialogue(character);
        NPC npc = new NPC();

        Console.WriteLine("Vous rencontrez un personnage non-joueur (PNJ). Vous pouvez interagir avec lui en lui posant des questions ou en lui disant bonjour.");

        while (true)
        {
            string userInput = Console.ReadLine().ToLower();

            if (userInput == "exit")
            {
                break;
            }

            string response = npc.Respond(userInput);
            Console.WriteLine("PNJ: " + response);
        }
        // Création des personnages
        Character player = new Character("Joueur", 100, 20);
        Character enemy = new Character("IA", 100, 15);

        // Initialisation du combat
        Combat combat = new Combat(player, enemy);

        // Début du combat
        combat.StartCombat();
    }
}