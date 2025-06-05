namespace War;

public class Gun : Firearms
{
    public Gun(int dangerous=2, int maxAmmo=10, float weight=20, string ammoType= "11bulets"): base(dangerous,maxAmmo,weight,ammoType)
    {
        Console.WriteLine("gun was created");   
    }
}