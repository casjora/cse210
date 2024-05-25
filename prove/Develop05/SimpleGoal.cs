public class SimpleGoal:Goal{
    //Atributes
    private bool _isComplete;
    //COnstructor
    public SimpleGoal (string name,string description,int points) :base(name,description,points)
    {
        _isComplete = false;
    }

    public override int RecordEvent(){
        //If we previously not complete,
        //then mark complete and return points
        if (!_isComplete)
        {
            _isComplete = true;
            return _points;
        }
        
        //if we were complete

        
        return 0;
    }

    public override bool isComplete(){
        //Return whether ths goal is complete or not
        return _isComplete;
    }

    public override string GetStringRepresentation(){
        return $"SimpleGoal|{_shortName}|{_description}|{_points}|{_isComplete}";
    }   
    public override string GetDetailsString()
    {
        return $"[{(_isComplete ? "X" : " ")}] {_shortName}: {_description}";
    }
}