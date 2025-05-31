namespace War;

public class Game
{
    private IDF idf;
    private Hamas hamas;
    public Game()
    {
        creatArmys();
        initAMANdata();
        // hamas.RecruitRandomSoldiers(20);
        // idf.printMostReportedTerorist();
        //
        // // idf.printArmyInpo();
        // // hamas.printArmyInpo();

    }
    private void creatArmys()
    { 
        this.hamas = new Hamas(); 
        this.idf = new IDF(); 
        hamas.RecruitRandomSoldiers(20); 
        // idf.RecruitRandomSoldiers(20);
        Gun gun = new Gun();
        Rifle rifle = new Rifle();
        Knife knife = new Knife();
        hamas.RandomlyArmament(knife, 10);
        hamas.RandomlyArmament(gun, 7);
        hamas.RandomlyArmament(rifle, 3);
        
    }

    private void initAMANdata()
    {
        idf.spotTerrorists(hamas);
        idf.spotTerrorists(hamas);
        idf.spotTerrorists(hamas);
        idf.creatAMANreport();
        idf.creatAMANreport();
        idf.creatAMANreport();
        idf.printAllAMANreports();
        idf.printAllKnownTerorists();
        
    }
    private void implementation(int chosenNum) {
        switch (chosenNum) 
        { 
            case 1: 
                Console.WriteLine("1 good chois");
                idf.printMostReportedTerorist(); 
                break;
            case 2: 
                idf.printManpower(); 
                break;
            case 3:
                idf.printtMostDangerousterrorist();
                break;
            case 9:
                return;
            default: 
                break; 
        }

        play();
    }
    public void play()
    {
        Console.WriteLine("______Welcome to the War!____"); 
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("1. get the most reported terrorists");
        Console.WriteLine("2. get the manpower of idf");
        Console.WriteLine("3. get the most dangerous terrorists");
        Console.WriteLine("9. EXIT");

        int chosenNum = int.Parse(Console.ReadLine());
        implementation(chosenNum);
    }
}