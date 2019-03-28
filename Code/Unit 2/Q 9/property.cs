using System;

class Bike
{
    private double price;
    private string fuel;
    private int key;
    public Bike(string fuel)
    {
        this.fuel = fuel;
    }
    public Bike() { }
    public double Price
    {
        get {return price;}
        set {price = value;}
    }
    public string Fuel
    {
        get {return fuel;}
    }
    public int Key
    {
        set {key = value;}
    }
}
class MainClass
{
    public static void Main()
    {
        Bike b1 = new Bike("Petrol");
        b1.Price = 50000;
        b1.Key = 12;
        Console.WriteLine("Bike Details: Fuel: {0} Price: {1}", b1.Fuel, b1.Price);
    }
}