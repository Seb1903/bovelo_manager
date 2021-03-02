using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Bovelo
{
    /*
        Every single argument get requested in database and placed as a 
        parameter in the constructor.
    
        The part gets fours parameters
            > The name of the part
            > The color
            > The quantity
            > The characteristics : contains bike specific specifications
    */
    public class Part
    {
        public string name;
        public string color;
        public int quantity;
        public string characteristic;

        public Part(string DB_name, string DB_color, int DB_quantity, string DB_characterictic) {
            name = DB_name;
            color = DB_color;
            quantity = DB_quantity;
            characteristic = DB_characterictic;
        }
    }
}