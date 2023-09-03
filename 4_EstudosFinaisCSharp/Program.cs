using _4_EstudosFinaisCSharp;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace EstudosFinaisCSharp
{
    class EstudosFinaisCSharp
    {
        static void Main(string[] args)
        {
        //List<string> food = new List<string>();

        //food.Add("pizza");
        //food.Add("hamburger");
        //food.Add("hotdog");
        //food.Add("fries");

        ////food.Remove("fries");
        ////food.Insert(2, "sushi");
        ////Console.WriteLine(food.Count);
        ////Console.WriteLine(food.IndexOf("fries"));
        ////Console.WriteLine(food.LastIndexOf("fries"));
        ////Console.WriteLine(food.Contains("hotdog"));
        ////food.Sort();
        ////food.Reverse();
        ////food.Clear();
        ////String[] foods = food.ToArray();

        //foreach (var item in food)
        //{
        //    Console.WriteLine(item);
        //}

        //// ====================
        //List<Player> players = new List<Player>();

        //players.Add(new Player("Osvaldo"));
        //players.Add(new Player("Marcos"));
        //players.Add(new Player("Leticia"));

        //foreach (Player player in players) 
        //{
        //    Console.WriteLine(player);
        //}            


        //// ====================
        //// GET e SET esta sendo usado aqui.
        //Car car = new Car(400, "Porsche");

        //car.Speed = 1000000;

        //Console.WriteLine(car.Speed);
        //Console.WriteLine(car.Model);


        //// ====================
        //Console.WriteLine($"O nome do planeta é {Planets.Earth}");
        //Console.WriteLine($"O numeto do planeta é {(int)Planets.Earth}");
        //Console.WriteLine($"O tamanho do planeta é {(int)PlanetsSize.Earth}km");

        //int sum = (int)PlanetsSize.Earth + (int)PlanetsSize.Mars;

        //Console.WriteLine("A soma do tamanho da terra com o tamanho de marte é: " + sum);


        //// ====================
        //// Finalmente entendi oque é isso: <T>
        //// é generico, pode ser usado para qualquer tipo de variavel.
        //int[] numbers1 = { 1, 2, 3 };
        //double[] numbers2 = { 1.5, 2.5, 3.5 };
        //String[] numbers3 = {"1",  "2", "3" };

        //ShowElements(numbers1);
        //ShowElements(numbers2);
        //ShowElements(numbers3);


        //// ====================
        //Thread mainThread = Thread.CurrentThread;
        //mainThread.Name = "Main Thread";
        ////Console.WriteLine(mainThread.Name);

        //// Desta forma as funções são executadas ao mesmo tempo.
        //Thread thread1 = new Thread(() => CountDown("Thread #1"));
        //Thread thread2 = new Thread(CountUp);
        //thread1.Start();
        //thread2.Start();

        //// Já nesta forma é preciso que uma acabe para a outra começar.
        ////CountDown();
        ////CountUp();

        //Console.WriteLine(mainThread.Name + " esta completo!");

        // https://youtu.be/wxznTygnRfQ?si=A29nTTUqis29CiZp
        }

        public static void ShowElements<T>(T[] elements)
        {
            foreach (T element in elements)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
        }

        public static void CountDown(String name)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine(i + " " +name);
                Thread.Sleep(1000);
            }
            Console.WriteLine("ContDown acabou!");
        }

        public static void CountUp()
        {
            for(int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Console.WriteLine("ContUp acabou!");
        }

    }

    //enum Planets
    //{
    //    Mercury,
    //    Venus,
    //    Earth,
    //    Mars
    //}

    enum Planets{
        Mercury = 1,
        Venus = 2,
        Earth = 3,
        Mars = 4
    }

    enum PlanetsSize
    {
        Mercury = 13256,
        Venus = 211984,
        Earth = 34385,
        Mars = 4345243
    }

}