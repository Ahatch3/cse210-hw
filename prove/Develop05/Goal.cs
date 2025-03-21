
using System.ComponentModel.DataAnnotations;

public abstract class Goal{

    protected string _Name;

    protected int _PointsEarned;

    protected string _Description;

    public Goal(string name, int points_earned, string description){
        this._Name = name;

        this._PointsEarned = points_earned;

        this._Description = description;
    } 


    public abstract void Display();

    public abstract int RecordEvent();

    public abstract string Save();

}