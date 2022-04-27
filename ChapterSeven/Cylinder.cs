namespace VisualCSharpHowToProgram.ChapterSeven;

public class Cylinder
{
    //check back here
    public double Height { get; private set; }
    public double Radius { get; private set; }

    public Cylinder(double height, double radius)
    {
        Height = height;
        Radius = radius;
    }


    //Edit out so that this behaves like a static method
    public double CylinderVolume() => (Math.PI * Math.Pow(Radius, 2) * Height);
}