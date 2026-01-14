using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using Hobbits;

// dotnet new console -n <name> 
// Above command creates a new c# project

// dotnet new list
// Templates of projects to make

// dotnet run
// Run the project

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Variables
int age = 22;
string name = "Frodo";
bool isHero = false;
double height = 1.4567; // 16 bit 16dp
float weight = 25.6f; // 32 bit 7dp
char allegiance = 'G';

const int SPEED = 22;

Console.WriteLine($"{name} is \n {age} years old");

var isVillian = true;

float floatValue = 50.456f;
int intValue = 23434;

float division = intValue / floatValue; // Yields a float value
Console.WriteLine(division);


// If Statements
if (isVillian == false)
{
    Console.WriteLine("Is Villian");
}
else
{
    Console.WriteLine("Is Not Villian");
}

// Switch statements
switch (name)
{
    case "Bob":
        Console.WriteLine("The name is Bob");
        break;
    case "Sarah":
    case "Billy":
    case "John":
    case "Donkey":
        Console.WriteLine($"The name is {name}");
        break;
    default:
        Console.WriteLine("Unknown name is intruder");
        break;
}

int x = 10;
string result = x > 10 ? "LARGE" : "SMALL";

// Inputs
Console.Write("Enter your name: ");
string userName = Console.ReadLine();

Console.Write("Age: ");
int inputAge = int.Parse(Console.ReadLine());


// Arrays and loops
string[] clans = { "Fire", "Water", "Earth", "Air" };

Console.WriteLine(clans[2]);
Console.WriteLine(clans.Length);
clans[2] = "Blue";
Console.WriteLine(clans[2]);

for (int i = 0; i < clans.Length; i++)
{
    Console.WriteLine(clans[i]);
}

foreach (var item in clans)
{
    if (item == "Blue")
    {
        Console.WriteLine("Woohoo");
        continue;
    }
    Console.WriteLine(item);
}

// List<string> inventory = new List<string>();

// inventory.Add("Box");
// inventory.Add("Food");
// inventory.Add("Money");

List<string> inventory = new List<string>{
    "Pipe", "Glamdring", "Wizard Staff"
};

inventory.Remove("Money");

foreach (var item in inventory)
{
    Console.WriteLine(item);
}
Console.WriteLine(inventory.Contains("Money"));

List<string> sortedInventory = inventory.Order().ToList(); // Sorted in alphabetical order

string desiredItem = inventory.FirstOrDefault(item => item == "Glamdring");

Dictionary<string, string> fellowshipRoles = new Dictionary<string, string>();

fellowshipRoles.Add("Frodo", "Ring Bearer");
fellowshipRoles.Add("Gandalf", "Wizard");
fellowshipRoles.Add("Aragorn", "Ranger");

string frodoRole = fellowshipRoles["Frodo"];

foreach (string member in fellowshipRoles.Keys) { }
foreach (string roles in fellowshipRoles.Values) { }
foreach (KeyValuePair<string, string> role in fellowshipRoles) { }

if (fellowshipRoles.ContainsKey("asdad")) { }
fellowshipRoles.Remove("Aragorn");

fellowshipRoles["Frodo"] = "asdsaddasdas";

Dictionary<string, string[]> characterAbilities = new Dictionary<string, string[]>();

characterAbilities.Add("Frodo", ["Strength", "Courage"]);
characterAbilities.Add("Bob", ["Speed", "Fire"]);
characterAbilities.Add("Joe", ["Speed", "Water"]);

foreach (KeyValuePair<string, string[]> character in characterAbilities)
{
    Console.Write($"{character.Key}: ");
    foreach (string power in character.Value)
    {
        Console.Write(power + ' ');
    }
    Console.Write("\n");
}

foreach (KeyValuePair<string, string[]> character in characterAbilities)
{
    if (character.Value.Contains("Speed"))
    {
        Console.WriteLine("Speed character: " + character.Key);
    }
}

// Functions
Random random = new Random();

void SayPhrase(string name, string phrase)
{
    Console.WriteLine($"{name} says: {phrase}");
}

int GetHealth(string name)
{
    int health = random.Next(50, 101);
    Console.WriteLine($"{name} new health is {health}");
    return health;
}

// Class
Character frodo = new Character("Asdasdas");
Hobbit hob = new Hobbit("Dam");
hob.Introduce();
hob.SneakAround();
hob.ChangeName("Asdsadasdas");
hob.Introduce();


Monster m = new Monster("mmmmmm");
m.Introduce();

Character.CountCharacters();

if (hob is Monster) {}
if (hob is Character) {}