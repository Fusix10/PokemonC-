public class Character
{
    public string Name { get; }
    public List<Dialogue> Dialogues { get; }

    public Character(string name)
    {
        Name = name;
        Dialogues = new List<Dialogue>();
    }

    public void AddDialogue(Dialogue dialogue)
    {
        Dialogues.Add(dialogue);
    }
}

public class Dialogue
{
    public string Text { get; }
    public Action OnDialogueEnd { get; }

    public Dialogue(string text, Action onDialogueEnd = null)
    {
        Text = text;
        OnDialogueEnd = onDialogueEnd;
    }
}

public class DialogueManager
{
    private Queue<Dialogue> dialogueQueue = new Queue<Dialogue>();

    public void StartDialogue(Character character)
    {
        foreach (Dialogue dialogue in character.Dialogues)
        {
            dialogueQueue.Enqueue(dialogue);
        }
        DisplayNextDialogue();
    }

    public void DisplayNextDialogue()
    {
        if (dialogueQueue.Count == 0)
        {
            EndDialogue();
            return;
        }

        Dialogue currentDialogue = dialogueQueue.Dequeue();
        Console.WriteLine(currentDialogue.Text);

        if (currentDialogue.OnDialogueEnd != null)
        {
            currentDialogue.OnDialogueEnd.Invoke();
        }
    }

    private void EndDialogue()
    {
        Console.WriteLine("End of dialogue.");
    }
}
