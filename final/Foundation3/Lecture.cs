using System;


class Lecture : Event{

    private string _speaker;

    private int _capacity;


    public Lecture(string title, string description, string date, string time, string address, string speaker, int capacity){

        _eventTitle = title;

        _description = description;

        _date = date;

        _time = time;

        _address = address;

        _speaker = speaker;

        _capacity = capacity;
    }


    public void DisplayFull(){

        Console.WriteLine($"Lecture Title: {_eventTitle}\nSpeaker: {_speaker}\nWhen: {_date} at {_time}\n Come to {_address} and there are only {_capacity} seats available!\n -- {_description}");

    }

    public void ShortDescription(){

        base.DisplayShort("Lecture");

    }


    public void StandardDescription(){

        base.DisplayStandard();
    }


}