class Monster : Character
{
    public Monster(string name) : base(name, "Monster") { }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("ROAR");
    }
}