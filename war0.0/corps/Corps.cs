namespace War;

public abstract class Corps
{
    protected Soldier Commander;
    protected List<Soldier> Soldiers;

    protected Corps(Soldier Commander,  List<Soldier> Soldiers)
    {
        this.Soldiers = Soldiers ?? new List<Soldier>();
        Console.WriteLine("Crops have been created");
    }
    
    public void AppointNewCorpsCommander(Soldier Commander)
    {
        Console.WriteLine($"thanks to commander {this.Commander} for is great work, byyy");
        this.Commander = Commander;
        Console.WriteLine($"welcome to the new commander: {this.Commander}");
    }

    public void addNewSoldier(Soldier newSoldier)
    {
        this.Soldiers.Add(newSoldier);
    }

    public void printAllSoldiers()
    {
        foreach (Soldier soldier in this.Soldiers )
        {   
            soldier.printSoldier();
        }
    }
}