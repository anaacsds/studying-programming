/* Faça um programa que contenha uma função capaz de inverter uma string fornecida por um usuário.*/

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine($"Digite uma palavra que queira inverter: ");
        string a = Console.ReadLine();

        int i = a.Length - 1;

        Console.WriteLine($"Palavra invertida: {invert(a, i)}");
    }
    static string invert(string a, int i)
    {
        if(i < 0)
        return "";

        else
        {
            return a[i] + invert(a, i - 1 );
        }
    }
}