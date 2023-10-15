class Program
{
    static void Main()
    {
        Ecosystem ecosystem = new Ecosystem();

        Animal bunny = new Animal("Bunny", 40, 1, 10, "male");
        Animal sheep = new Animal("Sheep", 40, 1, 15, "female");
        Plant grass = new Plant("Grass", 40, 0, 5);
        Microorganism microorganism = new Microorganism("Microorganism", 40, 0, 2);

        ecosystem.AddOrganism(bunny);
        ecosystem.AddOrganism(sheep);
        ecosystem.AddOrganism(grass);
        ecosystem.AddOrganism(microorganism);

        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine($"Iteration {i + 1}");
            ecosystem.SimulateInteractions();
            ecosystem.AgeOrganisms();
        }
    }
}