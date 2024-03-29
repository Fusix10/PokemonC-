using System.Collections;

public class InputManager
{
    public static InputManager? instance;

    private Hashtable keyBindings = new Hashtable();
    int i = 0;

    public int Ivalue { get => i; }

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }

        InitializeKeyBindings();
    }
    private void InitializeKeyBindings()
    {
        // Ajoutez les touches et leurs fonctions associées ici
        AddKeyBinding(ConsoleKey.UpArrow, OnUpPressed);
        AddKeyBinding(ConsoleKey.DownArrow, OnDownPressed);
        AddKeyBinding(ConsoleKey.LeftArrow, OnLeftPressed);
        AddKeyBinding(ConsoleKey.RightArrow, OnRightPressed);
        AddKeyBinding(ConsoleKey.A, OnAPressed);
        AddKeyBinding(ConsoleKey.Z, OnZPressed);
        AddKeyBinding(ConsoleKey.E, OnEPressed);
        AddKeyBinding(ConsoleKey.R, OnRPressed);
        AddKeyBinding(ConsoleKey.Tab, OnTabPressed);
        AddKeyBinding(ConsoleKey.Escape, OnEscPressed);
    }
    private void AddKeyBinding(ConsoleKey keyCode, Action action)
    {
        if (!keyBindings.ContainsKey(keyCode))
        {
            keyBindings.Add(keyCode, action);
        }
        else
        {
            keyBindings[keyCode] = action;
        }
    }
    public void Update()
    {
        var keys = Console.ReadKey(true).Key;

        foreach (ConsoleKey keyCode in keyBindings.Keys)
        {
            if (keys == keyCode)
            {
                Action? action1 = keyBindings[keyCode] as Action;
                action1?.Invoke();
            }
        }
    }
    // Fonctions appelées lorsque les touches sont pressées
    private void OnUpPressed()
    {
        i = 1;
    }

    private void OnDownPressed()
    {
        i = 2;
    }

    private void OnLeftPressed()
    {

        i = 3;
    }

    private void OnRightPressed()
    {
        i = 4;
    }

    private void OnAPressed()
    {

        i = 5;
    }

    private void OnZPressed()
    {

        i = 6;
    }

    private void OnEPressed()
    {

        i = 7;
    }

    private void OnRPressed()
    {

        i = 8;
    }

    private void OnTabPressed()
    {

        i = 9;
    }

    private void OnEscPressed()
    {
        i = 10;

    }
}