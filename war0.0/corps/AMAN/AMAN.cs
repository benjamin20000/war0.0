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
    

    public void getAllTerorists()
    {
        foreach (Soldier terrorist in knownTerorists)
        {
            terrorist.printSoldier();
        }
    }
}