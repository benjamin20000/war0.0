namespace War
{

    public abstract class ArmyForce
    {
        public string EstablishedYear {get;}
        protected Soldier CurentCommander;
        protected Dictionary<string ,Corps> AllCorps;
        protected List<Soldier> AllSoldiers = new List<Soldier>();

        public ArmyForce(string establishedYear = null, Soldier curentCommander = null, Dictionary<string, Corps> allCorps = null)
        {
            this.EstablishedYear = establishedYear ?? "2000";
            this.AllCorps = allCorps ?? new Dictionary<string, Corps>();
            this.CurentCommander = curentCommander ?? Soldier.CreateRandomSoldier();
            if (!this.AllSoldiers.Contains(this.CurentCommander))
            {
                this.AllSoldiers.Add(this.CurentCommander);
            }

            
        }
        public void AppointNewCommander(Soldier newCommander = null)
        {
            if (newCommander == null)
            {
                Soldier commander = Soldier.CreateRandomSoldier();
                CurentCommander = commander;
            }
            else
            {
                CurentCommander = newCommander;
            }
        }
        
        public void printArmyInpo()
        {
            Console.WriteLine("Army Info: ");
            Console.WriteLine($"the army establish at {EstablishedYear}  ");
            Console.Write($"the current commander is: ");
            this.CurentCommander.printSoldier();
            Console.WriteLine($"the army contain {this.AllCorps.Count} corps");
            Console.WriteLine($"the army contain {this.AllSoldiers.Count} soldiers");
        }

        public void RecruitRandomSoldiers(int amount_of_soldiers, Corps corps = null)
        {
            if (corps == null)
            {
                for (int i = 0; i < amount_of_soldiers; i++)
                {
                    AllSoldiers.Add(Soldier.CreateRandomSoldier());
                }
            }
            else
            {
                for (int i = 0; i < amount_of_soldiers; i++)
                {
                    Soldier newSoldier = Soldier.CreateRandomSoldier();
                    AllSoldiers.Add(newSoldier);
                    corps.addNewSoldier(newSoldier);
                }
            }
           
        }

        public Soldier RecruitNewRandomSoldier()
        {
            Soldier randomSoldier = Soldier.CreateRandomSoldier();
            this.AllSoldiers.Add(randomSoldier);
            return randomSoldier;
        }
        
        public void attack()
        {
            Console.WriteLine("Start an attack!!");
        }

        public void ArmamentSoldier(Soldier soldier)
        {
            Knife knife = new Knife();
            Gun gun = new Gun();
            Rifle rifle = new Rifle();
            soldier.addWeapon(knife);
            soldier.addWeapon(gun);
            soldier.addWeapon(rifle);
        }

        public void ArmamentArmy()
        {
            foreach (var soldier in this.AllSoldiers)
            {
                ArmamentSoldier(soldier);
            }
        }

        public void RandomlyArmament(Weapon weapon, int amount)
        {
            if (AllSoldiers.Count < 1)
            {
                return;
            }
            Random rnd = new Random();
            while (amount > 0)
            {
                int randSold = rnd.Next(0, this.AllSoldiers.Count-1); 
                AllSoldiers[randSold].addWeapon(weapon);
                amount--;
            }
        }
    }
}