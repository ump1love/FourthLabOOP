using System;
using System.Collections.Generic;


class Network
{
    private List<Computer> computers;

    public Network()
    {
        computers = new List<Computer>();
    }

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public void ConnectComputers(Computer computer1, Computer computer2)
    {
        Console.WriteLine($"Connecting {computer1.IP} to {computer2.IP}");
    }

    public void DisconnectComputers(Computer computer1, Computer computer2)
    {
        Console.WriteLine($"Disconnecting {computer1.IP} from {computer2.IP}");
    }

    public void TransferData(Computer source, Computer destination, string data)
    {
        Console.WriteLine($"Transferring data from {source.IP} to {destination.IP}: {data}");
    }
}





