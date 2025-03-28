


using System.Reflection.Metadata;

public class Order{


    List<Product> products = new List<Product>();

    private Customer _customer;



    public Order(Customer customer){

        this._customer = customer;

    }

    public void AddProduct(Product product){

        products.Add(product);

    }




    public void Display(){

        Console.WriteLine($"\n-----Order info is as follows----- ");
        Console.WriteLine($"\nShipping Label: {MakeShippingLabel()}");
        Console.WriteLine($"Total Cost: ${CalculateTotalCost()}");

        GetPackingLabel();
        
    }

    private int CalculateTotalCost(){

        int price = 0;

        foreach (Product product in products){

            int temp_price = product.CalculateCost();

            price = price + temp_price;
        };

        if (_customer.IsUSCustomer() == true){

            price = price + 5;
        }
        else{
            price = price + 35;
        }
        return price;
    }



    public string MakeShippingLabel(){

    return $"{_customer.GetCustomerName()}\n{_customer.GetShippingLabel()}";

    }

    private void GetPackingLabel(){

        Console.WriteLine("\n---Packing Label---");

        foreach (Product product in products){

            Console.WriteLine($"-{product.MakePackingLabel()}");
        }

    }
    
}

