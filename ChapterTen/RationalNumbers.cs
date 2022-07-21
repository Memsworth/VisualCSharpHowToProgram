namespace VisualCSharpHowToProgram.ChapterTen;

public class RationalNumbers
{
    private int _denominator;
    public int Numerator { get; private set; }

    public int Denominator
    {
        get => _denominator;
        private set
        {
            if (value == 0)
            {
                throw new DivideByZeroException("Can't be zero");
            }

            _denominator = value;
        }
    }

    public RationalNumbers(int numerator, int denominator)
    {
        Numerator = numerator / Gcd(numerator, denominator);
        Denominator = denominator / Gcd(numerator, denominator);
        
    }

    public RationalNumbers(int numerator)
    {
        Numerator = numerator;
        Denominator = 1;
    }

    public RationalNumbers()
    {
        Numerator = 1;
        Denominator = 1;
    }

    
    private static int Gcd(int numerator, int denominator)
    {
        while (numerator != 0)
        {
            var remainder = denominator % numerator;
            denominator = numerator;
            numerator = remainder;
        }

        var gcd = denominator;
        return gcd;
    }


    public override string ToString() => $"{Numerator}/{Denominator}";
    public string DisplayFloat() => $"{Numerator / Denominator:N}";
}