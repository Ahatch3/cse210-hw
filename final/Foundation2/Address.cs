


using System.Collections.Concurrent;

public class Address{

    private string streetAddress;

    private string city;

    private string state;

    private string country;


    public Address(string streetAddress, string city, string state, string country){

        this.streetAddress = streetAddress;
        this.city = city;
        this. state = state;
        this.country = country;
    }

    public bool IsUS(){
        if (country == "US"){
        return true;
        }
        else{
            return false;
        }
    }

    public string DisplayAddress(){

        return $"{streetAddress}, {city}, {state}, {country}";

    }
}