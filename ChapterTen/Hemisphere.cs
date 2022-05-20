namespace VisualCSharpHowToProgram.ChapterTen;

public class Hemisphere
{
    private readonly float _radius;
    private double Volume => (2 * Math.PI * Math.Pow(Radius, 3)) / 3;
    private double CurvedSurfaceArea => 2 * Math.PI * Math.Pow(Radius, 2);
    private double TotalSurfaceArea => 3 * Math.PI * Math.Pow(Radius, 2);
    public float Radius
    {
        get => _radius;
        private init
        {
            if (value is < 0.0f or > 12.0f)
            {
                throw new ArgumentOutOfRangeException(nameof(value), value, $"{nameof(Radius)} " +
                    $"must be more than 0 and less than 12");
            }
            _radius = value;
        }
    }

    public Hemisphere(float radius=1.0f)
    {
        Radius = radius;
    }


    public override string ToString() => $"Radius: {Radius}, Volume: {Volume:N}, " +
                                         $"CurvedArea: {CurvedSurfaceArea:N}, TotalArea: {TotalSurfaceArea:N}";
}
