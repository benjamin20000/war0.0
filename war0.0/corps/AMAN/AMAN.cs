using Bogus;

namespace War;

internal class AMAN : Corps
{
    private List<Soldier> knownTerorists = new List<Soldier>();
    private List<Report> reports = new List<Report>();
    private Dictionary<Soldier, int> terroristsReportsCounetr = new Dictionary<Soldier, int>();
    private Soldier MostReportedTerorist = null;

    public AMAN(Soldier Commander,  List<Soldier> Soldiers = null, List<string> Tools = null)
    : base(Commander,  Soldiers)
    {
        Console.WriteLine("AMAN was creatd");
    }
    
    // public void addTerorist(float weight = 1, string name = "anonymous", int age = 0, bool isAlive = true, int liveRange = 1)
    // {
    //     Soldier terrorist = new Soldier(weight, name,  age, isAlive, liveRange);
    //     knownTerorists.Add(terrorist);
    // }

    public void explorTerrorist(Hamas hamas)
    {
        List<Soldier>  newTerrorists = hamas.GetRandomTerrorists();
        knownTerorists.AddRange(newTerrorists);
        Console.WriteLine($"AMAN was found {newTerrorists.Count} Terrorists");
    }
    // creating a func that will add a terrorist with random values
    public void addRandomTerorist()
    {
        Soldier terrorist = Soldier.CreateRandomSoldier();
        knownTerorists.Add(terrorist);
    }
    

    public void printAllKnownTerorists()
    {
        foreach (Soldier terrorist in knownTerorists)
        {
            terrorist.printSoldier();
        }
    }

    public void creatReport()
    {
        Random rnd = new Random();
        List<Soldier> terrorists = new List<Soldier>();
        foreach (Soldier terrorist in knownTerorists)
        {
            // 1/len chance to terrorist to be in report
            // Expectation of 1 terrorist to 1 report
            int randNum = rnd.Next(1, knownTerorists.Count); 
            if (randNum == 1)
            {
                if (!terroristsReportsCounetr.ContainsKey(terrorist))
                {
                    terroristsReportsCounetr.Add(terrorist,0);   
                }
                terroristsReportsCounetr[terrorist]++;
                //make sure the MostReportedTerorist is not null 
                //this will be true only in the first report on the first terrorist
                if (MostReportedTerorist == null)
                {
                    MostReportedTerorist = terrorist;
                }
                // update if nededd the MostReportedTerorist
                if (terroristsReportsCounetr[terrorist] > terroristsReportsCounetr[MostReportedTerorist])
                {
                    MostReportedTerorist = terrorist;
                }
                terrorists.Add(terrorist);
            }
        }
        //the report created successfully
        if (terrorists.Count > 0)
        {
            int reportId = reports.Count; 
            Report report = new Report(reportId, terrorists);
            this.reports.Add(report);
        }
        // else the report not created successfully
        else 
        {
            Console.WriteLine("creating report failed");
        }
    }

    public Soldier getMostReportedTerorist()
    {
        return this.MostReportedTerorist;
    }
    
    public List<Report> getReports()
    {
        return reports;
    }
    
    public void printReport(Report report)
    {
        report.PrintReport();
    }
    public void printALlReports()
    {
        foreach (Report report in reports)
        {
            report.PrintReport();
        }
    }
}