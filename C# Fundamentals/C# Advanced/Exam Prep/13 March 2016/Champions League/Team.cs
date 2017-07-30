using System.Collections.Generic;

namespace Champions_League
{
    public class Team
    {
        public string Name { get; set; }

        public int Wins { get; set; }

        public SortedSet<string> Opponents { get; set; }
    }
}