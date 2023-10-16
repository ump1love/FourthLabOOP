public class TrafficSimulator
{
    public void SimulateTraffic(List<Vehicle> vehicles, Road road)
    {
        Console.WriteLine($"Simulating traffic on a road with {road.NumberOfLanes} lanes and traffic level {road.TrafficLevel}.");

        foreach (var vehicle in vehicles)
        {
            vehicle.Move();

            Random random = new Random();
            int activity = random.Next(1, 4);

            switch (activity)
            {
                case 1: vehicle.Stop(); break;
                case 2: vehicle.Turn(); break;
                default: break;
            }
        }
    }
}