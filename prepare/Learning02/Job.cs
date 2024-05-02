using System;
public class Job
{
    

        //Defining state variables
        public string _jobTitle = "Hello,Hi";
        public string _company;
        public int _startYear;
        public int _endYear;

        public void Display ()
        {
            Console.WriteLine($"{_company} ({_jobTitle}) {_startYear}-{_endYear}");
        }


}