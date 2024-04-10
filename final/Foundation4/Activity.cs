public class Activity 
{
    private string _type;
    private string _date;
    private int _length;

    public Activity(string type, string date, int length)
    {
        _type = type;
        _date = date;
        _length = length;
    }

    public int GetLength()
    {
        return _length;
    }

    public virtual double Speed()
    {
        return 1;
    }

    public virtual double Distance()
    {
        return 1;
    }

    public virtual double Pace()
    {
        return 1;
    }

    public string GetSummary()
    {
        return $"{_date} {_type} ({_length} min): Distance - {Distance()} km, Speed - {Speed()} kph, Pace - {Pace()} min per km";
    }
}