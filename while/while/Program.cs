﻿using System;

internal class Program {
    private static void Main(string[] args) {

        int x, soma;

        Console.Write("Digite o primeiro numero: ");
        x = int.Parse(Console.ReadLine());

        soma = 0;

        while ( x != 0) {
            soma = soma + x;
            Console.Write("Digite um numero: ");
            x = int.Parse(Console.ReadLine());

        }

        Console.WriteLine("Soma dos numeros: " + soma);
    }
}