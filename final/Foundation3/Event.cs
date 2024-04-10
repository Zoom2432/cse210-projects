using System.Net.Sockets;

public class Event
{
    private string _type;
    protected string _name;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string type, string name, string description, string date, string time, Address address)
    {
        _type = type;
        _name = name;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public string ShortInf()
    {
        return $"{_type}\n{_name}\n{_date}";
    }

    public string StandartInf()
    {
        return $"{_name}\n{_description}\n{_date} {_time}\n{_address.DisplayAddress()}";
    }

    public virtual string FullInf()
    {
        return "";
    } 
}