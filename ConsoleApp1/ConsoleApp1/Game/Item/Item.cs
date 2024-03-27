public class PokemonGame
{
    private int _pv;
    private int attackPokemon;
    private int defencePokemon;
    private int speedPokemon;
    private int xpPokemon;
    private int catchPokemon;

    public PokemonGame(int pv, int attack, int defence, int speed, int xp, int catchRate)
    {
        _pv = pv;
        attackPokemon = attack;
        defencePokemon = defence;
        speedPokemon = speed;
        xpPokemon = xp;
        catchPokemon = catchRate;
    }

    public void UsePotionNormal()
    {
        int available = new Random().Next(1, 21);
        int heal = 20;
        _pv += heal;
        Console.WriteLine($"Potion Normal. Available: {available}, Heal: {heal}");
    }

    public void UsePotionMax()
    {
        int available = new Random().Next(1, 11);
        int heal = 50;
        _pv += heal;
        Console.WriteLine($"Potion Max. Available: {available}, Heal: {heal}");
    }

    public void UpgradeCapacityAttack()
    {
        int available = new Random().Next(1, 6);
        int boostAtt = 20;
        attackPokemon += boostAtt;
        Console.WriteLine($"Upgraded Capacity Attack. Available: {available}, Boost Attack: {boostAtt}");
    }

    public void UpgradeCapacityDefense()
    {
        int available = new Random().Next(1, 6);
        int boostDef = 20;
        defencePokemon += boostDef;
        Console.WriteLine($"Upgraded Capacity Defense. Available: {available}, Boost Defense: {boostDef}");
    }

    public void UpgradeCapacitySpeed()
    {
        int available = new Random().Next(1, 6);
        int boostSpeed = 20;
        speedPokemon += boostSpeed;
        Console.WriteLine($"Upgraded Capacity Speed. Available: {available}, Boost Speed: {boostSpeed}");
    }

    public void UseCandyXp()
    {
        int available = new Random().Next(1, 16);
        int bonusXp = 100;
        xpPokemon += bonusXp;
        Console.WriteLine($"Candy XP. Available: {available}, Bonus XP: {bonusXp}");
    }

    public void UsePokeBall()
    {
        int available = new Random().Next(25, 51);
        int bonusCatch = 10;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Poke Ball. Available: {available}, Bonus Catch: {bonusCatch}%");
    }

    public void UseSuperBall()
    {
        int available = new Random().Next(20, 41);
        int bonusCatch = 20;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Super Ball. Available: {available}, Bonus Catch: {bonusCatch}%");
    }

    public void UseHyperBall()
    {
        int available = new Random().Next(5, 16);
        int bonusCatch = 30;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Hyper Ball. Available: {available}, Bonus Catch: {bonusCatch}%");
    }

    public void UseMasterBall()
    {
        int available = 1;
        int bonusCatch = 100;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Master Ball. Available: {available}, Bonus Catch: {bonusCatch}%");
    }
}
