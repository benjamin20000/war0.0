using Bogus;
namespace War;

public class Soldier : Person
{
    public Soldier(float weight = 1, string name = "anonymous", int age = 0, bool live = true, int liveRange = 1)
    : base(weight, name, age, live, liveRange)
    {
        Console.WriteLine("Soldier created");
    }

    public static Soldier CreateRandomSoldier() {
        Random rnd = new Random();
        int weight = rnd.Next(20, 90);
        int age = rnd.Next(15, 80);
        
        var faker = new Faker();
        string randomName = faker.Name.FullName(); 
        return new Soldier(weight, randomName,  age, true, 5);
        
    }

    public void printSoldier()
    {
        Console.WriteLine($"Soldier {{ Name: {base.Name}, Weight: {base.Weight}, Age: {base.Age}, Alive: {base.IsAlive}, LiveRange: {base.LiveRange} }}");
    }
    
}