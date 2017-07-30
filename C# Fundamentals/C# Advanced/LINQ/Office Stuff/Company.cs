using System.Collections.Generic;

namespace Office_Stuff
{
    public class Company
    {
        public string Name { get; set; }

        public List<Order> Orders { get; set; }
    }
}