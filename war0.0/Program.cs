namespace War
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AMAN aman = new AMAN();
            aman.addTerorist(22,"benny",25,true);
            aman.addTerorist(22,"benny",25,true);
            aman.addTerorist(22,"benny",25,true);

            aman.getAllTerorists();
            Weapon w1 = new Weapon(3);
            w1.shoot();
            w1.shoot();
            w1.shoot();
            w1.shoot();
        }
    }
}