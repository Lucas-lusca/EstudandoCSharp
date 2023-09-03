using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_EstudosCSharoPOO
{
    public class Car
    {
        public String name;
        public String model;
        int year;
        String color;

        public static int cars;

        public Car(string name, string model = "NNN", int year = 2000, string color = "Branco")
        {
            this.name = name;
            this.model = model;
            this.year = year;
            this.color = color;

            cars++;
        }

        public override String ToString()
        {
            return "Este é o carro: " + name + ". Modelo: " + model;
        }

        public void Info()
        {
            Console.WriteLine("Nome: " + name + ". " + 
                              "De modelo: " + model + ". " + "Ano: " + year + ". " +
                              "Cor: " + color);
        }

        public void Drive()
        {
            Console.WriteLine("Você esta dirigindo o carro: " + name + ". " + "De cor: " + color);
        }

        public static void Change(Car car, String model)
        {
            car.model = model;
        }

        public static Car Copy(Car car)
        {
            return new Car(car.name, car.model);
        }
    }
}
