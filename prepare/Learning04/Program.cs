using System;

class Program
{
    //comment
    static void Main(string[] args)
    {
        Assignment assignment1 = new Assignment();
        assignment1.SetStudentName("Jose");
        assignment1.SetTopic($"Calculating cubic roots");
        Console.WriteLine(assignment1.GetSummary());
        MathAssignment math1 = new MathAssignment("Jose","Exponents","7.3","8-19");
        Console.WriteLine(math1.GetHomeworkList());
        WritingAssigment wrAssing = new WritingAssigment("Mary Waters","European History","The Causes of WW2");
        Console.WriteLine(wrAssing.GetWritingInformation());


    }
}