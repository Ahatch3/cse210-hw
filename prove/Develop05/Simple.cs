

public class Simple : Goal{

    private Boolean _isCompleted = false;

    public Simple(string name, int points_earned, string description):base(name, points_earned, description){


    }

    public override void Display()
    {
        if (_isCompleted == true){
            Console.WriteLine($"[X] {_Name} ({_Description}) {_PointsEarned} Points");
        }
        else{
            Console.WriteLine($"[ ] {_Name} ({_Description}) {_PointsEarned} Points");
        }
    }

    public override string Save()
    {
        return $"Simple~{_Name}~{_Description}~{_PointsEarned}~{_isCompleted}";
    }

    public override int RecordEvent()
    {
        if (_isCompleted == true){
            Console.WriteLine("This goal has been completed.");

            return 0;
        }
        else{
            Console.WriteLine("Good job on completing this goal!");

            _isCompleted = true;

            return _PointsEarned;
        }

    }
}