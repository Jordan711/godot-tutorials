/**

Partial classes
allows you split a definition of a class over multiple files

Use namespaces to avoid naming conflicts
E.g. classes with the same name
**/

partial class Monster : Character
{
    public Monster(string name) : base(name, "Monster") { }

    public override void Introduce()
    {
        base.Introduce();
        Console.WriteLine("ROAR");
    }
}