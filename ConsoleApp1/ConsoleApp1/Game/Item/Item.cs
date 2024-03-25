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
        Console.WriteLine($"Used Potion Normal. Available: {available}, Heal: {heal}, New PV: {_pv}");
    }

    public void UsePotionMax()
    {
        int available = new Random().Next(1, 11);
        int heal = 50;
        _pv += heal;
        Console.WriteLine($"Used Potion Max. Available: {available}, Heal: {heal}, New PV: {_pv}");
    }

    public void UpgradeCapacityAttack()
    {
        int available = new Random().Next(1, 6);
        int boostAtt = 20;
        attackPokemon += boostAtt;
        Console.WriteLine($"Upgraded Capacity Attack. Available: {available}, Boost Attack: {boostAtt}, New Attack: {attackPokemon}");
    }

    public void UpgradeCapacityDefense()
    {
        int available = new Random().Next(1, 6);
        int boostDef = 20;
        defencePokemon += boostDef;
        Console.WriteLine($"Upgraded Capacity Defense. Available: {available}, Boost Defense: {boostDef}, New Defense: {defencePokemon}");
    }

    public void UpgradeCapacitySpeed()
    {
        int available = new Random().Next(1, 6);
        int boostSpeed = 20;
        speedPokemon += boostSpeed;
        Console.WriteLine($"Upgraded Capacity Speed. Available: {available}, Boost Speed: {boostSpeed}, New Speed: {speedPokemon}");
    }

    public void UseCandyXp()
    {
        int available = new Random().Next(1, 16);
        int bonusXp = 100;
        xpPokemon += bonusXp;
        Console.WriteLine($"Used Candy XP. Available: {available}, Bonus XP: {bonusXp}, New XP: {xpPokemon}");
    }

    public void UsePokeBall()
    {
        int available = new Random().Next(25, 51);
        double bonusCatch = 0;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Used Poke Ball. Available: {available}, Bonus Catch: {bonusCatch}%, New Catch Rate: {catchPokemon}%");
    }

    public void UseSuperBall()
    {
        int available = new Random().Next(20, 41);
        double bonusCatch = 10;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Used Super Ball. Available: {available}, Bonus Catch: {bonusCatch}%, New Catch Rate: {catchPokemon}%");
    }

    public void UseHyperBall()
    {
        int available = new Random().Next(5, 16);
        double bonusCatch = 30;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Used Hyper Ball. Available: {available}, Bonus Catch: {bonusCatch}%, New Catch Rate: {catchPokemon}%");
    }

    public void UseMasterBall()
    {
        int available = 1;
        double bonusCatch = 100;
        catchPokemon += bonusCatch;
        Console.WriteLine($"Used Master Ball. Available: {available}, Bonus Catch: {bonusCatch}%, New Catch Rate: {catchPokemon}%");
    }
}
