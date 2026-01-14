class Hobbit : Character
{
    public Hobbit(string name) : base(name, "Hobbit")
    {

    }

    public void SneakAround()
    {
        Console.WriteLine($"{_name} is sneaking around");
    }
    
    public void ChangeName(string newName)
    {
        _name = newName;
    }
}