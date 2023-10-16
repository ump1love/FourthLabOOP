class Plant : LiveBeing, IReproducible
{
    private string type;

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public Plant(string type, int energy, int age, int size) : base(energy, age, size)
    { Type = type; }

    public void Reproduce()
    {
        if (Age == 2 && Energy >= 25){ Console.WriteLine($"{Type} is reproducing."); }
    }
}