using System;

internal class Program {
    private static void Main(string[] args) {

        double salario1, salario2;
        string nome1, nome2;
        int idade1, idade2;
        char genero1, genero2;

        Console.Write("Digite o nome da primeira pessoa: ");
        nome1 = Console.ReadLine();
        Console.Write("Digite a idade da primeira pessoa: ");
        idade1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o salario da primeira pessoa: ");
        salario1 = double.Parse(Console.ReadLine());
        Console.Write("Informe o sexo da primeira pessoa: (F/M) ");
        genero1 = char.Parse(Console.ReadLine());
        Console.Write("Informe o nome da segunda pessoa: ");
        nome2 = Console.ReadLine();
        Console.Write("Informe o salario da segunda pessoa: ");
        salario2 = double.Parse(Console.ReadLine());
        Console.Write("Informe a idade da segunda pessoa: ");
        idade2 = int.Parse(Console.ReadLine());
        Console.Write("Informe o sexo da segunda pessoa: (F/M) ");
        genero2 = char.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Dados da primeira pessoa: ");
        Console.WriteLine("Nome: " + nome1);
        Console.WriteLine("Idade: " + idade1);
        Console.WriteLine("Salario: " + salario1);
        Console.WriteLine("Sexo: " + genero1);
        Console.WriteLine();
        Console.WriteLine("Dados da segunda pessoa: ");
        Console.WriteLine("Nome: " + nome2);
        Console.WriteLine("Idade: " + idade2);
        Console.WriteLine("Salario: " + salario2);
        Console.WriteLine("Sexo: " + genero2);

    }
}