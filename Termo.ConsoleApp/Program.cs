using System.Security.Cryptography;

class Program
{
    static void Main (String[] args)
    {
        Console.Clear();

        System.Console.WriteLine("-------------------------------------");
        System.Console.Write("TERMO");
        System.Console.WriteLine("- 5 LETRAS");
        System.Console.WriteLine("-------------------------------------");

        string[] palavras = {
            "abrir", "achar", "água", "ajudar",
            "amar", "amigo", "beber", "casa",
            "chorar", "claro", "comer", "correr",
            "criar", "deixar", "descer", "dever",
            "entrar", "falar", "fechar", "fogo",
            "forte", "jogar", "leve", "livro",
            "metal", "mudar", "nadar", "noite",
            "odiar", "olhar", "ouvir", "papel",
            "pedra", "pegar", "pensar", "praia",
            "pular", "rir", "sair", "sentir",
            "somar", "subir", "tentar", "tinta",
            "vento", "verde", "vidro", "viver"
        };

        int numeroAleatorio = RandomNumberGenerator.GetInt32(palavras.Length);

        string palavraAleatorio = palavras[numeroAleatorio];

        System.Console.WriteLine($"Palavra sorteada foi {palavraAleatorio}");

        while (true)
        {
            
        }
          
    }
}