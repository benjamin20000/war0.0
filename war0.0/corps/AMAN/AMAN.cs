using Bogus;

namespace War;

public class AMAN : Corps
{
    private List<Soldier> knownTerorists = new List<Soldier>();

    public AMAN()
    {
        Console.WriteLine("AMAN was creatd");
    }
    
    public void addTerorist(float weight = 1, string name = "anonymous", int age = 0, bool isAlive = true, int liveRange = 1)
    {
        Soldier terrorist = new Soldier(weight, name,  age, isAlive, liveRange);
        knownTerorists.Add(terrorist);
    }
    
    // creating a func that will add a terrorist with random values
    public void addRandomTerorist()
    {
        Random rnd = new Random();
        int weight = rnd.Next(20, 90);
        int age = rnd.Next(15, 80);
        
        var faker = new Faker();
        string randomName = faker.Name.FullName();
        Soldier terrorist = new Soldier(weight, randomName,  age, true, 5);
        knownTerorists.Add(terrorist);
    }
    

    public void getAllTerorists()
    {
        foreach (Soldier terrorist in knownTerorists)
        {
            terrorist.printSoldier();
        }
    }
}