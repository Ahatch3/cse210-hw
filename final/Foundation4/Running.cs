

class Running : Activity{


    private double _distance;


    public Running(string date, int time, double distance):base(date, time){

        _distance = distance;
    }



    public override void DisplaySummary(){

    Console.WriteLine($"{_date} Running ({_time} min)- Distance {GetDistance():F2}, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile");

}

    public override double GetSpeed(){

        double speed = _distance / (_time / 60.0);

        return speed;

    }

    public override double GetDistance(){

        return _distance;

    }

    public override double GetPace(){

        double pace = 60 / GetSpeed();

        Math.Round(pace);

        return pace;
        
    }

}