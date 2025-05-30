namespace War
{
    public class Program
    {
        private void implementition(int chose)
        {
                
        }
        private void display_menu()
        {
            Console.WriteLine("______Welcome to the War!____");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("1. get the most reported terrorists");

            int chose = Console.Read();
            

        }
        public static void Main(string[] args)
        {
            IDF idf = new IDF();
            Hamas hamas = new Hamas();
            hamas.RecruitRandomSoldiers(20);
            idf.printMostReportedTerorist();

            // idf.printArmyInpo();
            // hamas.printArmyInpo();
            idf.spotTerrorists(hamas);
            idf.spotTerrorists(hamas);
            idf.spotTerrorists(hamas);
            idf.creatAMANreport();
            idf.creatAMANreport();
            idf.creatAMANreport();
         
            idf.printMostReportedTerorist();
       


           

         


            // idf.printALlAMANreports();

            // idf.printAllKnownTerorists();
            
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
        }
    }
}