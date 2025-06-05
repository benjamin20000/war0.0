namespace War;

public class Rifle: Firearms
{
    public Rifle(int dangerous=3, int maxAmmo=20, float weight=40, string ammoType= "22bulets"): base(dangerous,maxAmmo,weight,ammoType)
    {
        Console.WriteLine("Rifle was created");   
    }
}
