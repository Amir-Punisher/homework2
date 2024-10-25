using System;

class Car
{
    private string brand;
    private int speed;

    public Car(string brand, int speed)
    {
        this.brand = brand;
        Speed = speed;
    }

    public string Brand
    {
        get { return brand; }
    }

    public int Speed
    {
        get { return speed; }
        set
        {
            if (value >= 0 && value <= 240)
            {
                speed = value;
            }
            else
            {
                Console.WriteLine("speed error please enter a speed between 0 - 240");
            }
        }
    }


    public void PrintCarInfo()
    {
        Console.WriteLine($"car brand : {Brand}, car speed : {Speed} km/h");
    }
}

class Program
{
    static void Main(string[] args)
    {

        // example

        Car myCar = new Car("pride", 30);

        myCar.PrintCarInfo();

        Console.ReadKey();
    }
}
