public class Address
{
    private string _postAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string postAddress, string city, string state, string country)
    {
        _postAddress = postAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    public string DisplayAddress()
    {
        return $"{_postAddress}, {_city}, {_state}, {_country}";
    }
}