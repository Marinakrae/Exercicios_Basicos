//5 Escreva um algoritmo que leia a idade de uma pessoa, e então mostre na tela o ano em que ela nasceu.


static void Main(string[] args)
{
    int x, y;
    Console.WriteLine("Digite sua idade: ");
    x = int.Parse(Console.ReadLine());
    y = 2022 - x;
    Console.WriteLine("Voce nasceu em: " + y);
}
