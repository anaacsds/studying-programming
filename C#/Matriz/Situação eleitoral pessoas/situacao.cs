/*Programa em C# que lei o CPF, o nome e a idade de um conjunto de pessoas, sabendo-se que sao n pessoas.
Para cada uma delas determinar a situacao eleitoral, de acordo com a classificacao abaixo:
a) de 0 a 15 anos: nao eleitor
b) de 18 a 70 anos: eleitor obrigatorio
c) de 16 a 17 anos e acima de 70 anos: eleitor facultativa */

int idade, n, nEleitor = 0, eleitor = 0, eleitorF = 0;
string nome, cpf, situacao;

Console.Write("Qual é a quantidade de pessoas?");
n = int.Parse(Console.ReadLine());

string[,] dados = new string[n, 3]; 
int[] idades = new int[n]; 
int[] quantidadesPorSituacao = new int[3]; 
double[] percentuaisPorSituacao = new double[3]; 

for (int i = 0; i < n; i++)
{
    Console.WriteLine($"\n--- Dados da {i + 1}ª pessoa ---");
    Console.Write($"Qual o nome da pessoa?");
    nome = Console.ReadLine();
    Console.Write($"Qual o cpf da pessoa?");
    cpf = Console.ReadLine();
    Console.Write($"Qual a idade da pessoa?");
    idade = int.Parse(Console.ReadLine());

    for (i = 0; i <= idade; i++)
    {
      idade = new int[idade];
    }

    if (idade <= 15)
    {
        Eleitor++;
        situacao = "Não podera votar";
        quantidadesPorSituacao[0]++;
    }
    else if (idade >= 18 && idade <= 70)
    {
        Eleitor++;
        situacao = "podera votar";
        quantidadesPorSituacao[1]++;
    }
    else
    {
        EleitorF++;
        situacao = "Eleitor facultativo";
        quantidadesPorSituacao[2]++;

    }


    /*O valor de n deve ser informado pelo usuario. O programa deve armazenar os dados das n pessoas em uma matriz de
    n linhas e 3 colunas do tipo texto (string) e em um vetor de tamanho n do tipo inteiro. A matriz deve armazenar o
    CPF, o nome e a situacao eleitoral (uma pessoa por linha). O vetor deve armazenar as idades. Apos a entrada dos
    dados, o programa deve exibir ao usuario um menu com as seguintes opcoes:
    a) exibir a quantidade de pessoas que se enquadram em cada situacao;
    b) exibir o percentual de pessoas que se enquadram em cada situacao;
    c) exibir qual  ́e a categoria predominante (ou quais sao as categorias predominantes);
    d) sair.
    Utilize dois vetores de tamanho 3 para armazenar a quantidade e o percentual de pessoas por situacao. Os vetores
    devem ser do tipo inteiro e real, respectivamente */

    for (i = 0; i <= dados.GetLength(0); i++)
        for (int j = 0; j <= dados.GetLength(1); j++)
        {
            dados[i, j] = nome;
            dados[i, j] = cpf;
            dados[i, j] = situacao;


        }
    Console.Write($"Essa será sua situação eleitoral {dados}");
} 

