using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bovelo
{
    /*
        - Colors
            > Black
            > Dark blue
            > Light blue
        - Pas de prix des pièces
        - Couleurs pour
            > le garde-boue
            > le cadre
    */
    public class Bike
    {
        public int serial_number;
        public List<Part> PartList = new List<Part>();  //create Part 
        public int price;

        public Frame frame;
        public Tire tire;
        public Basic_Kit basic_Kit;
        public Luggage_rack luggage_rack;
        public Lighting lighting;
        public Mudguard mudguard;

        //public Dictionary<string,object> data

        private Bike()
        {
            frame = new Frame();
            tire = new Tire();
            basic_Kit = new Basic_Kit();
        }

        public static Bike RoadBike(int frameSize, string frameColor)
        {
            var b = new Bike();
            b.frame.color = frameColor;
            b.frame.size = frameSize;

            return b;
        }

        public static Bike Explorer(int tireSize, string frameColor, int frameSize)
        {
            var rb = RoadBike(frameSize, frameColor);
            rb.tire.size = tireSize;
            rb.tire.grooves = "very groovy";
            rb.mudguard.type = "adapted";

            return rb;
        }

        public static Bike City(int tireSize, string frameColor, int frameSize)
        {
            var cb = RoadBike(frameSize, frameColor);
            cb.tire.size = frameSize;

            return cb;
        }

        public static Bike Adventure(int tireSize, string frameColor, int frameSize)
        {
            var ab = RoadBike(frameSize, frameColor);
            ab.frame.color = frameColor;
            ab.frame.size = frameSize;
            ab.frame.rigidity = "reinforced";

            return ab;
        }
    }
}

