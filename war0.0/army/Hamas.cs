using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace War
{
    public class Hamas : ArmyForce
    {
        public Hamas(string establishedYear = "1987" , Soldier curentCommander = null , Dictionary<string, Corps> allCorps = null) : base(establishedYear, curentCommander, allCorps)
        {
            Console.WriteLine("Hamas was created");
        }

        public  List<Soldier> GetRandomTerrorists()
        {
            List<Soldier> terrorists = new List<Soldier>();
            Random rnd = new Random();
            foreach (Soldier terrorist in base.AllSoldiers)
            {
                int rnom_num = rnd.Next(1, 10);
                if (rnom_num == 1)
                {
                    terrorists.Add(terrorist);
                    System.Threading.Thread.Sleep(1000);
                }
            }
            return terrorists;
        }
    }
}
