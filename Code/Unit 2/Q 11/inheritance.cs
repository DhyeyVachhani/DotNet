using System;
class Car
{
    protected string name;
    protected int mfgYear;
    public Car()
    { }
}
class Maruti : Car
{
    public Maruti(string name, int mfgYear)
    {
        this.name = name;
        this.mfgYear = mfgYear;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
}
class Mahindra : Car
{
    public Mahindra(string name, int mfgYear)
    {
        this.name = name;
        this.mfgYear = mfgYear;
    }
    public int MfgYear
    {
        get { return mfgYear; }
    }
}
class MainClass
{
    public static void Main()
    {
        Maruti car1 = new Maruti("Swift", 2015);
        Mahindra car2 = new Mahindra("Swift", 2015);

        Console.WriteLine("Car1 Details:");
        Console.WriteLine("Name: {0} and Manufecturing Year: {1}",car1.Name,car1.MfgYear);
    }
}