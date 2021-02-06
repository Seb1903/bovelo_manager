using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bovelo
{
    public class Part
    {
    }

    public class Tire : Part 
    {
        int size;
        string grooves; 
    }
     public class Frame : Part 
    {
        string rigidity;
        int size;
        string color;    //maybe use ConsoleColor type ? 
    }
    public class Luggage_rack : Part 
    {

    }
    public class Lighting : Part
    {

    }
    public class Mudguard : Part 
    {
        string type;
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

    public class Basic_Kit : Part
    {
        public Seat seat;
        public Pedal pedal;
        public Brakes brakes;
        public Handbar handbar;
    }
}
