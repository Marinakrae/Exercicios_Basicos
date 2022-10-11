//1 Faça a leitura de dois números e apresenta a soma, subtração,multiplicação e divisão

static void Main(string[] args)
{
    int x, y;
    Console.WriteLine("Digite o primeiro numero: ");
    x = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o segundo numero: ");
    y = int.Parse(Console.ReadLine());

    Console.WriteLine("Soma: " + (x + y));
    Console.WriteLine("Subtração: " + (x - y));
    Console.WriteLine("Multiplicação: " + (x * y));
    Console.WriteLine("Devisão: " + (x / y));
}
