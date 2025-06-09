using System;

public class Program
{
    public static void Main(string[] args)
    {
        string frase;
        string fraseCriptografada;
        Console.WriteLine("Digite uma frase");
        frase = Console.ReadLine();
        frase = frase.ToLower();
        fraseCriptografada = frase.Replace("a", "*");
        fraseCriptografada = fraseCriptografada.Replace("e", "*");
        fraseCriptografada = fraseCriptografada.Replace("i", "*");
        fraseCriptografada = fraseCriptografada.Replace("o", "*");
        fraseCriptografada = fraseCriptografada.Replace("u", "*");
        Console.WriteLine(fraseCriptografada);
        //for(int i = 0; i < frase.Length; i++){
            //if(frase[i] == 'a' || frase[i] == 'e' || frase[i] == 'i' || frase[i] == 'o' || frase[i] == 'u'){*/
                
            //}
            //else
                
        //}

    }
}
