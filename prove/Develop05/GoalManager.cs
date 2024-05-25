using System.Reflection;

public class GoalManager{
    private List<Goal>_goals;
    private int _score;

    public GoalManager(){
        _goals=new List<Goal>();
        _score=0;
        
    }

    public void Start(){
        //Display the main menu
        //Call: 
        //CreateGOal, ListGoalDetails,SaveGoals, LoadGOals,
        //RecordEvent
        //Loope until quit
        while (true)
        {
            Console.WriteLine("\nEternal Quest Menu:");
            Console.WriteLine("1. Display Player Info");
            Console.WriteLine("2. List Goal Names");
            Console.WriteLine("3. List Goal Details");
            Console.WriteLine("4. Create Goal");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Save Goals");
            Console.WriteLine("7. Load Goals");
            Console.WriteLine("8. Exit");
            Console.Write("Select an option: ");

            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    DisplayPlayerInfo();
                    break;
                case "2":
                    ListGoalNames();
                    break;
                case "3":
                    ListGoalDetails();
                    break;
                case "4":
                    CreateGoal();
                    break;
                case "5":
                    RecordEvent();
                    break;
                case "6":
                    SaveGoals();
                    break;
                case "7":
                    LoadGoals();
                    break;
                case "8":
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
        }
    }


    public void DisplayPlayerInfo(){
        //Display the points
        Console.WriteLine($"\nPlayer's Score: {_score}");

    }

    public void ListGoalNames(){
        //Loop through the list of goals and display
        //the names (You may need another function in the goal class)
        Console.WriteLine("\nGoal Names:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void ListGoalDetails(){
        //Loop through the list of goals and display
        //full details
        Console.WriteLine("\nGoal Details:");
        foreach (var goal in _goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
    }

    public void CreateGoal(){
        //Ask the user what goal they want
        //display a sub menu to select goal type
        //Ask for the name, description and points
        //Ask for more if they pick checklist goal

        //Create the object SimpleGoal sg = new SimpleGoal("Rafael","Simple Game",2);
        //add the object to the goal list
        Console.WriteLine("\nCreate a new goal:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Select the type of goal: ");
        var typeChoice = Console.ReadLine();

        Console.Write("Enter the goal name: ");
        var name = Console.ReadLine();
        Console.Write("Enter the goal description: ");
        var description = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        var points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                _goals.Add(new SimpleGoal(name, description, points));
                break;
            case "2":
                _goals.Add(new EternalGoal(name, description, points));
                break;
            case "3":
                Console.Write("Enter the target count: ");
                var target = int.Parse(Console.ReadLine());
                Console.Write("Enter the bonus points: ");
                var bonus = int.Parse(Console.ReadLine());
                _goals.Add(new ChecklistGoal(name, description, points, target, bonus));
                break;
            default:
                Console.WriteLine("Invalid choice, goal not created.");
                break;
        }
    }

    public void RecordEvent(){
        //Displau a list of all the goal names
        // Ask user to select a goal
        //Call RecordEvent on the correct 
        //Update the score based on the points
        //Display current points
        Console.WriteLine("\nRecord an event for a goal:");
        ListGoalNames();
        Console.Write("Select the goal number: ");
        var goalNumber = int.Parse(Console.ReadLine()) - 1;

        if (goalNumber >= 0 && goalNumber < _goals.Count)
        {
            var goal = _goals[goalNumber];
            var pointsEarned = goal.RecordEvent();
            _score += pointsEarned;
            Console.WriteLine($"You earned {pointsEarned} points.");
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
        }
    }

    public void SaveGoals()
    {
        //Ask user for file name
        //Loop through the goals and save the string
        Console.Write("Enter the filename to save the goals: ");
        var filename = Console.ReadLine();
        using (var writer = new StreamWriter(filename))
        {
            writer.WriteLine(_score);
            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Goals saved successfully.");
    }

    public void LoadGoals(){
        //ask for a file name
        //read each line and split it up
        //use the parts to re-create the Goal object
        Console.Write("Enter the filename to load the goals: ");
        var filename = Console.ReadLine();
        if (File.Exists(filename))
        {
            using (var reader = new StreamReader(filename))
            {
                _score = int.Parse(reader.ReadLine());
                _goals.Clear();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split('|');
                    switch (parts[0])
                    {
                        case "SimpleGoal":
                            var simpleGoal = new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]));
                            if (bool.Parse(parts[4])) simpleGoal.RecordEvent(); // Mark it complete if it was complete
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                            break;
                        case "ChecklistGoal":
                            var checklistGoal = new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[5]), int.Parse(parts[6]))
                            {
                                _amountCompleted = int.Parse(parts[4])
                            };
                            _goals.Add(checklistGoal);
                            break;
                    }
                }
            }
            Console.WriteLine("Goals loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

}