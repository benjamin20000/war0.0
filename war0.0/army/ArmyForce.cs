namespace War0._0.army
{

    public abstract class ArmyForce
    {
        private string EstablishedYear;
        private string CurentCommander;
        private List<string> AllCorps;

        public ArmyForce(string establishedYear, string curentCommander, List<string> allCorps)
        {
            this.EstablishedYear = establishedYear;
            this.CurentCommander = curentCommander;
            this.AllCorps = allCorps;
        }
        
        public void attack()
        {
            Console.WriteLine("Start an attack!!");
        }
    }
}