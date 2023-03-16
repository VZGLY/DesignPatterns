namespace DesignPatterns.Adapter;

public class RoundHole
{
    private int _radius;

    
    // Constructor.
    public RoundHole(int radius)
    {
        _radius = radius;
    }

    // Return the radius of this hole.
    int GetRadius()
    {
        return _radius;
    }
    
    
    // Determine if this hole "fits" a peg.
    public bool FitsPeg(RoundPeg peg)
    {
        return GetRadius() >= peg.GetRadius();
    }
}