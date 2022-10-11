//4 Escreva um algoritmo para calcular a área de um círculo, com base em um raio digitado pelo usuário.

using System.Globalization;

static void Main(string[] args)
{
    double x;
    Console.WriteLine("Digite o valor do raio do circulo: ");
    x = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

    Console.WriteLine("A area do circulo eh: " + (long) Math.Pow((Math.PI*x),2));
}
