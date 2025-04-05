


class Swimming : Activity{


    private int _numLaps;


    public Swimming(string date, int time, int numLaps):base(date, time){

        _numLaps = numLaps;
    }



    public override void DisplaySummary(){

    Console.WriteLine($"{_date} Swimming ({_time} min)- Distance {GetDistance():F2}, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile");

    }

    public override double GetSpeed(){

        double speed = GetDistance() / (_time / 60.0);

        return speed;

    }

    public override double GetDistance(){

        double distance = _numLaps * 50.0 / 1000.0 * 0.62;

        return distance;
    }

    public override double GetPace(){

        double pace = 60 / GetSpeed();

        Math.Round(pace);

        return pace;
        
    }
}