using System;
using System.ComponentModel.DataAnnotations;


class Reception : Event{

    private string _email;


    public Reception(string title, string description, string date, string time, string address, string email){

        _eventTitle = title;

        _description = description;

        _date = date;

        _time = time;

        _address = address;

        _email = email;
    }


    public void DisplayFull(){

        Console.WriteLine($"Reception Title: {_eventTitle}\nWhen: {_date} at {_time}\n RSVP to {_email}! Come to {_address}\n -- {_description}");

    }

    public void ShortDescription(){

        base.DisplayShort("Reception");

    }

    public void StandardDescription(){

    base.DisplayStandard();
    }


}