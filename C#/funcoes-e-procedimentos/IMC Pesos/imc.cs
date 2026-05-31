/*
Faça um procedimento em C# que receba
como argumentos o IMC de uma pessoa e
determine sua situação, conforme abaixo:
a) abaixo de 20: abaixo do peso
b) de 20 a 25: peso normal
c) de 25 a 30: sobrepeso
d) de 30 a 40: obesidade
e) acima de 40: obesidade mórbida
*/

using System.Reflection.PortableExecutable;

class Program
{
        static void Main(string[] args)
    {
        double peso, altura;
        Console.WriteLine("Informe sua altura: ");
        altura = double.Parse(Console.ReadLine());
        Console.WriteLine("Informe seu peso: ");
        peso = double.Parse(Console.ReadLine());

        double valorIMC = IMC(peso, altura);
        
        Console.WriteLine($"O IMC corresponde a: {valorIMC}"); //esta errado!!!!!!!
        Console.Write("E a situação é: ");
        situacaoIMC(valorIMC);
    }
    static double IMC (double peso, double altura)
    {
        return(peso/(altura*altura));
    }

    static void situacaoIMC (double IMC)
    {
        if(IMC < 20) 
        Console.WriteLine("Abaixo do peso");
        else if(IMC >= 20 && < 25) 
        Console.WriteLine("Peso normal");
        else if(IMC >= 25 && < 30) 
        Console.WriteLine("Sobrepeso"); 
        else if(IMC >= 30 && < 40) 
        Console.WriteLine("Obesidade"); 
        else 
        Console.WriteLine("Obesidade mórbida");
    }
}