using System;
using System.Diagnostics.Tracing;

internal class Program {
    private static void Main(string[] args) {

        int i, j, N, M;

        Console.Write("Quantas linha vai ter a matriz? ");
        N = int.Parse(Console.ReadLine());
        Console.Write("Quantas colunas vai ter a matriz? ");
        M = int.Parse(Console.ReadLine());

        int[,] mat = new int[N, M];

        for (i = 0; i < N; i++) {
            for (j = 0; j < M; j++) {
                Console.Write("ELEMENTO [ " + i + ", " + j + " ]: ");
                mat[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("MATRIZ DIGITADA:");

        for (i=0; i < N; i++) {
            for (j=0; j < M; j++) {
                Console.Write(mat[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}