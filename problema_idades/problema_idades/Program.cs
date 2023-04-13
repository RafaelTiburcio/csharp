using System;


internal class Program {
    private static void Main(string[] args) {

        int i, j, N, M, soma;
        double media;

        Console.Write("Qunatas pessoas serao digitadas? ");
        N = int.Parse(Console.ReadLine());

        string[] vetPessoas = new string[N];
        int[] vetIdades = new int[N];
        
        for (i = 0; i < N;i++) {
            Console.WriteLine("DADOS DA " + (i + 1) + "a pessoa:");
            Console.Write("Nome: ");
            vetPessoas[i] = Console.ReadLine();
            Console.Write("Idade: ");
            vetIdades[i] = int.Parse(Console.ReadLine());

        }

        soma = 0;

        for (i = 0; i < N;i++) {
            soma = soma + vetIdades[i];
        }

        media = (double) soma / N;

        Console.WriteLine();    
        Console.WriteLine("Nomes:");
        for (i = 0; i < N; i++) {
            Console.WriteLine(vetPessoas[i] + ", ");
        }

        Console.WriteLine();
        Console.Write("SOMA DAS IDADES: " + soma);
        Console.WriteLine();
        Console.Write("MEDIA DAS IDADES: " + media.ToString("F2"));
        




    }
}