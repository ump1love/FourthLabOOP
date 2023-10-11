
using static LiveBeing;

class LiveBeing
{
    public enum Age
    {
        child,
        teen,
        adult,
        old,
    }
    public enum Size
    {
        micro,
        small,
        medium,
        large,
    }
    public enum Sex
    {
        male,
        female,
        unknown,
    }


    private Age age;
    
    private Size size;
    private Sex sex;
    private int energy;

    public Age GetAge(){ return age; }
    public void SetAge(Age value){ age = value; }
    public Size GetSize() { return size; }
    public void SetSize(Size value) { size = value; }
    public Sex GetSex() { return sex; }
    public void SetSex(Sex value) { sex = value; }
    public int GetEnergy() { return energy; }
    public void SetEnergy(int value) { energy = value; }

    public LiveBeing()
    {
        energy = 40;
    }

}