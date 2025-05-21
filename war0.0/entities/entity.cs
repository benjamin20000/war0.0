namespace War0._0.entetis;

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