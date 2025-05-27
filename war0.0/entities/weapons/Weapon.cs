namespace War;

public class Weapon : PhysicalEntity
{
    int TotalAmmo;
    int MaxAmmo;
    string AmmoType;
    public Weapon(int maxAmmo=10, float weight = 1, string ammoType = "nurmal bulet") : base(weight)
    {
        this.MaxAmmo = maxAmmo;
        this.TotalAmmo = maxAmmo;
        this.AmmoType = ammoType;
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

    public void addAmmo(int ammo_amount)
    {
        this.TotalAmmo += ammo_amount;
        if (TotalAmmo > MaxAmmo)
        {
            TotalAmmo = MaxAmmo;
        }
    }
}