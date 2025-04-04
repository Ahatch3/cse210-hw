using System;


class Outdoor : Event{

    private string _weather;


    public Outdoor(string title, string description, string date, string time, string address, string weather){

        _eventTitle = title;

        _description = description;

        _date = date;

        _time = time;

        _address = address;

        _weather = weather;
    }


    public void DisplayFull(){

        Console.WriteLine($"Outdoor Gathering Title: {_eventTitle}\nWhen: {_date} at {_time}\n Come to {_address}. Be prepared for {_weather} \n -- {_description}");

    }

    public void ShortDescription(){

        base.DisplayShort("Outdoor");

    }

        public void StandardDescription(){

        base.DisplayStandard();
    }


}