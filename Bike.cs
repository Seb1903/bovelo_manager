using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    public abstract class Bike
    {
        public int serial_number; 
        public List<Part>;  //create Part 
        public int price; 
    }
    public class Roadbike : Bike
    {

    }
    public class Explorer : Roadbike
    {

    }

    public class City : Roadbike
    {

    }

    public class Adventure : Bike
    {

    }
}

