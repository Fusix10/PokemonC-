using ConsoleApp1;
public class Engine
{
    public Engine()
    {

    }
    public void Update()
    {
        Pokemon poke;
        Window aled;
        aled = new Window(5, 5);
        aled.DrawWindow();
        poke = new Pokemon(0);
        aled = new Window(5, 5);
        while (true)
        {
            aled.DrawWindow();
            poke.DrawPokemon(aled);
            Console.ReadKey(false);
        }
    }
}