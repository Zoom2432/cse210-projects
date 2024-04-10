public class Swimming : Activity
{
    private int _numberOfLaps;

    public Swimming(string date, int length, int numberOfLaps) : base("Swimming", date, length)
    {
        _numberOfLaps = numberOfLaps;
    }

        public override double Speed()
    {
        return Distance() / GetLength() * 60;
    }

    public override double Distance()
    {
        return _numberOfLaps * 50 / 1000;
    }

    public override double Pace()
    {
        return Math.Round(60 / Speed(),2);
    }
}