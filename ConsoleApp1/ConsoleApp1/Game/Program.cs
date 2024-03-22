using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        bool NoEsc = true;
        while (NoEsc)
        {
            InputManager inputManager = new InputManager();
            inputManager.Awake();
            inputManager.Update();
            if(inputManager.Ivalue == 10)
            {
                NoEsc = false;
            }
        }
    }
}