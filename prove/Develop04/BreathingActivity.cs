public class BreathingActivity:Activity {
    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "Descrip for the act of breathing";

    }

    public void Run() {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        //Have the user breathe in and out for 5s
        Console.WriteLine("Breathe In");
        ShowCountDown(5);


        Console.WriteLine("Breathe out");
        ShowCountDown(5);

        //Repeat with a loop



        DisplayEndingMessage();

    }
}