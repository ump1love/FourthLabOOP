class Program
{
    public static void Main()
    {
        Router router = new Router("Linux", true, 4096, "Intel Core i5");
        Server server = new Server("Linux", true, 16384, "Intel Core i9");
        WorkStation laptop = new WorkStation(null, false, 8192, "Intel Core i7", "laptop");

        Network network = new Network();
        network.AddComputer(router);
        network.AddComputer(server);
        network.AddComputer(laptop);

        network.ConnectComputers(router, server);
        network.TransferData(laptop, server, "123");

    }
}