namespace VisualCSharpHowToProgram.ChapterTen;

public class DepreciatingValue
{
    private decimal _valueOfAsset;
    public static double AnnualDepreciationRate { get; private set; }
    public decimal ValueOfAsset
    {
        get => _valueOfAsset;
        private set
        {
            if (value >= 0.0m)
            {
                _valueOfAsset = value;
            }
        }
    }

    public DepreciatingValue(decimal valueOfAsset)
    {
        ValueOfAsset = valueOfAsset;
    }

    public DepreciatingValue(decimal valueOfAsset, double annualDepreciationRate)
    {
        AnnualDepreciationRate = annualDepreciationRate/100;
        ValueOfAsset = valueOfAsset;
    }

    public static void ChangeRate(double rate)
    {
        if (rate > 0.0)
        {
            AnnualDepreciationRate = rate / 100;
        }
        else
        {
            Console.WriteLine($"{new ArgumentOutOfRangeException(nameof(rate), rate, $"{nameof(AnnualDepreciationRate)} " + $"must be more than 0 and less than 100")}");
        }
    }

    private decimal DeprecatedValue() => ValueOfAsset - (ValueOfAsset * (decimal)AnnualDepreciationRate);

    public void ChangeValue()
    {
        if (DeprecatedValue() >= 0.0m)
        {
            ValueOfAsset = DeprecatedValue();
        }
        else
        {
            Console.WriteLine($"{new ArgumentOutOfRangeException(nameof(ValueOfAsset), ValueOfAsset, "Value can't be lower than zero")}");
        }
    }
}