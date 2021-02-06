using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bovelo
{
    public abstract class Bike    
    {
        public int serial_number; 
        public List<Part> PartList = new List<Part>() ;  //create Part 
        public int price;

        public Frame frame = new Frame();    //Rather use aggregation insteat of composittion 
        public Tire tire = new Tire();
        public Basic_Kit Basic_Kit = new Basic_Kit();
    }
    public class Roadbike : Bike
    {
        public Luggage_rack luggage_rack = new Luggage_rack();
        public Lighting lighting = new Lighting();
        public Mudguard mudguard = new Mudguard();
        public Roadbike(int size, Color color) 
        {
            this.frame.color = color;
            this.frame.size = size;
        }
    }
    public class Explorer : Roadbike
    {
        public Explorer(int size, Color color) : base(size,color)
        {
            this.tire.size = 2;     // 1 = normal and 2 = large 
            this.tire.grooves = "very groovy"; // to be changed 
            this.mudguard.type = "Adapted";
        }
    }

    public class City : Roadbike
    {
        public City(int size, Color color) : base(size, color)
        {
            this.tire.size = 1; 
            //necessary to define specific values for mudguard type and tire grooves ?
        }

    }

    public class Adventure : Bike
    {
        public Adventure(int size, Color color)
        {
            this.frame.color = color;
            this.frame.size = size;
            this.frame.rigidity = "Reinforced";
        }
    }
}

