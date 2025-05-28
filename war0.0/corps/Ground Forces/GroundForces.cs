using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    public  class GroundForces : Corps 
    {
        List<Weapon> weapons;

        public GroundForces(Soldier comander, List<Soldier> soldiers)
            : base(comander, soldiers)
        {
            this.weapons = new List<Weapon>();
        }
        public void attack()
        {
            Console.WriteLine("Start an attack!!");
        }
        
        // public fullAmmo

        public void askWeapon(int amount)
        {
            Console.WriteLine($"i need {amount} of weapon");
            Random rnd = new Random();
            int weaponAmount = rnd.Next(0, amount);
            for (int i = 0; i < weaponAmount; i++)
            {
                Weapon newWeapon = new Weapon();
                this.weapons.Add(newWeapon);
            }
        }
    }
}
