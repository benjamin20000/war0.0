namespace War
{

    public abstract class ArmyForce
    {
        public string EstablishedYear {get;}
        protected Soldier CurentCommander;
        protected List<Corps> AllCorps;
        protected List<Soldier> AllSoldiers = new List<Soldier>();

        public ArmyForce(string establishedYear = null, Soldier curentCommander = null, List<Corps> allCorps = null)
        {
            this.EstablishedYear = establishedYear ?? "2000";
            this.AllCorps = allCorps ?? new List<Corps>();
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

        public void RecruitRandomSoldiersToCorps(int amount_of_soldiers, Corps corp)
        {
            for (int i = 1; i < amount_of_soldiers; i++)
            {
                AllSoldiers.Add(Soldier.CreateRandomSoldier());
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
    }
}