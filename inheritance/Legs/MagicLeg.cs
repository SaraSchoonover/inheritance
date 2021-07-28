using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Legs
{
    class MagicLeg : LegBase
    {
        public bool HasInvisibleLegs { get; set; }
        public int Length { get; set; } // in inches
        
        public void MeasuringLegs(string size) // small, medium, large
        {
            if(size == "small")
            {
                Length = 4;
            } else if(size == "medium")
            {
                Length = 8;
            } else if(size == "large")
            {
                Length = 12;
            }
            else
            {

            }
        }
        public override void Walk()
        {
            Console.WriteLine("We all float on magic carpets down here.");
        }
    }
}
