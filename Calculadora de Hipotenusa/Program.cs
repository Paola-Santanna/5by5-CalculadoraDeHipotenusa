using static System.Math;

Console.WriteLine("--- Calculadora de Hipostenusa ---\n");

double cateto_1, cateto_2, hipotenusa_quadrado, hipotenusa;

//Entrada de dados e operações
Console.WriteLine("Digite um valor positivo, diferente de zero, para os seguintes catetos:");

do
{
    Console.Write("Cateto 1: ");
    cateto_1 = float.Parse(Console.ReadLine());

    if (cateto_1 < 0 || cateto_1 == 0)
    {
        Console.WriteLine("\nValor inválido");
        Console.WriteLine("Digite novamente: ");
    }
} while (cateto_1 < 0 || cateto_1 == 0);


do
{
    Console.Write("Cateto 2: ");
    cateto_2 = float.Parse(Console.ReadLine());

    if (cateto_2 < 0 || cateto_2 == 0)
    {
        Console.WriteLine("\nValor inválido");
        Console.WriteLine("Digite novamente: ");
    }
} while (cateto_2 < 0 || cateto_2 == 0);

hipotenusa_quadrado = (Pow(cateto_1, 2)) + (Pow(cateto_2, 2));
hipotenusa = Sqrt(hipotenusa_quadrado);

Console.WriteLine("\nResultado:");
Console.WriteLine($"{cateto_1}² + {cateto_2}² = {hipotenusa_quadrado}");
Console.WriteLine($"{Pow(cateto_1, 2)} + {Pow(cateto_2, 2)} = {hipotenusa_quadrado}");
Console.WriteLine($"Raiz da Hipotenusa = {hipotenusa}");
Console.WriteLine($"Hipotenusa = {Round(hipotenusa, 2)}");

//Final
Console.WriteLine("\nAperte ENTER para encerrar...");
Console.ReadKey();