namespace War;

internal class Report
{
    List<Soldier> LinkedTerorist;
    private Location LastKnownLocation;
    private string ReportTime;

    public Report(List<Soldier> LinkedTerorist, Location LastKnownLocation = null)
    {
        this.LinkedTerorist = LinkedTerorist;
        // this.LastKnownLocation = LastKnownLocation;
        ReportTime = DateTime.Now.ToLongTimeString();
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
        Console.WriteLine("LinkedTerrorism: ");
        printLinkedTerorist();
        Console.WriteLine($"LastKnownLocation: {LastKnownLocation}");
        Console.WriteLine($"ReportTime: {ReportTime}");
    } 
    // public void addTerorist()
    
    
}