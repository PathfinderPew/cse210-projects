<<<<<<< HEAD
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create two job instances
        Job job1 = new Job();
        job1._jobTitle = "IT Specialist";
        job1._company = "Columbia College";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "IT Specialist";
        job2._company = "Vivint";
        job2._startYear = 2021;
        job2._endYear = 2023;

        // Display job details using Display method
        job1.Display();
        job2.Display();

        // Create a resume instance and add jobs
        Resume myResume = new Resume();
        myResume._personName = "Brandon Pew";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume details using Display method
        myResume.Display();
    }
}
=======
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Create two job instances
        Job job1 = new Job();
        job1._jobTitle = "IT Specialist";
        job1._company = "Columbia College";
        job1._startYear = 2015;
        job1._endYear = 2018;

        Job job2 = new Job();
        job2._jobTitle = "IT Specialist";
        job2._company = "Vivint";
        job2._startYear = 2021;
        job2._endYear = 2023;

        // Display job details using Display method
        job1.Display();
        job2.Display();

        // Create a resume instance and add jobs
        Resume myResume = new Resume();
        myResume._personName = "Brandon Pew";
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        // Display resume details using Display method
        myResume.Display();
    }
}
>>>>>>> 50703103753cead6e77f66e239df86a9f2736518
