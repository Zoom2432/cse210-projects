public class OutDoorGathering : Event
{
    private string _weather;

    public OutDoorGathering(string name, string description, string date, string time, Address address, string weather) : base("OutDoor gathering", name, description, date, time, address)
    {
        _weather = weather;
    }

    public override string FullInf()
    {
        return $"{_name}\n{_description}\n{_weather}\n{_date} {_time}\n{_address.DisplayAddress()}";
    }
}