using System;


internal class Program {
    private static void Main(string[] args) {

        int hora;
        Console.Write("Digite uma hora do dia: ");
        hora = int.Parse(Console.ReadLine());

        if (hora < 12) {
            Console.WriteLine("Bom dia!");
        }
        else if (hora < 18) {
            Console.WriteLine("Boa Tarde!");
        }
        else {
            Console.WriteLine("Boa noite!");
        }
    }
}