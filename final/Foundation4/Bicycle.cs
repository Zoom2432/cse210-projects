public class Bicycle : Activity
{
    private double _speed;

    public Bicycle(string date, int length, double speed) : base("Bicycle", date, length)
    {
        _speed = speed;
    }

    public override double Speed()
    {
        return _speed;
    }

    public override double Distance()
    {
        return _speed / 60 * GetLength();
    }

    public override double Pace()
    {
        return Math.Round(60 / _speed,2);
    }
}