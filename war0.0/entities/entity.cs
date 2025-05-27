namespace War;

public abstract class PhysicalEntity
{
    protected float Weight;
    protected string Location;   //TODO Make the type of location Location
    protected float Speed;
    protected float MaxSpeed;

    protected PhysicalEntity(float weight , string location, float speed, float maxSpeed)
    {
        this.Weight = weight;
        this.Location = location;
        this.Speed = speed;
        this.MaxSpeed = maxSpeed;
    }
}