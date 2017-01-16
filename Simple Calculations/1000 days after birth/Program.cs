using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_days_after_birth
{
    class Program
    {
        static void Main(string[] args)
        {   
            var birth = DateTime.ParseExact((Console.ReadLine()),"dd-MM-yyyy",null);
            Console.WriteLine("{0:dd-MM-yyyy}",birth.AddDays(999));
        }
    }
}