class Plant : LiveBeing
{
    private int photosynthesisLevel;  // Affects size change
    private int fertility;            // Affects reproduction level
    private int toxicity;             // Affects their defense

    public void SetPhotosynthesisLevel(int value) { photosynthesisLevel = value; }
    public int GetPhotosynthesisLevel() { return photosynthesisLevel; }
    public void SetFertility(int value) { fertility = value; }
    public int GetFertility() { return fertility; }
    public void SetToxicity(int value) { toxicity = value; }
    public int GetToxicity() { return toxicity; }

    public Plant()
    {
        photosynthesisLevel = 0;
        fertility = 0;
        toxicity = 0;
        SetSex(Sex.unknown);
        SetSize(Size.small);
        SetAge(Age.child);
    }
}