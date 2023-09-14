using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string nome = Console.ReadLine();

        Console.Write("Digite um número: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int contador = 0;

        while (contador < n)
        {
            Console.WriteLine(nome);
            contador++;
        }
    }
}
