namespace DesignPatterns.Adapter;

public class RoundPeg
{
    private int _radius;

    // Constructor.
    protected RoundPeg(){}
    
    // Constructor.
    public RoundPeg(int radius)
    {
        _radius = radius;
    }

    // Return the radius of this peg.
    public virtual int GetRadius()
    {
        return _radius;
    }
}