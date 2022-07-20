namespace VisualCSharpHowToProgram.ChapterTen;

public class IntegerSet
{
    public bool[] IntSet { get; private set; }
    
    public IntegerSet()
    {
        IntSet = new bool[101];
    }


    public void InsertElement(int element)
    {
        if (element is < 0 or > 100)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            if (IntSet[element] == true)
            {
                Console.WriteLine($"{new ArgumentOutOfRangeException(nameof(element), element, $"{nameof(IntSet)} " + $"must be false. Already true at this place")}");
            }
            else
            {
                IntSet[element] = true;
            }
        }
    }

    public void DeleteElement(int element)
    {
        if (element is < 0 or > 100)
        {
            throw new ArgumentOutOfRangeException();
        }
        else
        {
            if (IntSet[element] == false)
            {
                throw new ArgumentException();
            }
            else
            {
                IntSet[element] = false;
            }
        }
    }

    public override string ToString()
    {
        var intSet = string.Empty;
        
        for (int i = 0; i < IntSet.Length; i++)
        {
            if (IntSet[i])
            {
                intSet = string.Concat(intSet, " ", i.ToString());
            }
        }

        return intSet;
    }
}