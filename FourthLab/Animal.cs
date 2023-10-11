class Animal : LiveBeing
{
    private int reproductionLevel;    // Affects their reproduction level
    private int reproductionAmount;   // Affects the number of new animals
    private int speed;                // Affects success in herbivore catching

    public void SetReproductionLevel(int value) { reproductionLevel = value; }
    public int GetReproductionLevel() { return reproductionLevel; }
    public void SetReproductionAmount(int value) { reproductionAmount = value; }
    public int GetReproductionAmount() { return reproductionAmount; }
    public void SetSpeed(int value) { speed = value; }
    public int GetSpeed() { return speed; }

    public Animal(Sex sex)
    {
        reproductionLevel = 0;
        reproductionAmount = 0;
        speed = 0;
        SetSex(sex);
        SetSize(Size.small);
        SetAge(Age.child);
    }
}