class IA_Combat : Entity
{
    public IA_Combat(int id) : base(id)
    {
    }

    public override void Update()
    {
        Console.WriteLine($"IA_Combat {Id} is updating...");
    }
}