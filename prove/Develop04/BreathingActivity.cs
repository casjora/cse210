public class BreathingActivity:Activity {
    public BreathingActivity() {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";

    }

    public void Run() {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        DateTime stopTime = startTime.AddSeconds(_duration);
        
        do {
            //Have the user breathe in and out for 5s
            Console.Write("Breathe In... ");
            ShowCountDown(5);
            Console.WriteLine();


            Console.Write("Breathe out... ");
            Console.WriteLine();
            ShowCountDown(5);

            //Repeat with a loop

        }
        while
        (DateTime.Now < stopTime);



        DisplayEndingMessage();

    }
}