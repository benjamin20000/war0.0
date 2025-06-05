namespace War
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IDF idf = new IDF();
            Hamas hamas = new Hamas();
            hamas.RecruitRandomSoldiers(20);
            idf.creatAMANcorps();
            idf.printArmyInpo();
            hamas.printArmyInpo();
            idf.spotTerrorists(hamas);

            // AMAN aman = new AMAN();
            // aman.addTerorist(22,"benny",25,true);
            // aman.addTerorist(22,"benny",25,true);
            // aman.addTerorist(22,"benny",25,true);
            //
            // aman.getAllTerorists();
            // Weapon w1 = new Weapon(3);
            // w1.shoot();
            // w1.shoot();
            // w1.shoot();
            // w1.shoot();
            //
            // AMAN report = new AMAN();
            // report.addRandomTerorist();
            // report.addRandomTerorist();
            // report.getAllTerorists();
            hamas.GetRandomTerrorists();    
         }
    }
}