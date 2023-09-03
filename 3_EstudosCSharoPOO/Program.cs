using System;

namespace _3_EstudosCSharoPOO
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //Messages.Hello();
            //Messages.Warning();
            //Messages.Bye();


            //// ======================
            //Human human1 = new Human();
            //Human human2 = new Human();

            //human1.name = "Rick";
            //human1.age = 65;

            //human2.name = "Morty";
            //human2.age = 16;

            //human1.Eat();
            //human1.Sleep();
            //human1.Infos();

            //human2.Eat();
            //human2.Sleep();
            //human2.Infos();


            //// ======================
            //Car car1 = new Car("Uno", "XV3", 2012, "Prata");
            //Car car2 = new Car("Gol", "KJC", 2015, "Branco");

            //car1.Info();
            //car1.Drive();

            //car2.Info();
            //car2.Drive();


            //// ======================
            //Car car1 = new Car("Uno", "XV3", 2012, "Prata");
            //Car car2 = new Car("Gol", "KJC", 2015, "Branco");
            //Car car3 = new Car("Uno", "XV3", 2012, "Prata");
            //Car car4 = new Car("Gol", "KJC", 2015, "Branco");

            //Console.WriteLine(Car.cars);


            //// ======================
            //// Cada uma desses objetos pizza esta usando um metodo diferente na classe pizza.
            //Pizza pizza1 = new Pizza("Crocante");
            //Pizza pizza2 = new Pizza("Crocante", "Molho de Tomate");
            //Pizza pizza3 = new Pizza("Crocante", "Molho de Tomate", "Parmezao");
            //Pizza pizza4 = new Pizza("Crocante", "Molho de Tomate", "Parmezao", "Calabresa");


            //// ======================
            //Bycycle bycycle = new Bycycle();
            //Boat boat = new Boat();

            //Console.WriteLine(bycycle.wheels);
            //Console.WriteLine(bycycle.speed);
            //bycycle.Go();

            //Console.WriteLine(boat.sails);
            //Console.WriteLine(boat.speed);
            //boat.Go();

            ////Vehicle vehicle = new Vehicle();


            //// ======================
            ////Car[] garage = new Car[3];

            ////garage[0] = new Car("Uno");
            ////garage[1] = new Car("Corvette");
            ////garage[2] = new Car("Lambo");

            //Car[] garage = { new Car("Uno"), new Car("Corvette"), new Car("Lambo")};

            //foreach (Car car in garage) 
            //{
            //    Console.WriteLine(car.name);
            //}


            //// ======================
            //Car car1 = new Car("Mustang", "GTX");

            //Car car2 = Car.Copy(car1);

            //Car.Change(car1, "GTR");

            //Console.WriteLine(car1.name + " " + car1.model);
            //Console.WriteLine(car2.name + " " + car2.model);


            //// ======================
            //// Aqui estamos usando metodos virtual e overriding para poder criar diferentes 
            //// heranças para cada objeto.
            //Dog dog = new Dog();
            //Cat car = new Cat();

            //dog.Sound();
            //car.Sound();


            //// ======================
            //Car car1 = new Car("Lambo", "TURB");

            //Console.WriteLine(car1.ToString());
            //Console.WriteLine(car1);


            //// ======================
            //// Exemplo de polymorphism.
            //// Precisamos usar virtual e override para usar polymorphism.
            //Bycycle bycycle = new Bycycle();
            //Boat boat = new Boat();

            //Vehicle[] vehicles = { bycycle, boat };

            //foreach (var vehicle in vehicles)
            //{
            //    vehicle.Go();
            //}


            //// ======================
            //// Aqui usamos Interfaces para declarar um contrato na classe dog e cat.
            //Dog dog = new Dog();
            //Cat cat = new Cat();

            //dog.Hunt();
            //cat.Flee();
            //cat.Hunt();
        }
    }
}