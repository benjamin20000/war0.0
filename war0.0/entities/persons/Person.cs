namespace War0._0.entetis;

public class Person : PhysicalEntity
{
    private string Name;
    private int Age;
    private bool Live;
    private int LiveRange;

    public Person(float weight, string name = "anonymous", int age = 0, bool live = true, int liveRange = 1)
    : base(weight)
    {
        Name = name;
        Age = age;
        Live = live;
        LiveRange = liveRange;
    }
}