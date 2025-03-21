


public class Eternal : Goal{

    public Eternal(string name, int points_earned, string description):base(name, points_earned, description){

    }


    public override void Display(){
        Console.WriteLine($"[∞] {_Name} ({_Description}) {_PointsEarned} Points");
    }
    

        public override string Save()
    {
        return $"Eternal~{_Name}~{_Description}~{_PointsEarned}";
    }


        public override int RecordEvent()
    {
        Console.WriteLine("Good job on completing this goal! Do it one more time!");

        return _PointsEarned;

    }

}