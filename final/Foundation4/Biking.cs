


class Biking : Activity{

    private double _speed;


    public Biking(string date, int time, double speed):base(date, time){

        _speed = speed;

    }


public override void DisplaySummary(){

    Console.WriteLine($"{_date} Biking ({_time} min)- Distance {GetDistance():F2}, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile");

}

public override double GetSpeed(){

    return _speed;

}

public override double GetDistance(){

    double distance = _speed * (_time/60.0);

    return distance;

}

public override double GetPace(){

    double pace = 60 / _speed;

    Math.Round(pace);

    return pace;

}
}