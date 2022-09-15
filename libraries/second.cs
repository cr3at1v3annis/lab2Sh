public abstract class Vehicle 
{
    private double x;
    private double y;
    private int cost;
    private int max_speed;
    private int year;
    public Vehicle(double _x, double _y, int _cost, int _speed, int _year)
    {
        x = _x;
        y = _y;
        cost = _cost;
        max_speed = _speed;
        year = _year;
    }
    public void PrintInfo() => Print();
    protected virtual void Print()
    {
        Console.WriteLine($"Coordinates are {x} and {y};");
        Console.WriteLine($"With speed {max_speed}, cost {cost}, year {year}");
    }
}

public class Plane: Vehicle
{
    private int height;
    private int capacity;
    public Plane(double _x, double _y, int _cost, int _speed, int _year, int _h, int _c): base(_x, _y, _cost, _speed, _year)
    {
        capacity = _c;
        height = _h;
    }
    public void PrintInfo() => Print();
    protected override void Print()
    {
        base.Print();
        Console.WriteLine($"This is plane with capacity {capacity} and height {height}");
    }
}
public class Ship: Vehicle
{
    private int capacity;
    private string port;
    public Ship(double _x, double _y, int _cost, int _speed, int _year, int _c, string _p):base(_x, _y, _cost, _speed, _year)
    {
        port = _p;
        capacity = _c;
    }
    public void PrintInfo() => Print();
    protected override void Print()
    {
        base.Print();
        Console.WriteLine($"This is ship with capacity {capacity} and port {port}");
    }
}
public class Car: Vehicle
{
    private int capacity;
    public Car(double _x, double _y, int _cost, int _speed, int _year, int _c):base(_x, _y, _cost, _speed, _year)
    {
        capacity = _c;
    }
    public void PrintInfo() => Print();
    protected override void Print()
    {
        base.Print();
        Console.WriteLine($"This is car with capacity {capacity}");
    }
}