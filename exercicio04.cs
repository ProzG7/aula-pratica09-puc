
using System;

public class Program
{
    public static void Main(string[] args)
    {
        string frase;
        Console.WriteLine("Digite uma palavra");
        frase = Console.ReadLine();
        Console.Write("Palavra de trás para frente: ");
        for(int i = frase.Length - 1; i >= 0; i--){
            
            Console.Write(frase[i]);
        }
    }
}
