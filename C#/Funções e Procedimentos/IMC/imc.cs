/*
Faça uma função em C# que recebe como
argumentos o peso e a altura de uma pessoa e
retorne o seu IMC (Índice de Massa Corporal),
que é calculado por IMC = peso / (altura ^ 2).
*/

class Program
{
    static void Main(string[] args)
    {
        double peso, altura;
        Console.WriteLine("Informe sua altura: ");
        altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe seu peso: ");
        peso = double.Parse(Console.ReadLine());

        Console.WriteLine($"O IMC corresponde a: {IMC(peso,altura)}");
    }
    static double IMC (double peso, double altura)
    {
        return(peso/(altura*altura));
    }
}