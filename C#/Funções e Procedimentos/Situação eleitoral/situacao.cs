/* 1. Fa ̧ca em C# uma fun ̧c ̃ao que recebe como parˆametro a idade de uma
pessoa e devolve como resultado a sua situa ̧c ̃ao eleitoral, conforme
abaixo:
(a) 0 a 15 anos: n ̃ao eleitor;
(b) 16 anos, 17 anos ou acima de 70 anos: eleitor facultativo;
(c) de 18 a 70 anos (inclusive): eleitor obrigat ́orio.
*/

class Public {
static void Main(string[] args) // procedimento principal que le o numero de pessoas e chama o procedimento que processa a situacao eleitoral

{
    int n;

    Console.Write("Informe o numero de pessoas: ");
    n = int.Parse(Console.ReadLine());

    ProcessarSituacaoEleitoral(n); // funcao que determina a situacao eleitoral de cada pessoa
}

static string SituacaoEleitoral(int idade) 
{

    if (idade <= 15) {
        return("Não eleitor");
    }
    else if (idade >= 18 && idade <= 70) {
        return("Eleitor obrigatório");
    }
    else {
        return("Eleitor facultativo");
    }
}


/* 2. Faca em C# um procedimento que recebe como parametros tres numeros
inteiros correspondentes aos n ́umeros de pessoas: 
(a) que podem votar,
(b) que devem votar e 
(c) que estao impedidas de votar. O procedimento deve exibir um relatorio na tela que mostre os tres numeros
recebidos de forma adequada. */



static void ExibirRelatorio(int podemVotar, int devemVotar, int impedidasDeVotar) // procedimento que exibe um relat ́orio da situa ̧c~ao eleitoral das pessoas
{

    Console.WriteLine("Quantidade de pessoas que: ");
    Console.WriteLine($" a) podem votar: {podemVotar}");
    Console.WriteLine($" b) devem votar: {devemVotar}");
    Console.WriteLine($" c) não podem votar: {impedidasDeVotar}");

}


/* 3. Faca em C# um procedimento que recebe como parametro um numero
inteiro n correspondente a um n ́umero de pessoas. O procedimento
deve:
(a) ler as idades de n pessoas;
(b) determinar a situa ̧cao eleitoral de cada uma;
(c) exibir um relatorio com o numero de pessoas em cada situa ̧cao.
*/


static void ProcessarSituacaoEleitoral(int n) // procedimento que processa a situa ̧c~ao eleitoral de um conjunto de pessoas
{
    int idade, podemVotar = 0, devemVotar = 0, impedidasDeVotar = 0;
    string situacao;
    for(int i = 1; i <= n; i++ )
    {
        Console.WriteLine($"Informe a idade da {i}º pessoa: ");
        idade = int.Parse(Console.ReadLine());

        situacao = SituacaoEleitoral(idade);
        Console.WriteLine($"Situação: {situacao}");
        
        if (situacao == "Não eleitor")
        {
            impedidasDeVotar++;
        }
        else if (situacao == "Eleitor obrigatório")
        {
            devemVotar++;
        }
        else 
        {
            podemVotar++;
        }
    }
    
    ExibirRelatorio(podemVotar, devemVotar, impedidasDeVotar);
}        
}