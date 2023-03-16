namespace DesignPatterns.Adapter;

public class SquarePegAdapter : RoundPeg
{
    
    private SquarePeg _peg;

    // Constructor with object to adapt in params.
    public SquarePegAdapter(SquarePeg peg)
    {
        _peg = peg;
    }
    
    
    // Overrided method adapted for a SquarePeg.
    public override int GetRadius()
    {
        return _peg.GetWidth() * (int) Math.Sqrt(2) / 2;
    }
    
}