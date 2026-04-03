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
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        System.Console.Write("T");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
        System.Console.Write("E");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Black;
        System.Console.Write("R");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Green;
        System.Console.Write("M");
        Thread.Sleep(500);
        Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.Write("O");
        Thread.Sleep(500);
        Console.ResetColor();
        System.Console.WriteLine(" - 5 LETRAS");
        System.Console.WriteLine("-------------------------------------");
        Thread.Sleep(500);

        string[] palavras = {
            "beber", "abrir", "andar",
            "dizer", "fazer", /*"olhar",
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
            "arder"*/
        };

        int numeroAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatoria = palavras[numeroAleatorio];

        int contador = 0;

        while (true)
        {
            contador++;  
            Console.ResetColor();
            System.Console.WriteLine($"Iniciando a rodada {contador}");
            System.Console.WriteLine("Digite uma palavra: ");
            string? palavraDigitada = Console.ReadLine();

            char[] letrasAcertadas = new char[palavraAleatoria.Length];

            for (int caractere = 0; caractere < palavraAleatoria.Length; caractere++)
            {
                int letrasCorretas;

                if (caractere < palavraDigitada?.Length) 
                {
                    if (palavraDigitada[caractere] == palavraAleatoria[caractere])
                    {
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                    }

                    else
                    {

                        for (letrasCorretas = 0; letrasCorretas < palavraAleatoria.Length; letrasCorretas++)
                        {
                            if (palavraDigitada[caractere] == palavraAleatoria[letrasCorretas])
                            {
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
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
            
            Console.ResetColor();  

            if(contador == 5)
            {
                System.Console.WriteLine();
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("FIM DE JOGO!");
                System.Console.WriteLine("Que pena :( Você usou todas as suas chances!");
                System.Console.WriteLine("-------------------------------------");
                break;
            }
 
            Thread.Sleep(1000);
            Console.WriteLine();

            if (palavraDigitada == palavraAleatoria)
            {
                System.Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(palavraAleatoria.ToUpper());
                Console.ResetColor();
                Console.WriteLine("Parabéns você acertou!");
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
            }       
        }
    }
}   