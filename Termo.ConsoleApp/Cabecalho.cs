class Cabecalho
{
    public static void ExibirCabecalho()
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
        System.Console.WriteLine("O");
        Thread.Sleep(500);
        Console.ResetColor();
        System.Console.WriteLine("-------------------------------------");
        Thread.Sleep(500);

        System.Console.WriteLine("Menu de opções\n1 - Iniciar Jogo\n2 - Regras");
        System.Console.Write("Digite sua escolha: ");
        int opcao = Convert.ToInt32(Console.ReadLine());

        switch (opcao)
        {
            case 1: 
            break;

            case 2:
            Regras();
            return;

            default:
            return;
        }
    }
            
    public static void Regras()
    {
        System.Console.WriteLine("\nREGRAS");
        System.Console.WriteLine("1 - Descubra a palavra certa em 5 tentativas");

        System.Console.Write("2 - A letra na cor '");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        System.Console.Write("A");
        Console.ResetColor();
        System.Console.WriteLine("' informa que a letra está na posição correta.");

        System.Console.Write("3 - A letra na cor '");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        System.Console.Write("B");
        Console.ResetColor();
        System.Console.WriteLine("' informa que a letra existe na palavra, mas em outra posição.");

        System.Console.Write("4 - A letra na cor '");
        Console.ForegroundColor = ConsoleColor.DarkGray;
        System.Console.Write("C");
        Console.ResetColor();
        System.Console.WriteLine("' informa que a letra não faz parte da palavra.");

        System.Console.WriteLine("5 - As palavras podem conter letras repetidas.");

        System.Console.WriteLine("\nPressione ENTER para continuar");
        Console.ReadLine();
    }       
}