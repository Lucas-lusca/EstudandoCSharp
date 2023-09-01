using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_EstudosCSharoPOO
{
    public class Human
    {
        public String name = "";
        public int age;

        public void Sleep()
        {
            Console.WriteLine("Humano: " + name + ", esta dormindo.");
        }

        public void Eat()
        {
            Console.WriteLine("O humano: " + name + ", esta comendo.");
        }

        public void Infos()
        {
            Console.WriteLine("Nome: " + name);
            Console.WriteLine("Idade: " + age);
        }
    }
}
