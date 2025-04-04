using System;

class Event{

    protected string _eventTitle;

    protected string _description;

    protected string _date;

    protected string _time;

    protected string _address;



    protected void DisplayStandard(){

        Console.WriteLine($"Title: {_eventTitle}\nWhen: {_date} at {_time}\n Come to {_address}\n -- {_description}");

    }

    protected void DisplayShort(string eventType){

        Console.WriteLine($"Event Type: {eventType}");
        Console.WriteLine($"Title: {_eventTitle}");
        Console.WriteLine($"Date: {_date}");

    }



}