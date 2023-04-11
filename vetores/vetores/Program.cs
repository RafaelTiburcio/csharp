using System;

internal class Program {
    private static void Main(string[] args) {

        int i, N;
        double soma;
        


        Console.Write("Quantos numeros voce vai digitar: ");
        N = int.Parse(Console.ReadLine());

        double [] vet = new double[N];

        for (i = 0; i < N; i++) {
            Console.Write("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine());

        }

        Console.WriteLine();
        Console.WriteLine("NUMEROS DIGITADOS: ");

        for (i =0; i < N; i++) {
            Console.WriteLine(vet[i]);
        }

        soma = 0;

        for (i=0; i < N; i++) {
            soma = soma + vet[i];
        }

        Console.WriteLine();
        Console.Write("Soma dos numeros: " + soma);
    }
}