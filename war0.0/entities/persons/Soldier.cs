namespace War0._0.entetis;

public class Soldier : Person
{
    public Soldier(float weight, string name, int age, bool live, int liveRange)
    : base(weight, name, age, live, liveRange)
    {
        Console.WriteLine("Soldier created");
    }
    
}