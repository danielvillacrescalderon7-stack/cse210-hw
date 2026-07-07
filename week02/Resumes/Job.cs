public class Job
{
    //Job Variables
    public string _company = "";
    public string _jobTitle = "";
    public int _startYear;
    public int _endYear;

    // Way to show the Job
    public void Display()
    {
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}