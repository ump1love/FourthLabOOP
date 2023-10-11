class Router : Computer
{
    private int connected;
    public Router(string osChoice, bool ifHomeNetwork, int routerRam, string routerCpu)
        : base(osChoice, ifHomeNetwork, new Power { RAM = routerRam, CPU = routerCpu }){ connected = 0; }

    public void SetRouterSettings(int newRam, string newCpu)
    {
        base.UpdatePowerSettings(newRam, newCpu);
    }
}