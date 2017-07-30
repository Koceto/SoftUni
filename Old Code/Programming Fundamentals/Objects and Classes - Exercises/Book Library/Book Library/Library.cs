using System.Collections.Generic;
using System;

namespace Book_Library
{
    public class Library
    {

        public List<string> Title { get; set; }

        public List<string> Publisher { get; set; }

        public List<DateTime> ReleaseDate { get; set; }

        public List<int> ISBN { get; set; }

        public List<decimal> Price { get; set; }

    }
}

