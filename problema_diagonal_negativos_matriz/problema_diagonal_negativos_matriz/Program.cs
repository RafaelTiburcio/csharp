using System;

internal class Program {
    private static void Main(string[] args) {

        int i, j, N, cont;

        Console.Write("Qual a ordem da matriz? ");
        N = int.Parse(Console.ReadLine());

        int[,] mat = new int[N,N];

        for (i = 0; i < N; i++) {
            for (j = 0; j < N; j++) {
                Console.Write("ELEMENTO [ " + i + ", "+ j + " ]: ");
                mat[i,j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine();
        Console.WriteLine("MATRIZ DIGITADA: ");
        for (i=0; i < N; i++) {
            for (j=0; j < N; j++) {
                Console.Write(mat[i,j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
        Console.WriteLine("DIAGONAL PRINCIPAL: ");
        for (i = 0; i < N; i++) {
            Console.Write(mat[i, i] + " ");
        }

        cont = 0;
        for (i = 0; i < N; i++) {
            for (j = 0; j < N ; j++) {
                if (mat[i,j] < 0) {
                    cont = cont + 1;
                }
            }
        }

        Console.WriteLine();
        Console.Write("QUANTIDADE NUMEROS NEGATIVOS: " + cont);



    }
}