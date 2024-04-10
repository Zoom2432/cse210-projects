public class Reception : Event
{
    private string _email;

    public Reception(string name, string description, string date, string time, Address address, string email) : base("Reception", name, description, date, time, address)
    {
        _email = email;
    }

    public override string FullInf()
    {
        return $"{_name}\n{_description}\n{_email}\n{_date} {_time}\n{_address.DisplayAddress()}";
    }
}