using System;
using inheritance.Heads;
using System.Collections.Generic;

// TYPES OF PROGRAMMING:
// -Imperative: Cobol, Punch
// -Functional: Haskell, Lisp, f#, Erlang, Elixir
// -OOP: Object Oriented Programming
    // -objects are a toe level concept 
    // -shared state should not be mutable.
    // -inheritance/subclassing
    // -polymorphism -
// -Fake Advantages
    // -model after the real world
    // -reusable code
// -INHERITANCE:
    // -"is a"
    // -"A duck is a bird." ducks are bird and have certain behaviors for being birds.
    // -Get traits/behaiviors for 'free'.
    // - can only inherit from one thing.
// -COMPOSITION:
    // -taking small things and putting them together to perform a big job.
    // -what makes up a thing
    // -"has a"
    // -"A duck has a bill." -is made up of x,y,z.
    // -combining a bunch of parts to make one whole thing/to do one big job.
    // - no limit on how many things can be composed of.

// hit the CONTROL key and click and it will take you
// to go back hit CONTROL key and minus key
// CONTROL SHIFT minus moves forward

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new ConstructionWorkerHead();

            head.Color = LegoColor.Yellow;
            head.SayHi();

            var batmanHead = new BatmanHead();
            batmanHead.SayHi();

            var astronautHead = new AstronautHead();
            astronautHead.SayHi();

            // var weirdHead = new HeadBase();

            var heads = List<AstronautHead>() { astronautHead, batmanHead }; 

        }

        
    }
}
