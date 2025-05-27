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
            Console.WriteLine("IDF has been created");
        }

        public void creatAMANcorps()
        {
            Soldier newAMANcommander =  RecruitNewRandomSoldier();
            AMAN aman = new AMAN(newAMANcommander);
            base.AllCorps["AMAN"] = aman;
        }

        public void spotTerrorists(Hamas hamas)
        {
            if (AllCorps.ContainsKey("AMAN"))
            {
                AMAN aman = AllCorps["AMAN"] as AMAN;
                if (aman != null)
                {
                    aman.explorTerrorist(hamas);
                }
                else
                {
                    Console.WriteLine("AMAN corps exists but casting failed.");
                }
            }
            else
            {
                Console.WriteLine("AMAN corps not found in AllCorps.");
            }
        }
    }
}
