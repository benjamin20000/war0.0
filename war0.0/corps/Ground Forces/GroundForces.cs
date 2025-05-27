using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public  class GroundForces : Corps 
    {
        public GroundForces(Soldier comander, List<Soldier> soldiers, List<string> tools) : base(comander, soldiers, tools)
        {
           

        }                   

        public void attack()
        {
            Console.WriteLine("Start an attack!!");
        }
    }
}
