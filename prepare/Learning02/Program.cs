using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job_one = new Job();
        job_one.jobTitle = "Software Engineer";
        job_one.company = "Microsoft";
        job_one.startYear = 2019;
        job_one.endYear =  2022;

        Job job_two = new Job();
        job_two.jobTitle = "Manager"
        job_two.company = "Apple"
        job_two.startYear = 2022
        job_two.endYear = 2023

        Resume myResume = new Resume();
        myResume.name = "Allison Rose";

        myResume.jobs.Add(job_one);
        myResume.job.Add(job_two);

        myResume.Display();
    }
}

class Job{
   public string company;
   public string jobTitle;

}

class Resume{
    public string name;

    public List<Job> _job = new List<Job>();

    public void Display(){
        Console.WriteLine($"Name: {name}");
        Console.WriteLine("Jobs:");

        foreach (Job job in _job)
        {job.Display();
            
        }
    }



}