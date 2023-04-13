using System;
using System.Security.Cryptography;

internal class Program {
    private static void Main(string[] args) {

        int a, b, c, menor;

        Console.Write("Digite o valor de a: ");
        a = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de B: ");
        b = int.Parse(Console.ReadLine());
        Console.Write("Digite o valor de c: ");
        c = int.Parse(Console.ReadLine());

        menor = 0;

        if (a < b && a < c) {
            menor = a;
        }
        else if (b < c) {
            menor = b;
        }
        else {
            menor = c;
        }

        Console.WriteLine();
        Console.Write("MENOR = " + menor);




    }
}