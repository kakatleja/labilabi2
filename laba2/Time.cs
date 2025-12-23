public class Time
{
    private readonly int totalSeconds;

    public Time(int seconds)
    {
        totalSeconds = seconds % 86400;
    }

    public Time(int hours, int minutes, int seconds)
        : this(hours * 3600 + minutes * 60 + seconds)
    { }

    public int Hours => totalSeconds / 3600;
    public int Minutes => (totalSeconds % 3600) / 60;
    public int Seconds => totalSeconds % 60;

    public override string ToString()
    {
        return $"{Hours}:{Minutes:D2}:{Seconds:D2}";
    }
}
