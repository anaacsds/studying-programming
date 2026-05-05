// Crie uma função que calcule recursivamente a potência 𝑥𝑦 , sendo 𝑥 e 𝑦 lidos pelo teclado.

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Digite um número para ser elevado: ");
        int x = int.Parse(Console.ReadLine());

        Console.WriteLine($"Digite a que número {x} será elevado: ");
        int y = int.Parse(Console.ReadLine());
        
        Console.WriteLine($"O resultado é: {potencia(x, y)}");
    }
    static int potencia (int x, int y)
    {
        if(y == 0)
        return 1;

        else
            return x * potencia(x, y - 1);

    }
}