using System;


internal class Program {
    private static void Main(string[] args) {

        int idade;
        double salario, altura;
        char genero;
        string nome;

        idade = 29;
        salario = 4000.9;
        altura = 1.72;
        genero = 'F';
        nome = "Maria Silva";

        Console.WriteLine(idade);
        Console.WriteLine(altura);
        Console.WriteLine(salario);
        Console.WriteLine(genero);
        Console.WriteLine(nome);
        Console.WriteLine();
        Console.WriteLine("A Funcionaria " + nome + ", sexo " + genero + ", ganha R$ " + salario.ToString("F2") + " e tem " + idade + " anos." );

    }
}