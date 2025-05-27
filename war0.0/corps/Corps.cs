namespace War;

public  class Corps
{
    protected Soldier Commander;
    protected List<Soldier> Soldiers;
    protected List<string> Tools;

    protected Corps(Soldier Commander,  List<Soldier> Soldiers, List<string> Tools)
    {
        this.Soldiers = Soldiers ?? new List<Soldier>();
        this.Tools = Tools ?? new List<string>();
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