public class Running : Activity
{
    private double _distance;

    public Running(string date, int length, double distance) : base("Running", date, length)
    {
        _distance = distance;
    }

    public override double Speed()
    {
        return _distance / GetLength() * 60;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Pace()
    {
        return Math.Round(GetLength() / _distance, 2);
    }
}