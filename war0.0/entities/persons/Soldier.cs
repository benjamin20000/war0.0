using System.Linq.Expressions;
using Bogus;
namespace War;

public class Soldier : Person
{
    private Dictionary<Weapon, int> weapons = new Dictionary<Weapon, int>();
    public Soldier(float weight = 1, string name = "anonymous", int age = 0, bool live = true, int liveRange = 1)
    : base(weight, name, age, live, liveRange)
    {
        Console.WriteLine("Soldier created");
    }

    public static Soldier CreateRandomSoldier() {
        Random rnd = new Random();
        int weight = rnd.Next(20, 90);
        int age = rnd.Next(15, 80);
        
        var faker = new Faker();
        string randomName = faker.Name.FullName(); 
        return new Soldier(weight, randomName,  age, true, 5);
    }

    public void addWeapon(Weapon weapon, int amount = 1)
    {
        if (amount < 1)
        {
            return;
        }
        if (!weapons.ContainsKey(weapon))
        {
            weapons.Add(weapon, 0);
        }
        weapons[weapon] += amount;
    }

    public void printSoldier()
    {
        Console.WriteLine($"Soldier {{ Name: {base.Name}, Weight: {base.Weight}, Age: {base.Age}, Alive: {base.IsAlive}, LiveRange: {base.LiveRange} }}");
    }

    public int getWeaponsDangerousPoints()
    {
        int res = 0;
        foreach (Weapon weapon in weapons.Keys)
        {
            res += weapon.dangerous * weapons[weapon];
        }

        return res;
    }
    
}