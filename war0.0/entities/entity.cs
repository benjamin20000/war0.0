namespace War;

public abstract class PhysicalEntity
{
    protected float Weight;
    protected string Location;   //TODO Make the type of location Location
    protected float Speed;
    protected float MaxSpeed;

    protected PhysicalEntity(float weight)
    {   
        this.Weight = weight;
    }
}