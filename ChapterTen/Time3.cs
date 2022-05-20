namespace VisualCSharpHowToProgram.ChapterTen;

public class Time3
{
    private int _hour;
    private int _min;
    private int _second;

    public Time3(int seconds)
    {
        var timeSpan = new TimeSpan(0, 0, 0, seconds);
        this._hour = timeSpan.Hours;
        this._min = timeSpan.Minutes;
        this._second = timeSpan.Seconds;
    }

    public Time3(Time3 time) : this( time._second) { }


    public int Seconds() => (int)new TimeSpan(0, _hour, _min, _second).TotalSeconds;
}