using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main (String[] args)
    {
        Cabecalho.ExibirCabecalho();

        Jogo.nRodadas++;  
        Console.ResetColor();
        System.Console.WriteLine("-------------------------------------");
        System.Console.WriteLine($"Iniciando a rodada {Jogo.nRodadas}");
        System.Console.WriteLine("Digite uma palavra: ");
        Jogo.palavraDigitada = Console.ReadLine();

        Jogo.JogoEmAndamento();
    }
}