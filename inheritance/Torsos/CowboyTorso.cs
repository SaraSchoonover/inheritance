using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inheritance.Torsos
{
    class CowboyTorso : TorsoBase
    {
        public bool HasPullString { get; set; }
        public bool HasHolster { get; set; }

        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("There's a snake in my boot!");
        }
        public override void Wiggle()
        {
            Console.WriteLine("Cowboy Friendly reaches for their holster and pulls out a banana.");
        }

        public void LassoDance()
        {
            Console.WriteLine("To move like a Cowboy, it's all in the wrist.");
        }
    }
}
