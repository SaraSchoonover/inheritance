using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance.Heads;
using inheritance.Legs;
using inheritance.Torsos;

namespace inheritance.MiniFigures
{
    class MiniFigure
    {
        public HeadBase Head { get; }
        public TorsoBase Torso { get; }
        public LegBase Leg { get; }

        public MiniFigure(HeadBase head, TorsoBase torso, LegBase leg)
        {
            Head = head;
            Torso = torso;
            Leg = leg;
        }

        public void BuildIt()
        {
            Console.WriteLine("I love to build things with my bare hands.");
            Head.SayHi();
            Head.Spin();
        }
        

    }
}
