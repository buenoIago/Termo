using System.Security.Cryptography;

class Jogo
{
    public static string[] palavras = { 
    "dizer", "fazer", "olhar","pedir", "lutar",
    };

    public static int nRodadas = 0;
    public static int qtdErros = 0;
    public static string? palavraDigitada;
    public static int numeroAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);
    static string palavraAleatoria = palavras[numeroAleatorio];

    public static void ConfigurarJogo(int numeroRodadas, int quantidadeErros, string palavraDigitada1)
    {
        nRodadas = numeroRodadas;
        qtdErros = quantidadeErros;
        palavraDigitada = palavraDigitada1;
    }
    
    public static void JogoEmAndamento()
    {
        while (true)
        {
            nRodadas++;  
            Console.ResetColor();
            System.Console.WriteLine("-------------------------------------");
            System.Console.WriteLine($"Iniciando a rodada {nRodadas}");
            System.Console.WriteLine("Digite uma palavra: ");
            palavraDigitada = Console.ReadLine(); 

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
            
            System.Console.WriteLine();
            qtdErros++;
            Console.ResetColor();  

            if (palavraDigitada == palavraAleatoria)
            {
                nRodadas = 0;
                qtdErros = 0;
                System.Console.WriteLine("-------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(palavraAleatoria.ToUpper());
                Console.ResetColor();
                Console.WriteLine("Parabéns você acertou!");
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                return; 
            } 

            if(qtdErros == 5)
            {
                nRodadas = 0;
                qtdErros = 0;
                System.Console.WriteLine();
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("FIM DE JOGO!");
                System.Console.WriteLine("Que pena :( Você usou todas as suas chances!");
                System.Console.WriteLine("-------------------------------------");
                System.Console.WriteLine("Pressione ENTER para continuar");
                Console.ReadLine();
                return;
            }

            Thread.Sleep(1000);
            Console.WriteLine();

        }        
    }
}
