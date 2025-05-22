namespace War;

public class Person : PhysicalEntity
{
    protected string Name;
    protected int Age;
    protected bool IsAlive;
    protected int LiveRange;

    public Person(float weight = 1, string name = "anonymous", int age = 0, bool live = true, int liveRange = 1)
    : base(weight)
    {
        Name = name;
        Age = age;
        IsAlive = live;
        LiveRange = liveRange;
    }
}