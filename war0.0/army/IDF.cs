using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace War
{
    public class IDF : ArmyForce
    {
        public IDF(string establishedYear = "1948", Soldier curentCommander = null, Dictionary<string, Corps> allCorps =null) : base(establishedYear, curentCommander, allCorps)
        {
            creatAMANcorps();
            Console.WriteLine("IDF has been created");
        }

        private void creatAMANcorps()
        {
            Soldier newAMANcommander =  RecruitNewRandomSoldier();
            AMAN aman = new AMAN(newAMANcommander);
            base.AllCorps["AMAN"] = aman;
        }

        public void spotTerrorists(Hamas hamas)
        { 
            AMAN aman = (AMAN)AllCorps["AMAN"];
            aman.explorTerrorist(hamas);
        }

        public void printAllKnownTerorists()
        {
            AMAN aman = (AMAN)AllCorps["AMAN"];
            aman.printAllKnownTerorists();
        }

        public void creatAMANreport()
        {
            AMAN aman = (AMAN)AllCorps["AMAN"];
            aman.creatReport();
        }

        public void printALlAMANreports()
        {
            AMAN aman = (AMAN)AllCorps["AMAN"];
            aman.printALlReports();
        }

        public void printMostReportedTerorist()
        {
            AMAN aman = (AMAN)AllCorps["AMAN"];
            Soldier most_rported = aman.getMostReportedTerorist();
            if (most_rported != null)
            {
                Console.WriteLine("__________the most rported terrorist is:_______");
                most_rported.printSoldier();
            }
            else
            {
                Console.WriteLine("AMAN doesnt know any terrorist yet");
            }
        }
    }
}
