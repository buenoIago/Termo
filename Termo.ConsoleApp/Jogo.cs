using System.Security.Cryptography;

class Jogo
{
    public static string[] palavras = {
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

            qtdErros++;
            Console.ResetColor();  

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

            if(qtdErros == 5)
            {
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
