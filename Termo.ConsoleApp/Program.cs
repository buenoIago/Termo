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

            Jogo.JogoEmAndamento();

            if (!JogadorDesejaContinuar())
            {
                System.Console.WriteLine("Encerrando o jogo...");
                Thread.Sleep(1000);
                break;
            }
        }       
    }

    static bool JogadorDesejaContinuar()
    {
        Console.Write("Deseja jogar novamente? (s/N): ");
        string? opcaoContinuar = Console.ReadLine()?.ToUpper();

        if (opcaoContinuar != "S")
            return false;

        else
        return true;   
    }
}