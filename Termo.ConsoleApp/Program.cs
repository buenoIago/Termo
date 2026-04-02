using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

class Program
{
    static void Main (String[] args)
    {
        Console.Clear();

        System.Console.WriteLine("-------------------------------------");
        System.Console.Write("TERMO");
        System.Console.WriteLine(" - 5 LETRAS");
        System.Console.WriteLine("-------------------------------------");

        string[] palavras = {
            "beber", "abrir", "andar",
            /*
            "dizer", "fazer", "olhar",
            "ouvir", "pedir", "parar", "pegar",
            "jogar", "viver", "lutar", "nadar",
            "tocar", "temer", "saber",
            "poder", "caber", "haver", "medir",
            "subir", "valer", "bater",
            "mexer", "lavar", "secar", "colar",
            "remar", "rezar", "rolar", "morar",
            "dotar", "notar", "lotar", "botar",
            "tirar", "gerar", "negar", "jurar",
            "calar", "selar", "gelar", "velar",
            "arder"
            */
        };

        int numeroAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[numeroAleatorio];

        System.Console.WriteLine($"Palavra sorteada foi {palavraAleatoria}");

        while (true)
        {
            Console.ResetColor();
                
            System.Console.WriteLine("Digite uma palavra: ");
            string? palavraDigitada = Console.ReadLine();

            char[] letrasAcertadas = new char[palavraAleatoria.Length];

            for (int caractere = 0; caractere < palavraAleatoria.Length; caractere++)
            {
                int letrasCorretas;

                if (caractere < palavraDigitada.Length)
                {
                    if (palavraDigitada[caractere] == palavraAleatoria[caractere])
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }

                    else
                    {

                        for (letrasCorretas = 0; letrasCorretas < palavraAleatoria.Length; letrasCorretas++)
                        {
                            if (palavraDigitada[caractere] == palavraAleatoria[letrasCorretas])
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            }
                        }   

                        if(letrasCorretas == palavraAleatoria.Length)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }                
                    }
                Console.Write(palavraDigitada[caractere] + " ");
                }                                       
            }   
        Thread.Sleep(1000);
        }          
    }
}