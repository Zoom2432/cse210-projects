public class WriteAssigment : Assigment
{
    private string _title;

    public WriteAssigment(string name, string topic, string title) : base(name, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}