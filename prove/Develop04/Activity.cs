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
        //Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        //Prompt for the duration
        ShowSpinner(5);
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Closing Message");
        ShowSpinner(5);
        //Console.Clear();

    }

    public void ShowSpinner(int seconds)
    {
        Console.WriteLine("Spinner!");

    }

    public void ShowCountDown(int seconds)
    {
        for (int i=1; i<seconds;i++){
            Console.WriteLine(i);
            Thread.Sleep(700);
        }
        Console.WriteLine("Countdown");
    }

}