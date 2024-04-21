//Faça um programa que leia dois valores de cateto e calcule a hipotenusa

//Início
Console.WriteLine("--- Calculadora de Hipostenusa ---\n");

//Criação de Vairáveis
float cateto_1, cateto_2, hipotenusa;

//Entrada de dados e operações
Console.WriteLine("Digite um valor positivo para os seguintes catetos:");

do
{
    Console.Write("Cateto 1: ");
    cateto_1 = float.Parse(Console.ReadLine());

    if (cateto_1 < 0)
    {
        Console.WriteLine("\nValor inválido");
        Console.WriteLine("Digite novamente: ");
    }
} while (cateto_1 < 0);

Console.WriteLine("\n");
do
{
    Console.Write("Cateto 2: ");
    cateto_2 = float.Parse(Console.ReadLine());

    if (cateto_2 < 0)
    {
        Console.WriteLine("Valor inválido");
        Console.WriteLine("Digite novamente: ");
    }
} while (cateto_2 < 0);



//Final
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();