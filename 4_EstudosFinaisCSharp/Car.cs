using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_EstudosFinaisCSharp
{
    public class Car
    {
        double speed;

        public String Model { get; set; }

        public Car(double speed, String model) 
        {
            this.Speed = speed;
            this.Model = model;
        }

        public double Speed
        {
            get { return speed; }
            set
            {
                if(value >= 500)
                {
                    speed = 500;
                }
                else
                {
                    this.speed = value;
                }
            }
        }
    }
}
