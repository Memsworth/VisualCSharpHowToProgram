namespace VisualCSharpHowToProgram.ChapterTen;



// Lazy Solution. Come back to write better quality code
public static class RationalNumbersTest
{
    public static void RunProgram()
    {
        var myRation = new RationalNumbers(1, 2);
        var myRation2 = new RationalNumbers(1 / 2);
        Console.WriteLine(myRation2);
        Console.WriteLine(Divide(myRation,myRation).DisplayFloat());
    }



    //Later one check to over-ride operator
    private static RationalNumbers Add(RationalNumbers one, RationalNumbers two)
    {
        int n, m;
        if (one.Denominator ==  two.Denominator)
        {
            n = one.Numerator + two.Numerator;
            m = one.Denominator;
        }
        else
        {
            n = one.Numerator + (two.Numerator * one.Denominator);
            m = one.Denominator * two.Denominator;
        }

        return new RationalNumbers(n, m);
    }

    private static RationalNumbers Subtract(RationalNumbers one, RationalNumbers two)
    {
        int n, m;
        if (one.Denominator == two.Denominator)
        {
            n = one.Numerator - two.Numerator;
            m = one.Denominator;
        }
        else
        {
            n = one.Numerator - (two.Numerator * one.Denominator);
            m = one.Denominator * two.Denominator;
        }

        return new RationalNumbers(n, m);   
    }

    private static RationalNumbers Multiply(RationalNumbers one, RationalNumbers two)
    {
        var n = one.Numerator * two.Numerator;
        var m = one.Denominator * two.Denominator;
        
        return new RationalNumbers(n, m);
    }
    private static RationalNumbers Divide(RationalNumbers one, RationalNumbers two)
    {
        var n = one.Numerator * two.Denominator;
        var m = one.Denominator * two.Numerator;
        
        return new RationalNumbers(n, m);
    }

}