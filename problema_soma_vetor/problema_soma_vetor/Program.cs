using System;

internal class Program {
    private static void Main(string[] args) {

        int i, N;
        double soma, media;

        Console.Write("Quantos numeros voce vai digitar? ");
        N = int.Parse(Console.ReadLine());

        double[] vet = new double[N];
        
        for (i =0; i < N; i++) {
            Console.Write("Digite um numero: ");
            vet[i] = double.Parse(Console.ReadLine());

        }

        Console.WriteLine();
        Console.Write("VALORES = ");
        for (i =0; i < N;i++) {
            Console.Write(vet[i].ToString("F1") + " ");
        }

        soma = 0;
        for (i=0; i < N;i++) {
            soma = soma + vet[i];
        }
        media = (double) soma / N;
        
        Console.WriteLine();
        Console.Write("SOMA = " + soma);
        Console.WriteLine();
        Console.Write("MEDIA = " + media.ToString("F1"));

        
    }
}