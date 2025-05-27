namespace War;

public abstract class Weapon : PhysicalEntity
{
    int TotalAmmo;
    int MaxAmmo;
    string AmmoType;


    public Weapon(int maxAmmo, float weight = 1) : base(weight)
    {
        this.MaxAmmo = maxAmmo;
        this.TotalAmmo = maxAmmo;
        Console.WriteLine($"weapon created");
    }
    
    public void shoot()
    {
        if (TotalAmmo > 0)
        {
            Console.WriteLine($"shooting {AmmoType} BOOOM..");
            TotalAmmo--;
        }
        else
        {
            Console.WriteLine($"no enough bullets..");
        }
    }
}