public class PromptGenerator
{
    public List<string> _prompts;// = new List<string>();
    /*
    This was an attempt to create a constructor
    public PromptGenerator(List<string> prompts1)
    {
        prompts1=_prompts;
 
    }*/
 
   
   
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>()
        {
         "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
 
        };
        Random random = new Random(); //iniciate a random number generator
        int randomindexNum = random.Next(prompts.Count);//Get a random index
        _prompts = prompts;//Assign th random promp
       
        return _prompts[randomindexNum];
    }
}