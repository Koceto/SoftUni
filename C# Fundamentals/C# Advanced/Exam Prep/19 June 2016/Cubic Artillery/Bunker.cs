using System.Collections.Generic;

namespace Cubic_Artillery
{
    public class Bunker
    {
        public string Name { get; set; }

        public Queue<int> Weapons { get; set; }

        public int FilledCapacity { get; set; }
    }
}