using System.Collections;

public class InputManager
{
    private static InputManager? instance;

    private Hashtable keyBindings = new Hashtable();

    public void Awake(object gameObject)
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }

        InitializeKeyBindings();
    }

    public void Destroy(object gameObject)
    {
        throw new NotImplementedException();
    }

    public void InitializeKeyBindings()
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
    }

    public void AddKeyBinding(ConsoleKey keyCode, Action action)
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

    public void Update(Action? action)
    {
        if (Console.KeyAvailable)
        {
            var keys = Console.ReadKey(true).Key;

            foreach (ConsoleKey keyCode in keyBindings.Keys)
            {
                if (keys == keyCode)
                {
                    Action? action1 = keyBindings[keyCode] as Action;
                    action?.Invoke();
                }
            }
        }

    }

    // Fonctions appelées lorsque les touches sont pressées
    private void OnUpPressed()
    {
        Console.WriteLine("Up Arrow Pressed");
    }

    private void OnDownPressed()
    {
        Console.WriteLine("Down Arrow Pressed");
    }

    private void OnLeftPressed()
    {
        Console.WriteLine("Left Arrow Pressed");
    }

    private void OnRightPressed()
    {
        Console.WriteLine("Right Arrow Pressed");
    }

    private void OnAPressed()
    {
        Console.WriteLine("A Pressed");
    }

    private void OnZPressed()
    {
        Console.WriteLine("Z Pressed");
    }

    private void OnEPressed()
    {
        Console.WriteLine("E Pressed");
    }

    private void OnRPressed()
    {
        Console.WriteLine("R Pressed");
    }

    private void OnTabPressed()
    {
        Console.WriteLine("Tab Pressed");
    }
}