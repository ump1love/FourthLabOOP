class Microorganism : LiveBeing, IReproducible
{
    private string strain;

    public string Strain
    {
        get { return strain; }
        set { strain = value; }
    }

    public Microorganism(string strain, int energy, int age, int size) : base(energy, age, size)
    {
        Strain = strain;
    }

    public void Reproduce()
    {
        if (Age == 1 && Energy >= 10)
        {
            Console.WriteLine($"{Strain} is reproducing.");
        }
    }
}