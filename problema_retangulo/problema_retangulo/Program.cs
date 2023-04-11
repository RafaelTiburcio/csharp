using System;

internal class Program {
    private static void Main(string[] args) {
        
        double baseretangulo, altura, area, perimetro, diagonal;

        Console.Write("Informe a base do retangulo: ");
        baseretangulo= double.Parse(Console.ReadLine());
        Console.Write("Informe a altura do retangulo: ");
        altura = double.Parse(Console.ReadLine());

        area = baseretangulo * altura;
        perimetro = 2 * (baseretangulo + altura);
        diagonal = Math.Sqrt(baseretangulo * baseretangulo + altura * altura );

        Console.WriteLine("Area do retangulo = " + area.ToString("F4"));
        Console.WriteLine("Perimetro do retangulo = " + perimetro.ToString("F4"));
        Console.WriteLine("Diagonal do retangulo = " + diagonal.ToString("F4"));


    }
}