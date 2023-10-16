class Animal : LiveBeing, IReproducible, IPredator
{
    private string species;
    private string sex;

    public string Species
    {
        get { return species; }
        set { species = value; }
    }
    public string Sex
    {
        get { return sex; }
        set { sex = value; }
    }

    public Animal(string species, int energy, int age, int size, string sex) : base(energy, age, size)
    {
        Species = species;
        Sex = sex;
    }

    public void Reproduce()
    {
        if (Age == 3 && Energy >= 40 && (Sex == "male" || Sex == "female")){ Console.WriteLine($"{Species} is reproducing."); }
    }

    public void Hunt(LiveBeing target)
    { Console.WriteLine($"{Species} is hunting."); }
}