using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace War
{
    public class Hamas : ArmyForce
    {
        public Hamas(string establishedYear = "1987" , Soldier curentCommander = null , List<Corps> allCorps = null) : base(establishedYear, curentCommander, allCorps)
        {
            Console.WriteLine("Hamas was created");
        }
    }
}
