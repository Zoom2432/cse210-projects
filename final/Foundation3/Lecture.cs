public class Lecture : Event
{
    private string _speaker;
    private string _jobTitle;

    public Lecture(string name, string description, string date, string time, Address address, string speaker, string jobTitle) : base("Lecture", name, description, date, time, address)
    {
        _speaker = speaker;
        _jobTitle = jobTitle;
    }

    public override string FullInf()
    {
        return $"{_name}\n{_description}\n{_speaker}\n{_jobTitle}\n\n{_date} {_time}\n{_address.DisplayAddress()}";
    }
}