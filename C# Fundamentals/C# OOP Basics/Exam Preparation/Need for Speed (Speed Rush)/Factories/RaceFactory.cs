public class RaceFactory
{
    public Race Create(string type, int length, string route, int prizePool, int specialRaceModifier)
    {
        Race race = null;

        switch (type)
        {
            case "Casual":
                race = new CasualRace(length, route, prizePool);
                break;

            case "Drag":
                race = new DragRace(length, route, prizePool);
                break;

            case "Drift":
                race = new DriftRace(length, route, prizePool);
                break;

            case "TimeLimit":
                race = new TimeLimitRace(length, route, prizePool, specialRaceModifier);
                break;

            case "Circuit":
                race = new CircuitRace(length, route, prizePool, specialRaceModifier);
                break;
        }

        return race;
    }
}