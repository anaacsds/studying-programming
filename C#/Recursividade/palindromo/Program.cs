/* Crie bool palindromo(string s, int esq, int dir) que retorne true se a string for um palíndromo.

Exemplo: "arara" → true, "casa" → false. Leia a string pelo teclado. */

class Program
{
    static void Main(string[]args)
    {
        Console.WriteLine("Digite uma palavra para saber se é um palíndromo: ");
        string a = Console.ReadLine();

        Console.Clear();

        int esq = 0, dir = a.Length - 1;
        Console.WriteLine($"{a} : {palindromo(a, esq, dir)}");
    }

    static bool palindromo(string s, int e, int d)
    {
        if (e >= d)                                 
            return true;                           

        if (s[e] != s[d])
            return false;                           

        return palindromo(s, e + 1, d - 1); 
    }
}