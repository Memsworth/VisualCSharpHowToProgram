namespace VisualCSharpHowToProgram.ChapterTen;

public class IntegerSet
{
    private bool[] _intSet;

    public bool[] IntSet
    {
        get => _intSet;
        private set
        {
            
        }
    }
    
    public IntegerSet()
    {
        _intSet = new bool[101];
    }


    public void InsertElement(int element)
    {
        if (element is >0  and < 100)
        {
            throw new ArgumentOutOfRangeException();
        }
    }
}