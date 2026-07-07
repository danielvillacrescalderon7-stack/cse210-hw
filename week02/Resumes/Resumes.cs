using System;
using System.Collections.Generic;

public class Resume
{
    //User Name
    public string _name = "";

    // List of Jobs
    public List<Job> _jobs = new List<Job>();

    // Show the resume
    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _jobs)
        {
            job.Display();
        }
    }
}