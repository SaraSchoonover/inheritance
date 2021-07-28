using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using inheritance.Heads;

namespace inheritance.Torsos
{
    class SumoTorso : TorsoBase
    {
        public bool AreTheyThicc { get; set; }
        public LegoColor Fundoshi { get; set; }
        

        public override void Wiggle()
        {
            Console.WriteLine("Sumo does their Shiko before the fight.");
        }

        public void FightPrep()
        {
            Console.WriteLine("Before the fight, arrange the salt.");
        }
    }
}
