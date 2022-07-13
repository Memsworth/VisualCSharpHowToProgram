namespace VisualCSharpHowToProgram.ChapterTen;

public class Hemisphere
{
    private readonly double _radius;
    private double Volume => (2 * Math.PI * Math.Pow(Radius, 3)) / 3;
    private double CurvedSurfaceArea => 2 * Math.PI * Math.Pow(Radius, 2);
    private double TotalSurfaceArea => 3 * Math.PI * Math.Pow(Radius, 2);
    public double Radius
    {
        get => _radius;
        private init
        {
            if (value is < 0.0 or > 12.0)
            {                
                Console.WriteLine($"{new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Radius)} " + $"must be more than 0 and less than 12")}");
                _radius = 1.0;
            }
            else
            {
                _radius = value;
            }
        }
    }

    public Hemisphere(double radius=1.0)
    {
        Radius = radius;
    }


    public override string ToString() => $"Radius: {Radius}, Volume: {Volume:N}, " +
                                         $"CurvedArea: {CurvedSurfaceArea:N}, TotalArea: {TotalSurfaceArea:N}";
}
