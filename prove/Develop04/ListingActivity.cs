public class ListingActivity : Activity{
    protected int _count;
    protected List<string>_prompts=new List<string>(){
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity ()
    {
        _name="Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count=0;
    }

    public void Run()
    {
    DisplayStartingMessage();
    GetRandomPrompt();
    ShowSpinner(3);
    DateTime endTime = DateTime.Now.AddSeconds(_duration);
    while (DateTime.Now < endTime)
    {
        if(DateTime.Now >=endTime)
            break;
        List<string> userList = GetListFromUser();
        _count = userList.Count;

        Console.WriteLine($"You have listed {_count} items:");
        foreach (var prompt in userList)
        {
            
            Console.WriteLine($"- {prompt}");
        }
        ShowSpinner(3);
    }

        DisplayEndingMessage();
}

    public void GetRandomPrompt(){
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);

    }

public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        Console.WriteLine("Please enter items for the list. Type 'done' to finish.");


        DateTime stopTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now<stopTime)
        {
            Console.Write("Enter an item: ");
            string input = Console.ReadLine();
            
            
            if (!string.IsNullOrWhiteSpace(input))
            {
                userList.Add(input);
            }
            else
            {
                break;
            }
        }

        return userList;
    }

}