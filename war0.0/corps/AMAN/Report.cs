namespace War;

public class Report
{
    List<Soldier> LinkedTerorist = new List<Soldier>();
    private double[] LastKnownLocation = new double[3];
    private string ReportTime;

    public Report(List<Soldier> LinkedTerorist = null, double[] LastKnownLocation = null)
    {
        if (LinkedTerorist == null)
        {
            LinkedTerorist = new List<Soldier>();
        }
        if (LastKnownLocation == null)
        {
            LastKnownLocation = new double[3];
        }
        this.LinkedTerorist = LinkedTerorist;
        this.LastKnownLocation = LastKnownLocation;
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