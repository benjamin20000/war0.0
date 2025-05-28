using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace War
{
    internal class HeavyUnit : PhysicalEntity
    {
        public int maxHmmo; // max ammo for heavy unit
        public int totalAmmo; // total ammo for heavy unit
        public string ammoType; // ammo type for heavy unit
        public float maxFuel; // max fuel for heavy unit
        public float totalFuel; // total fuel for heavy unit
        public float speed; // speed for heavy unit
        public float maxSpeed; // max speed for heavy unit

        public HeavyUnit(float weight, string location, float speed, float maxSpeed, int maxHmmo, int totalAmmo, string ammoType, float maxFuel, float totalFuel)
            : base(weight, location, speed, maxSpeed)
        {
            this.maxHmmo = maxHmmo;
            this.totalAmmo = totalAmmo;
            this.ammoType = ammoType;
            this.maxFuel = maxFuel;
            this.totalFuel = totalFuel;
        }
        
        public void Shoot()
        {
            if (totalAmmo > 0)
            {
                Console.WriteLine($"Shooting {ammoType} BOOOM..");
                totalAmmo--;
            }
            else
            {
                Console.WriteLine($"No enough bullets..");
            }
        }
    }
}
