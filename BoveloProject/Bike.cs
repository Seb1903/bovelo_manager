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
        public List<Part> PartList = new List<Part>();  //create Part 
        public int price;

        public Frame frame;
        public Tire tire;
        public Basic_Kit Basic_Kit;
        
        public Bike(Frame frame, Tire tire, Basic_Kit basic_Kit)
        {
            this.frame = frame;
            this.tire = tire;
            this.Basic_Kit = basic_Kit; 
        }
    }
    public class Roadbike : Bike
    {
        public Luggage_rack luggage_rack ;
        public Lighting lighting ;
        public Mudguard mudguard ;
        public Roadbike(int size, Color color, Frame frame, Tire tire, Basic_Kit basic_Kit, Luggage_rack luggage_Rack, Lighting lighting, Mudguard mudguard) : base(frame,tire,basic_Kit)
        {
            this.frame.color = color;
            this.frame.size = size;
        }
    }
    public class Explorer : Roadbike
    {
        public Explorer(int size, Color color, Frame frame, Tire tire, Basic_Kit basic_Kit, Luggage_rack luggage_Rack, Lighting lighting, Mudguard mudguard) : base(size, color, frame, tire, basic_Kit,luggage_Rack,lighting,mudguard)
        {
            this.tire.size = 2;     // 1 = normal and 2 = large 
            this.tire.grooves = "very groovy"; // to be changed 
            this.mudguard.type = "Adapted";
        }
    }

    public class City : Roadbike
    {
        public City(int size, Color color, Frame frame, Tire tire, Basic_Kit basic_Kit, Luggage_rack luggage_Rack, Lighting lighting, Mudguard mudguard) : base(size, color, frame, tire, basic_Kit, luggage_Rack, lighting, mudguard)
        {
            this.tire.size = 1; 
            //necessary to define specific values for mudguard type and tire grooves ?
        }

    }

    public class Adventure : Bike
    {
        public Adventure(int size, Color color,Frame frame, Tire tire, Basic_Kit basic_Kit) : base(frame, tire, basic_Kit)
        {
            this.frame.color = color;
            this.frame.size = size;
            this.frame.rigidity = "Reinforced";
        }
    }
}

