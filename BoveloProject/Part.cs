using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bovelo
{
    public class Part
    {
    }

    public class Tire : Part 
    {
        public int size;
        public string grooves; 
    }
     public class Frame : Part 
    {
        public string rigidity;
        public int size;
        public string color;   
    }
    public class Luggage_rack : Part 
    {

    }
    public class Lighting : Part
    {

    }
    public class Mudguard : Part 
    {
        public string type;
    }

    public class Seat : Part
    { 
    
    }
    
    public class Pedal : Part 
    { 
    } 
    public class Brakes : Part 
    { 
    } 
    public class Handbar : Part 
    {

    } 

    public class Basic_Kit : Part   //Might rather use a Composition relationship instead of aggregation 
    {
        public Seat seat;
        public Pedal pedal;
        public Brakes brakes;
        public Handbar handbar;
    }
}
