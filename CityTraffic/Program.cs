class Program
{
    static void Main()
    {
        Road road = new Road { Length = 10, Width = 2, NumberOfLanes = 2, TrafficLevel = 3 };
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Vehicle { Type = "Car", Speed = 60, Size = 2 },
            new Vehicle { Type = "Truck", Speed = 40, Size = 4 },
            new Vehicle { Type = "Bus", Speed = 50, Size = 3 }
        };

        TrafficSimulator trafficSimulator = new TrafficSimulator();

        trafficSimulator.SimulateTraffic(vehicles, road);

        Simulation simulation = new Simulation();
        simulation.OptimizeTraffic(road, vehicles);

    }
}