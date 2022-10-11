//2 Faça um algoritmo para o calculo da área de um retângulo

static void Main(string[] args)
{
    int x, y;
    Console.WriteLine("Digite o valor de um dos lados do retangulo: ");
    x = int.Parse(Console.ReadLine());

    Console.WriteLine("Agora digite o valor do outro: ");
    y = int.Parse(Console.ReadLine());

    Console.WriteLine("A area do retangulo eh: " + (x * y));
}
