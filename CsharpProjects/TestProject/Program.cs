using System.Security.Cryptography;

// Função para gerar um número aleatório entre min e max (inclusive)
int RollDice(int min, int max)
{
    byte[] randomNumber = new byte[4];
    RandomNumberGenerator.Fill(randomNumber);
    int value = BitConverter.ToInt32(randomNumber, 0);
    return Math.Abs(value % (max - min + 1)) + min;
}

// Exibe uma mensagem inicial para o usuário
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("🎲 Bem-vindo ao simulador de dado! 🎲");
Console.ResetColor();
// Declara uma variável para armazenar a resposta do usuário
string resposta;
do
{
    // Gera um número aleatório entre 1 e 6, simulando o lançamento de um dado
    int roll = RollDice(1, 6);

    // Escolhe um emoticon para cada número
    string emoticon = roll switch
    {
        1 => "😐",
        2 => "🙂",
        3 => "😃",
        4 => "😎",
        5 => "🤩",
        6 => "🎉",
        _ => ""
    };

    // Define uma cor diferente para cada número
    Console.ForegroundColor = roll switch
    {
        1 => ConsoleColor.DarkGray,
        2 => ConsoleColor.Green,
        3 => ConsoleColor.Yellow,
        4 => ConsoleColor.Blue,
        5 => ConsoleColor.Magenta,
        6 => ConsoleColor.Red,
        _ => ConsoleColor.White
    };

    // Exibe o resultado do lançamento do dado
    Console.WriteLine($"Você rolou o dado e saiu: {roll} {emoticon}");
    Console.ResetColor();

    // Pergunta ao usuário se deseja rolar o dado novamente
    Console.Write("Deseja rolar novamente? (s/n): ");
    resposta = Console.ReadLine()?.Trim().ToLower();
    // Se a resposta não for "s" ou "n", peça novamente
    while (resposta != "s" && resposta != "n")
    {
        Console.Write("Por favor, responda apenas com 's' ou 'n': ");
        resposta = Console.ReadLine()?.Trim().ToLower();
    }
}
// Repete o processo enquanto o usuário responder "s" (sim)
while (resposta == "s");
// Mensagem de encerramento do programa
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Obrigado por jogar! 👋");
Console.ResetColor();