// See https://aka.ms/new-console-template for more information

using Figuras.Entities;
using Figuras.Entities.Enums;
using System.Globalization;

List<Figura> figuras = new List<Figura>();

Console.Write("Entre o número de figuras: ");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Dados da figura # {i}: ");

    Console.Write("Retângulo ou círculo (r/c): ");
    char t = char.Parse(Console.ReadLine());
    Console.Write("Cor (Preto/Azul/Vermelho): ");
    Cor cor = Enum.Parse<Cor>(Console.ReadLine());

    if (t == 'r')
    {
        Console.Write("Altura: ");
        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Largura: ");
        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        figuras.Add(new Retangulo(altura, largura, cor));
    }
    else
    {
        Console.Write("Raio: ");
        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        figuras.Add(new Circulo(raio, cor));
    }
}

Console.WriteLine();
Console.WriteLine("ÁREA DAS FIGURAS: ");

foreach (Figura figura in figuras)
{
    Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
}

