internal class Program
{
    private static void Main(string[] args)
    {
         PokemonGame pokemon = new PokemonGame(100, 50, 30, 40, 0, 0);
        pokemon.UsePotionNormal();
        pokemon.UsePotionMax();
        pokemon.UpgradeCapacityAttack();
        pokemon.UpgradeCapacityDefense();
        pokemon.UpgradeCapacitySpeed();
        pokemon.UseCandyXp();
        pokemon.UsePokeBall();
        pokemon.UseSuperBall();
        pokemon.UseHyperBall();
        pokemon.UseMasterBall();
    }
}
