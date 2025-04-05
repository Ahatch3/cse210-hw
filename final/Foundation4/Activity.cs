


public abstract class Activity{


    protected string _date;

    protected int _time;


    public Activity(string date, int time){

        _date = date;

        _time = time;

    }



    public abstract void DisplaySummary();

    public abstract double GetSpeed();

    public abstract double GetDistance();

    public abstract double GetPace();

}