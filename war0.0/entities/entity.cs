namespace War;

public abstract class PhysicalEntity
{
    float weight;
    string location;
    float speed;
    float MaxSpeed;

    protected PhysicalEntity(float weight)
    {
        this.weight = weight;
    }
}