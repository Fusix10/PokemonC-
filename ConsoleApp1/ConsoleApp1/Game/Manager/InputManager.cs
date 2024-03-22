using System.Collections;

public class InputManager
{
    private static InputManager? instance;

    private Hashtable keyBindings = new Hashtable();
    int i = 0;

    public int Ivalue { get => i;}

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
        if (Console.KeyAvailable)
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
    }
    // Fonctions appelées lorsque les touches sont pressées
    private void OnUpPressed()
    {
        Console.WriteLine("Up Arrow Pressed");
        i = 1;
    }

    private void OnDownPressed()
    {
        Console.WriteLine("Down Arrow Pressed");
        i = 2;
    }

    private void OnLeftPressed()
    {
        Console.WriteLine("Left Arrow Pressed");
        i = 3;
    }

    private void OnRightPressed()
    {
        Console.WriteLine("Right Arrow Pressed");
        i = 4;
    }

    private void OnAPressed()
    {
        Console.WriteLine("A Pressed");
        i = 5;
    }

    private void OnZPressed()
    {
        Console.WriteLine("Z Pressed");
        i = 6;
    }

    private void OnEPressed()
    {
        Console.WriteLine("E Pressed");
        i = 7;
    }

    private void OnRPressed()
    {
        Console.WriteLine("R Pressed");
        i = 8;
    }

    private void OnTabPressed()
    {
        Console.WriteLine("Tab Pressed");
        i = 9;
    }

    private void OnEscPressed()
    {
        Console.WriteLine("Esc Pressed");
        i = 10;

    }
}