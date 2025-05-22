namespace War;

public class Soldier : Person
{
    public Soldier(float weight = 1, string name = "anonymous", int age = 0, bool live = true, int liveRange = 1)
    : base(weight, name, age, live, liveRange)
    {
        Console.WriteLine("Soldier created");
    }

    public void printSoldier()
    {
        Console.WriteLine($"Soldier {{ Name: {base.Name}, Weight: {base.Weight}, Age: {base.Age}, Alive: {base.IsAlive}, LiveRange: {base.LiveRange} }}");    }
    
}