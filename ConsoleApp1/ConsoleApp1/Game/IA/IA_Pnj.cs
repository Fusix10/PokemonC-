using System;
using System.Collections.Generic;

public class NPC
{
    private Dictionary<string, List<string>> dialogueTree;

    public NPC()
    {
        dialogueTree = new Dictionary<string, List<string>>();
        // Initialisation du dialogue de l'IA_PNJ
        dialogueTree.Add("hello", new List<string> { "Bonjour ! Comment puis-je vous aider ?", "Salut ! En quoi puis-je vous être utile ?" });
        dialogueTree.Add("goodbye", new List<string> { "Au revoir !", "À bientôt !" });
        dialogueTree.Add("help", new List<string> { "Comment puis-je vous assister ?", "En quoi puis-je vous être utile ?" });
        // Vous pouvez ajouter d'autres dialogues et réponses ici
    }

    public string Respond(string input)
    {
        // Par défaut, si l'entrée n'est pas reconnue, l'IA_PNJ répondra de manière générique
        string response = "Je ne comprends pas. Pouvez-vous reformuler ?";

        // Chercher une réponse dans le dialogue de l'IA_PNJ
        if (dialogueTree.ContainsKey(input.ToLower()))
        {
            List<string> possibleResponses = dialogueTree[input.ToLower()];
            response = possibleResponses[new Random().Next(possibleResponses.Count)];
        }

        return response;
    }
}