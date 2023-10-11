class Computer
{
    public struct Power
    {
        public int RAM { get; set; }
        public string CPU { get; set; }
    }

    public string IP { get; private set; }

    private string os;
    private Power power;

    private Random random = new Random();

    public Computer(string osChoice, bool ifHomeNetwork, Power power)
    {
        if (osChoice == null)
        {
            int osRandom = random.Next(0, 2);
            os = (osRandom == 0) ? "Windows" : "Linux";
        }
        else
        {
            os = osChoice;
        }

        IP = (ifHomeNetwork) ? $"192.168.0.{random.Next(0, 24)}" : $"{random.Next(1, 256)}.{random.Next(1, 256)}.{random.Next(1, 256)}.{random.Next(1, 256)}";
        this.power = power;
    }
    public void UpdatePowerSettings(int newRam, string newCpu)
    {
        power.RAM = newRam;
        power.CPU = newCpu;
    }
}