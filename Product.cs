// this a template for creating an object. It is the blueprint for creating any product in our system.

// Now that we have defined this class is a type in our system, it is available for our use in the program, just like string, int, and boolx
public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool Sold { get; set; }
    public DateTime StockDate { get; set; }
    public int ManufactureYear { get; set; }
    public double Condition { get; set; }
}
