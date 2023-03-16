namespace DesignPatterns.Adapter;

public class SquarePeg
{
    private int _width;

    // Constructor.
    public SquarePeg(int width)
    {
        _width = width;
    }
    
    // Return the width of this peg.
    public int GetWidth()
    {
        return _width;
    }
}