//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//Console.SetWindowSize(100, 30);
//int mouseX = Console.GetCursorPosition().Left;
//int mouseY = Console.GetCursorPosition().Top;

//Console.WriteLine(mouseX + " " + mouseY);
//Console.Beep();


//// ================================
//int x;
//int y = 50;

//double d = 1.5;

//char c = 'a';

//string s = "true";

//bool b = false;

//x = 100;

//b = Convert.ToBoolean(s); 

//Console.WriteLine(x + y);
//Console.WriteLine(b);
//Console.WriteLine(b.GetType);


//// ================================
//Console.WriteLine("Qual seu nome?");
//string nome = Console.ReadLine();

//Console.WriteLine("Qual sua idade?");
//int idade = Convert.ToInt32(Console.ReadLine());

//Console.WriteLine("Olá " + nome);
//Console.WriteLine("Sua idade é " + idade + " anos");


//// ================================
//int numero = 3;

//double elevado = Math.Pow(numero, 2); // Math possui diversas equações matematicas já prontas!
//double aoQuadrado = Math.Sqrt(81);

//Console.WriteLine(elevado);
//Console.WriteLine(aoQuadrado);


//// ================================
//Random random = new Random();

//double numero = random.Next();
//double numero2 = random.Next(1, 10);


//Console.WriteLine(numero);
//Console.WriteLine(numero2);


//// ================================
//Console.WriteLine("CALCULANDO A HIPOTENUSA");
//Console.WriteLine("Escreva o primeiro numero: ");
//double numero1 = Convert.ToDouble(Console.ReadLine());

//Console.WriteLine("Escreva o Segundo numero: ");
//double numero2 = Convert.ToDouble(Console.ReadLine());

//double hipotenusa = Math.Sqrt((numero1 * numero1) + (numero2 * numero2));
//Console.WriteLine("A hipotenusa é: " + hipotenusa);


//// ================================
//string nome = "Lucas Justi";

//Console.WriteLine(nome.ToUpper());
//Console.WriteLine(nome.ToLower());

//string substitua = nome.Replace(" ", "/");

//Console.WriteLine(substitua);

//string insira = nome.Insert(0, "Sr.");
//Console.WriteLine(insira);

//Console.WriteLine(nome.Length);

//string primeiroNome = nome.Substring(0, 5);

//Console.WriteLine(primeiroNome);


//// ================================
//Console.WriteLine("Escreva sua idade: ");
//int idade = Convert.ToInt32(Console.ReadLine());

//if(idade >= 18)
//{
//    Console.WriteLine("Você pode continuar o processo!");
//} else if(idade <= 0)
//{
//    Console.WriteLine("Você tem que ter nascido!");
//} else
//{
//    Console.WriteLine("Você NÃO pode continuar o processo!");
//}


//// ================================
/*
Console.WriteLine("Insira o numero do mês: ");
int mes = Convert.ToInt32(Console.ReadLine());

switch (mes)
{
    case 1:
        Console.WriteLine("janeiro");
        break;

    case 2:
        Console.WriteLine("fevereiro");
        break;

    case 3:
        Console.WriteLine("março");
        break;

    case 4:
        Console.WriteLine("abril");
        break;

    case 5:
        Console.WriteLine("maio");
        break;

    case 6:
        Console.WriteLine("junho");
        break;

    case 7:
        Console.WriteLine("julho");
        break;

    case 8:
        Console.WriteLine("agosto");
        break;

    case 9:
        Console.WriteLine("setembro");
        break;

    case 10:
        Console.WriteLine("outubro");
        break;

    case 11:
        Console.WriteLine("novembro");
        break;

    case 12:
        Console.WriteLine("dezembro");
        break;

    default:
        Console.WriteLine("Esse mês não existe!");
        break;
}
*/


//// ================================
//Console.WriteLine("Qual a temperatura esta agora? (C)");
//double temperatura = Convert.ToDouble(Console.ReadLine());

//if(temperatura > 10 &&  temperatura < 20)
//{
//    Console.WriteLine("Esta morno!");
//} else if(temperatura > 20 && temperatura < 30)
//{
//    Console.WriteLine("Esta quente!");
//} else if(temperatura < 10 && temperatura > 0)
//{
//    Console.WriteLine("Esta frio!");
//} else if(temperatura < 0 || temperatura > 30)
//{
//    Console.WriteLine("Tenha cuidado ao sair de casa!");
//}


//// ================================
//string nome = "";

//while (nome == "")
//{
//    Console.Write("Insira seu nome: ");
//    nome = Console.ReadLine();
//}

//while (true)
//{
//    Console.WriteLine("Olá " + nome);
//}


//// ================================
//for (int i = 0; i <= 10; i++)
//{
//    Console.WriteLine(i);
//}

//for (int i = 10; i >= 0; i--)
//{
//    Console.WriteLine(i);
//}


//// ================================
//Console.WriteLine("VAMOS DESENHAR UM RETANGULO");

//Console.Write("Quantas linhas?");
//int rows = Convert.ToInt32(Console.ReadLine());

//Console.Write("Quantas colunas?");
//int columns = Convert.ToInt32(Console.ReadLine());

//Console.Write("Qual simbolo?");
//char symbol = Convert.ToChar(Console.ReadLine());

//for (int i = 0; i < rows; i++)
//{
//    for (int j = 0; j < columns; j++)
//    {
//        Console.Write(symbol);
//    }
//    Console.WriteLine();
//}
////  Basicamente para o primeiro for continuar é preciso que o segundo acabe.