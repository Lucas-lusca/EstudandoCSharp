using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_EstudosCSharoPOO
{
    abstract public class Vehicle
    {
        public int speed = 0;

        public virtual void Go()
        {
            Console.WriteLine("Este vehicle esta andando.");
        }
    }

    public class Bycycle : Vehicle 
    {
        public int wheels = 2;

        public override void Go()
        {
            Console.WriteLine("Este Bycycle esta andando.");
        }
    }

    public class Boat : Vehicle
    {
        public int sails = 1;

        public override void Go()
        {
            Console.WriteLine("Este Boat esta andando.");
        }
    }
}
