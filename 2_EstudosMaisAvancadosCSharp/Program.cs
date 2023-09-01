// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//// ========================
//// Esta maneira é mais complicada
//// Nessa você primeiro declara o tamanho do array pra depois adicionar 
//// coisas de acordo com esse tamanho.
////string[] carss = new string[3];

////carss[0] = "Porche";
////carss[1] = "BMW";
////carss[2] = "Gol";

//// Bem melhor essa!
//string[] cars = { "Porche", "BMW", "Gol" };

//Console.WriteLine(cars);

//for (int i = 0;  i < cars.Length; i++)
//{
//    Console.WriteLine(cars[i]);
//}


//// ========================
//string[] cars = { "Porche", "BMW", "Gol" };

//foreach (string car in cars)
//{
//    Console.WriteLine(car);
//}


//// ========================
//string name = "Lucas";
//int idade = 18;

//Cantar(name, idade);
//Cantar(name, idade);
//Cantar(name, idade);

//static void Cantar(string aniversariante, int idade)
//{
//    Console.WriteLine("Para bens pra você!");
//    Console.WriteLine("Para bens pra você!");
//    Console.WriteLine("Para bens para o " + aniversariante);
//    Console.WriteLine("Para bens pra você!");
//    Console.WriteLine(aniversariante + " esta completando " + idade);
//}


//// ========================
//Console.Write("Digite o primeiro numero para a multiplicação: ");
//double numero1 = Convert.ToDouble(Console.ReadLine());

//Console.Write("Digite o segundo numero para a multiplicação: ");
//double numero2 = Convert.ToDouble(Console.ReadLine());

//double resultado = Multiply(numero1, numero2);

//Console.WriteLine(resultado);

//static double Multiply(double numero1, double numero2)
//{
//    return numero1 * numero2;
//}


//// ========================
//// A ideia aqui é demonstrar metodos overloading (sobrecarga), onde é possivel criar
//// metodos com o mesmo nome mas com parametros diferentes.
//using System;

//namespace EstudandoMaisAvancadoCShap
//{
//    class EstudandoMaisAvancado 
//    { 
//        static void Main(String[] args)
//        {
//            Console.Write("Escreva o primeiro numero para a multiplicação: ");
//            double numero1 = Convert.ToDouble(Console.ReadLine());

//            Console.Write("Escreva o segundo numero para a multiplicação: ");
//            double numero2 = Convert.ToDouble(Console.ReadLine());


//            double result1 = Multiply(numero1, numero2);

//            double result2 = Multiply(numero1, numero2, 10);

//            Console.WriteLine(result1);
//            Console.WriteLine(result2);
//        }

//        static double Multiply(double numero1, double numero2)
//        {
//            return numero1 * numero2;
//        }

//        static double Multiply(double numero1, double numero2, double numero3)
//        {
//            return numero1 * numero2 * numero3;
//        }
//    }
//}


//// ========================
//using System;

//namespace EstudosMaisAvancadosCSharp
//{
//    class EstudosMaisAvancados
//    {
//        static void Main(string[] args)
//        {
//            double total = Total(10.5, 15, 5.2);
//            Console.WriteLine(total);
//        }

//        static double Total(params double[] prices)
//        {
//            double total = 0;

//            foreach (double price in prices) 
//            {
//                total += price;
//            }

//            return total;
//        }
//    }
//}


//// ========================
//using System;

//namespace EstudosMaisAvancadosCSharp
//{
//    class EstudosMaisAvancados
//    {
//        static void Main(string[] args)
//        {
//            double numero1;
//            double numero2;

//            int resultado;

//            try
//            {
//                Console.Write("Escreva o primeiro numero para a divisão: ");
//                numero1 = Convert.ToInt32(Console.ReadLine());

//                Console.Write("Escreva o segundo numero para a divisão: ");
//                numero2 = Convert.ToInt32(Console.ReadLine());

//                resultado = ((int)numero1 / (int)numero2);

//                Console.WriteLine(resultado);
//            }
//            catch (FormatException ex) 
//            {
//                Console.WriteLine ("Escreva apenas numero Inteiros!");
//            }
//            catch (DivideByZeroException ex)
//            {
//                Console.WriteLine("Não é possivel dividir por 0!");
//            }
//            //catch (Exception ex) // Captura qualquer exception no codigo.
//            //{
//            //  Console.WriteLine("Algo deu errado!");
//            //}
//            finally 
//            { 
//                Console.WriteLine("Obrigado por usar a calculadora!");
//            }
//        }
//    }
//}


//// ========================
//using System;

//namespace EstudosMaisAvancadosCSharp
//{
//    class EstudosMaisAvancados
//    {
//        static void Main(string[] args)
//        {
//            double temperatura = 25;

//            //string mensagem = (temperatura < 20) ? "Esta frio!" : "Esta quente!";

//            Console.WriteLine((temperatura < 20) ? "Esta frio!" : "Esta quente!");
//        }
//    }
//}


//// ========================
//using System;

//namespace EstudosMaisAvancadosCSharp
//{
//    class EstudosMaisAvancados
//    {
//        static void Main(string[] args)
//        {
//            string primeiroNome = "Lucas";
//            string sobreNome = "Justi";

//            double idade = 18;

//            Console.WriteLine($"Olá {primeiroNome} {sobreNome, -10}, você tem {idade, 5} de idade!");
//        }
//    }
//}


//// ========================
//using System;

//namespace EstudosMaisAvancadosCSharp
//{
//    class EstudosMaisAvancados
//    {
//        static void Main(string[] args)
//        {
//            int[,] numeros = { { 0, 0 }, 
//                               { 1, 1 }, 
//                               { 2, 2 }, 
//                               { 3, 3 }, 
//                               { 4, 4 }, 
//                               { 5, 5 }
//                             };

//            numeros[3, 1] = 0;

//            for (int i = 0; i < numeros.GetLength(0); i++)
//            {
//                for (int j = 0; j < numeros.GetLength(1); j++)
//                {
//                    Console.Write(numeros[i, j]);
//                }
//                Console.WriteLine();
//            }
//        }
//    }
//}