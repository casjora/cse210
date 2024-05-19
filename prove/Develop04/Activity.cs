using System;

public class Activity{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name="";
        _description="";
        _duration=0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}\n{_description}");
        Console.WriteLine("How many seconds do you want the activity to last?");
        int duration = int.Parse(Console.ReadLine());
        _duration=duration;
        Console.WriteLine($"Get ready");
        //Prompt for the duration
        ShowSpinner(10);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine($"Congrats!! you completed {_name} for {_duration} seconds.");
        ShowSpinner(5);
        //Console.Clear();

    }

    public void ShowSpinner(int seconds)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("┌");
        animationStrings.Add("┐");
        animationStrings.Add("┘");
        animationStrings.Add("└");

        
        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(seconds);
        int i =0;
        while(DateTime.Now<stopTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i=i+1;

            if(i >= animationStrings.Count)
            {
                i=0;
            }
        }
        


    }

    public void ShowCountDown(int seconds)
    {
        for (int j=1; j<=seconds;j++)
        {
            Console.Write(j);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            j=j++;
        }    
    }

}