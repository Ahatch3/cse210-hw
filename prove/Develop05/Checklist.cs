

public class Checklist : Goal{

    private int _totalCompletions;

    private int _currentCompletions = 0;


    public Checklist(string name, int points_earned, string description, int current_completions, int total_completions):base(name, points_earned, description){

        this._totalCompletions = total_completions;
    }

        public override void Display()
    {
        if (_totalCompletions == _currentCompletions){
            Console.WriteLine($"[{_totalCompletions}/{_totalCompletions}] {_Name} ({_Description}) {_PointsEarned} Points");
        }
        else{
            Console.WriteLine($"[{_currentCompletions}/{_totalCompletions}] {_Name} ({_Description}) {_PointsEarned} Points");
        }
    }

        public override string Save()
    {
        return $"Checklist~{_Name}~{_Description}~{_PointsEarned}~{_currentCompletions}~{_totalCompletions}";
    }


        public override int RecordEvent()
    {
        if (_currentCompletions == _totalCompletions){
            Console.WriteLine("This goal has been completed.");

            return 0;
        }
        else if (_currentCompletions < _totalCompletions){
            
            _currentCompletions += 1;

            Console.WriteLine($"Good job on completing this goal {_currentCompletions} times! ");

            return _PointsEarned;
        }
        else{
            Console.WriteLine("Invalid.");

            return 0;
        }

    }

}