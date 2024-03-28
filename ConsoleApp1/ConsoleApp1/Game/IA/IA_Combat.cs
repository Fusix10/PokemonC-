using System;
using System.Collections.Generic;

public enum Action
{
    Attack,
    Defend,
    Flee
}

public class Character
{
    public string Name { get; }
    public int Health { get; set; }
    public int AttackPower { get; }

    public Character(string name, int health, int attackPower)
    {
        Name = name;
        Health = health;
        AttackPower = attackPower;
    }

    public void Attack(Character target)
    {
        int damage = new Random().Next(AttackPower / 2, AttackPower);
        target.Health -= damage;
        Console.WriteLine($"{Name} attaque {target.Name} et lui inflige {damage} points de dégâts.");
    }

    public bool IsAlive()
    {
        return Health > 0;
    }
}

public class Combat
{
    private Character player;
    private Character enemy;

    public Combat(Character player, Character enemy)
    {
        this.player = player;
        this.enemy = enemy;
    }

    public void StartCombat()
    {
        Console.WriteLine($"Un combat commence ! {player.Name} (Joueur) VS {enemy.Name} (IA).");

        while (player.IsAlive() && enemy.IsAlive())
        {
            // Tour du joueur
            PlayerTurn();

            // Tour de l'IA
            if (enemy.IsAlive())
            {
                EnemyTurn();
            }
        }

        Console.WriteLine(player.IsAlive() ? "Vous avez vaincu l'IA !" : "L'IA vous a vaincu !");
    }

    private void PlayerTurn()
    {
        Console.WriteLine("\nC'est à votre tour !");
        Console.WriteLine("Choisissez une action :");
        Console.WriteLine("1. Attaquer");
        Console.WriteLine("2. Se défendre");
        Console.WriteLine("3. Fuir");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                player.Attack(enemy);
                break;
            case 2:
                Console.WriteLine($"{player.Name} se défend et réduit les dégâts reçus.");
                break;
            case 3:
                Console.WriteLine("Vous fuyez le combat !");
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Action non reconnue. Vous perdez votre tour !");
                break;
        }
    }

    private void EnemyTurn()
    {
        Console.WriteLine("\nTour de l'IA...");

        // L'IA prend une décision intelligente
        Action aiAction = DecideAIAction();

        switch (aiAction)
        {
            case Action.Attack:
                enemy.Attack(player);
                break;
            case Action.Defend:
                Console.WriteLine($"{enemy.Name} se défend et réduit les dégâts reçus.");
                break;
            case Action.Flee:
                Console.WriteLine($"{enemy.Name} tente de fuir !");
                Environment.Exit(0);
                break;
        }
    }

    private Action DecideAIAction()
    {
        // L'IA prend une décision basée sur des règles simples
        // Par exemple, elle attaque si elle a plus de 50% de sa santé
        // Sinon, elle se défend
        // Vous pouvez ajouter des règles plus complexes selon vos besoins

        if ((double)enemy.Health / enemy.MaxHealth > 0.5)
        {
            return Action.Attack;
        }
        else
        {
            return Action.Defend;
        }
    }
}