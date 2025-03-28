

public class Product{

    private string _name;

    private int _product_id;

    private int _costPerUnit;

    private int _quantity;

    


    public Product(string _name, int _product_id, int _costPerUnit, int _quantity){

        this._costPerUnit = _costPerUnit;
        this._name = _name;
        this._product_id = _product_id;
        this._quantity = _quantity;

    }

    public string MakePackingLabel(){

        return $"Name: {_name}\nProduct ID: {_product_id}\n";

    }

    public int CalculateCost(){

        int cost = _costPerUnit * _quantity;

        return cost;

    }

}