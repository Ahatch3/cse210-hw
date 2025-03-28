


using System.Net.Sockets;
using System.Runtime.CompilerServices;

public class Customer{

    private string _cname;

    private Address _address;


    public Customer(string _cname, Address address){

        _address = address;
        this._cname = _cname;
    }


    public bool IsUSCustomer(){

        return _address.IsUS();

    }

    public string GetShippingLabel(){

        return _address.DisplayAddress();

    }

    public string GetCustomerName(){
        return _cname;
    }

}