using System;

class Character
{
    public const string FAMILY = "Fellowship";
    public static int NumberofCharacters = 0;

    // properties
    protected string _name;
    private string _race;
    private int _speed = 40;

    public int Strength { get; set; } = 500;

    public Character(string name, string race)
    {
        _name = name;
        _race = race;
        NumberofCharacters++;
        Console.WriteLine($"Created character with name {_name}");
    }
    public Character(string name)
    {
        _name = name;
        NumberofCharacters++;
        Console.WriteLine($"Created character with name {_name}");
    }

    // Overloading
    public Character()
    {
        _name = "No name";
        NumberofCharacters++;
        Console.WriteLine($"Created character with name {_name}");
    }

    // functions
    public string GetName()
    {
        return _name;
    }

    public int GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(int speed)
    {
        if (speed > 90)
        {
            speed = 90;
        }
        else
        {
            _speed = speed;

        }
    }

// virtual means this method can be overriden
    public virtual void Introduce()
    {
        Console.WriteLine($"I am {_name} and I am a {_race}");
    }

    public static void CountCharacters()
    {
        Console.WriteLine($"There are {NumberofCharacters} characters");
    }
}