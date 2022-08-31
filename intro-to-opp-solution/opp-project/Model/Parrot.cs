using System;

namespace opp_project.Model
{
    public class Parrot : Bird
    {
        public Parrot(string name, string color) : base (name, color)
        {
        }

        public override void Speak()
        {
            Console.WriteLine($"Hi! I'm {Name} and I only say Paz the Parrot");
        }
    }
}

