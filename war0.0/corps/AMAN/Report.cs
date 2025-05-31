namespace War;

internal class Report
{
    private int id;
    List<Soldier> LinkedTerorist;
    private Location LastKnownLocation;
    private string ReportTime;

    public Report(int reportId, List<Soldier> LinkedTerorist, Location LastKnownLocation = null)
    {
        this.id = reportId;
        this.LinkedTerorist = LinkedTerorist;
        // this.LastKnownLocation = LastKnownLocation;
        ReportTime = DateTime.Now.ToLongTimeString();
        PrintReport();
    }
    public string getReportTime()
    {
        return ReportTime;
    }

    public void printLinkedTerorist()
    {
        if (LinkedTerorist.Count == 0)
        {
            Console.WriteLine("no Terrorists yet");
        }
        else
        {
            foreach (Soldier terrorist in LinkedTerorist)
            {
                terrorist.printSoldier();
            }
        }
    }

    public void PrintReport()
    {
        Console.WriteLine($"_____reportID: {id}_____");
        Console.WriteLine("LinkedTerrorists:");
        printLinkedTerorist();
        Console.WriteLine($"LastKnownLocation: {LastKnownLocation}");
        Console.WriteLine($"ReportTime: {ReportTime}");
    } 
    // public void addTerorist()
    
    
}