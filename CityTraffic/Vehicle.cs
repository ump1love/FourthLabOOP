public class Vehicle : IDriveable
{
    private string type;
    private double speed;
    private double size;

    public string Type
    {
        get { return type;}
        set { type = value; }
    }
    public double Speed
    {
        get { return speed;}
        set { speed = value; }
    }
    public double Size
    {
        get { return size;}
        set { size = value; }
    }

    public void Move()
    { Console.WriteLine($"{Type} is moving at a speed of {Speed} km/h."); }
    public void Stop()
    { Console.WriteLine($"{Type} has stopped."); }
    public void Turn()
    { Console.WriteLine($"{Type} is turning."); }
}