using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class NationsBuilder
{
    private List<Nation> nations;
    private BenderFactory benderFactory;
    private MonumentFactory monumentFactory;
    private Queue<String> warRecords;

    public NationsBuilder()
    {
        this.nations = new List<Nation>();
        this.benderFactory = new BenderFactory();
        this.monumentFactory = new MonumentFactory();
        this.warRecords = new Queue<string>();
    }

    public List<Nation> Nations
    {
        get { return this.nations; }
        set { this.nations = value; }
    }

    public void AssignBender(List<string> benderArgs)
    {
        string nationType = benderArgs[1];
        string name = benderArgs[2];
        int power = int.Parse(benderArgs[3]);
        double affinity = Double.Parse(benderArgs[4]);

        Nation currentNation = nations.FirstOrDefault(n => n.Type == nationType);

        if (currentNation == null)
        {
            currentNation = new Nation(nationType);
            nations.Add(currentNation);
        }

        Bender newBender = benderFactory.Create(nationType, name, power, affinity);

        currentNation.AssignBender(newBender);
    }

    public void AssignMonument(List<string> monumentArgs)
    {
        string nationType = monumentArgs[1];
        string name = monumentArgs[2];
        int affinity = int.Parse(monumentArgs[3]);

        Nation currentNation = Nations.FirstOrDefault(n => n.Type == nationType);

        if (currentNation == null)
        {
            currentNation = new Nation(nationType);
            nations.Add(currentNation);
        }

        Monument newMonument = monumentFactory.Create(nationType, name, affinity);

        currentNation.AssignMonument(newMonument);
    }

    public string GetStatus(string nationsType)
    {
        StringBuilder info = new StringBuilder();

        Nation nationToPrint = this.Nations.FirstOrDefault(n => n.Type == nationsType);
        info.AppendLine(nationToPrint.ToString());

        return info.ToString().Trim();
    }

    public void IssueWar(string nationsType)
    {
        Nation winningNation = GetWinningNation();

        foreach (var nation in this.Nations.Where(n => n.Type != winningNation.Type))
        {
            nation.Defeat();
        }

        AppendWarRecords(nationsType);
    }

    private Nation GetWinningNation()
    {
        Nation winningNation = this.Nations.FirstOrDefault();

        foreach (var nation in this.Nations)
        {
            if (nation.TotalPower > winningNation.TotalPower)
            {
                winningNation = nation;
            }
        }

        return winningNation;
    }

    private void AppendWarRecords(string nationsType)
    {
        this.warRecords.Enqueue($"War {this.warRecords.Count + 1} issued by {nationsType}");
    }

    public string GetWarsRecord()
    {
        return String.Join(Environment.NewLine, warRecords);
    }
}