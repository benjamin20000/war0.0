using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace War
{
    public class IDF : ArmyForce
    {
        public IDF(string establishedYear = "1948", Soldier curentCommander = null, List<Corps> allCorps =null) : base(establishedYear, curentCommander, allCorps)
        {
            Console.WriteLine("IDF has been created");
        }

        public void creatAMANcorps()
        {
            Soldier newAMANcommander =  RecruitNewRandomSoldier();
            AMAN aman = new AMAN(newAMANcommander);
            base.AllCorps.Add(aman);
        }
    }
}
