using System;

internal class Program {
    private static void Main(string[] args) {

        int x, i, N, soma;

        Console.Write("Quantos numeros serao digitados: ");
        N = int.Parse(Console.ReadLine());

        soma = 0;
        for (i = 0; i < N; i++) {
            Console.Write("Digite um numero: ");
            x = int.Parse(Console.ReadLine());
            soma = soma + x;
        }

        Console.Write("Soma dos numeros: " + soma);


    }
}