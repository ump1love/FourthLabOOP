
class Server : Computer
{
    public Server(string osChoice, bool ifHomeNetwork, int serverRam, string serverCpu)
        : base(osChoice, ifHomeNetwork, new Power { RAM = serverRam, CPU = serverCpu }) { }

    public void SetServerSettings(int newRam, string newCpu)
    {
        base.UpdatePowerSettings(newRam, newCpu);
    }
}