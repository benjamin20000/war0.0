namespace War;

public class Knife : Weapon
{
    private float length;
    private float sharpness;

    public Knife(float weight = 2, float length = 5, float sharpness=1) : base(1, weight)
    {
        this.length = length;
        this.sharpness = sharpness;
    }
}