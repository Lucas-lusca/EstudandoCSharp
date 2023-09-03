using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_EstudosCSharoPOO
{
    public class Animal
    {
        public virtual void Sound()
        {
            Console.WriteLine("The animal does 'AAAA' ");
        }
    }

    interface IFlee 
    {
        void Flee();
    }

    interface IHunt
    {
        void Hunt();
    }

    class Dog : Animal, IHunt
    {
        public override void Sound()
        {
            Console.WriteLine("The dog does 'WOOF'");
        }

        public void Hunt()
        {
            Console.WriteLine("O cachorro esta buscando por comida!");
        }
    }

    class Cat : Animal, IFlee, IHunt 
    {
        public override void Sound()
        {
            Console.WriteLine("The cat does 'MEOW'");
        }

        public void Flee()
        {
            Console.WriteLine("O gato esta correndo por ai");
        }

        public void Hunt()
        {
            Console.WriteLine("O gato esta procurando por comida!");
        }
    }
}
