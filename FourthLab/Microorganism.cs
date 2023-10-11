class Microorganism : LiveBeing
{
    private int reproductiveRate;  // Affects their reproduction level
    private int infectivity;       // Affects their defense

    public void SetReproductiveRate(int value) { reproductiveRate = value; }
    public int GetReproductiveRate() { return reproductiveRate; }
    public void SetInfectivity(int value) { infectivity = value; }
    public int GetInfectivity() { return infectivity; }

    public Microorganism()
    {
        reproductiveRate = 0;
        infectivity = 0;
        SetEnergy(40);
        SetSex(Sex.unknown);
        SetSize(Size.micro);
        SetAge(Age.adult);
    }
}