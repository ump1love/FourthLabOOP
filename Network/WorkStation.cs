
class WorkStation : Computer, IConnectable
{
    private string name;
    public WorkStation(string osChoice, bool ifHomeNetwork, int workStationRam, string workStationCpu, string name)
        : base(osChoice, ifHomeNetwork, new Power { RAM = workStationRam, CPU = workStationCpu }) { this.name = name; }

    public void SetWorkStationSettings(int newRam, string newCpu)
    {
        base.UpdatePowerSettings(newRam, newCpu);
    }

    public void Connect(string target)
    {
        Console.WriteLine($"{name} is connecting to {target}.");
    }
}