class IA_Pnj : Entity
{
    public IA_Pnj(int id) : base(id)
    {
    }

    public override void Update()
    {
        Console.WriteLine($"IA_Pnj {Id} is updating...");
    }
}