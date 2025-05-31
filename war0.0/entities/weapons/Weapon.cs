namespace War;

public class Weapon : PhysicalEntity
{
    public int dangerous { get; }
    public Weapon(int dangerous, float weight = 1) : base(weight)
    {
        this.dangerous = dangerous;
        Console.WriteLine($"weapon created");
    }
}