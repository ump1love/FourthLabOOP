class Ecosystem
{
    private List<LiveBeing> organisms;

    public Ecosystem()
    {
        organisms = new List<LiveBeing>();
    }

    public void AddOrganism(LiveBeing organism)
    {
        organisms.Add(organism);
    }

    public void SimulateInteractions()
    {
        foreach (var organism in organisms)
        {
            if (organism is IReproducible)
            {
                ((IReproducible)organism).Reproduce();
            }

            if (organism is IPredator)
            {
                var targets = organisms.FindAll(o => o != organism);
                if (targets.Count > 0)
                {
                    var target = targets[0];
                    ((IPredator)organism).Hunt(target);
                }
            }
        }
    }

    public void AgeOrganisms()
    {
        foreach (var organism in organisms)
        {
            organism.Age++;
        }
    }
}