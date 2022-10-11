//3 Faça um algoritmo para calcular a área de um triângulo equilátero.


static void Main(string[] args)
{
    int x, y;
    Console.WriteLine("Digite o valor da base do triangulo: ");
    x = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o valor da altura: ");
    y = int.Parse(Console.ReadLine());

    Console.WriteLine("A area do triangulo eh: " + (x * y)/2);
}
