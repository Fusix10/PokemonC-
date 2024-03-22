using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        bool dino = true;
        while (dino)
        {
            InputManager inputManager = new InputManager();
            inputManager.Awake();
            inputManager.Update();
        }
    }
}