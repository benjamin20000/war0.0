using Bogus;

namespace War;

internal class AMAN : Corps
{
    private List<Soldier> knownTerorists = new List<Soldier>();

    public AMAN(Soldier Commander,  List<Soldier> Soldiers = null, List<string> Tools = null)
    : base(Commander,  Soldiers)
    {
        Console.WriteLine("AMAN was creatd");
    }
    
    // public void addTerorist(float weight = 1, string name = "anonymous", int age = 0, bool isAlive = true, int liveRange = 1)
    // {
    //     Soldier terrorist = new Soldier(weight, name,  age, isAlive, liveRange);
    //     knownTerorists.Add(terrorist);
    // }

    public void explorTerrorist(Hamas hamas)
    {
        List<Soldier>  newTerrorists = hamas.GetRandomTerrorists();
        knownTerorists.AddRange(newTerrorists);
        Console.WriteLine($"AMAN was found {newTerrorists.Count} Terrorists");
    }
    // creating a func that will add a terrorist with random values
    public void addRandomTerorist()
    {
        Soldier terrorist = Soldier.CreateRandomSoldier();
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