using System;
using System.Runtime.InteropServices;

internal class Program {
    private static void Main(string[] args) {

        int i, x, y, troca, soma;

        Console.WriteLine("DIGITE DOIS NUMEROS: ");
        x = int.Parse(Console.ReadLine());
        y = int.Parse(Console.ReadLine());

    

        if ( x > y) {
            troca = x;
            x = y;
            y = troca;
        }

        soma = 0;
        for ( i = x + 1; i < y; i++) {
            if ( i % 2 != 0) {
                soma = soma + i;
            }
        }

        Console.Write("Soma dos impares = " + soma);
    }
}