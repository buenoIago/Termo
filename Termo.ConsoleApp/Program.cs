using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main (String[] args)
    {
        while (true)
        {
            Cabecalho.ExibirCabecalho();

            Jogo.nRodadas++;  
            Console.ResetColor();
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine($"Iniciando a rodada {Jogo.nRodadas}");
            System.Console.WriteLine("Digite uma palavra: ");
            Jogo.palavraDigitada = Console.ReadLine();
    
            Jogo.JogoEmAndamento();
    
            if (!JogadorDesejaContinuar())
            {
                System.Console.WriteLine("Encerrando o jogo...");
                Thread.Sleep(1000);
            }
        }
        
    }
    static bool JogadorDesejaContinuar()
    {
        Console.Write("Deseja continuar o jogo? (s/N): ");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;

        else
        return true;   
    }
}