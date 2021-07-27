using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Heads
{
    class ConstructionWorkerHead : HeadBase
    {
        public bool HasMullet { get; set; }
        // public LegoColor Color { get; set; }
        public int NumberOfTeeth { get; set; }
        public bool WearingHardHat { get; set; }

        public bool ToggleWorking()
        {
            WearingHardHat = !WearingHardHat;
            Console.WriteLine($"The Construction Worker Head {(WearingHardHat ? "is" : "is not")} wearing its hard hat");
            return WearingHardHat;
        }

        public override void Spin()
        {
           if (NumberOfTeeth > 0)
            {
                NumberOfTeeth -= 1;
            }
            Console.WriteLine($"The {Color} Construction Worker Head spins after being hit by a girder");
        }

        //public void SayHi()
        //{
        //    Console.WriteLine("The Construction Worker Head says hello.");
        //}
    }
    // not a class
    //enum LegoColor
    //{
    //    Yellow,
    //    White,
    //    Brown,
    //    Gray,
    //    Purple,
    //    Red
    //}
}
