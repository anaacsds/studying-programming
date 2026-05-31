/*
O codigo do programa abaixo ser ́a utilizado nas Quest ̃oes 4 a 6. O programa lˆe as cinco notas de
um aluno e determina suas estat ́ısticas. Fa ̧ca o c ́odigo que falta, conforme o que cada quest ̃ao
solicita. A estrutura geral do programa deve ser respeitada e n ̃ao pode ser alterada.
*/

class Program{
    static void Main(string[] args)
{
    double nota1, nota2, nota3, nota4, nota5;

    Console.Write("Informe a primeira nota: ");
    nota1 = double.Parse(Console.ReadLine());
    Console.Write("Informe a segunda nota: ");
    nota2 = double.Parse(Console.ReadLine());
    Console.Write("Informe a terceira nota: ");
    nota3 = double.Parse(Console.ReadLine());
    Console.Write("Informe a quarta nota: ");
    nota4 = double.Parse(Console.ReadLine());
    Console.Write("Informe a quinta nota: ");
    nota5 = double.Parse(Console.ReadLine());

    DeterminarEstatisticas(nota1, nota2, nota3, nota4, nota5);
}

/*
4. Fa ̧ca em C# uma fun ̧c ̃ao que recebe dois n ́umeros reais como parˆametros e devolve como
resultado o menor valor entre eles.
*/
static double Min(double x, double y)
    {
        if (x < y) 
            return (x);
        else
            return (y);
    }

/*
5. Fa ̧ca em C# uma fun ̧c ̃ao que recebe dois n ́umeros reais como parˆametros e devolve como
resultado o maior valor entre eles.
*/

static double Max(double x, double y)
    {
        if (x > y)
            return (x);
        else
            return (y);
   }

/* 6. Fa ̧ca em C# um procedimento que recebe como parˆametros cinco n ́umeros reais corresponden-
tes `as notas de um aluno. O procedimento deve:
(a) calcular a m ́edia, a maior e a menor nota (utilize as fun ̧c ̃oes auxiliares das quest ̃oes ante-
riores);
(b) mostrar os resultados.
*/

static void DeterminarEstatisticas(double nota1, double nota2, double nota3,
double nota4, double nota5)
    {
        double soma = 0, media, maior, menor;
        soma = soma + (nota1 + nota2 + nota3 + nota4 + nota5);
        media = soma/5;

        menor = Min(nota1, nota2);
        menor = Min(menor, nota3);
        menor = Min(menor, nota4);
        menor = Min(menor, nota5);

        maior = Max(nota1, nota2);
        maior = Max(maior, nota3);
        maior = Max(maior, nota4);
        maior = Max(maior, nota5);

        Console.WriteLine($"O menor valor foi: {menor}");
        Console.WriteLine($"O maior valor foi: {maior}");
        Console.WriteLine($"A média das notas foi: {media}");

    }
}




