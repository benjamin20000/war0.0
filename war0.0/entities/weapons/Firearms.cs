namespace War;

public class Firearms : Weapon
{
    int TotalAmmo;
    int MaxAmmo;
    string AmmoType;
    public Firearms(int dangerous, int maxAmmo, float weight, string ammoType) : base(dangerous, weight)
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