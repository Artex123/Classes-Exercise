using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public void FunRide()
        {
            Console.WriteLine($" The {Make} {Model} had a few bad years in its history.  The {Year} , however was an amazing year");
        }
    }
}

