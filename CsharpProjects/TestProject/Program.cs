// Cria uma instância da classe Random para gerar números aleatórios
Random dice = new Random();

// Exibe uma mensagem inicial para o usuário
Console.WriteLine("Bem-vindo ao simulador de dado!");

// Declara uma variável para armazenar a resposta do usuário
string resposta;

do
{
    // Gera um número aleatório entre 1 e 6, simulando o lançamento de um dado
    int roll = dice.Next(1, 7);

    // Exibe o resultado do lançamento do dado
    Console.WriteLine($"Você rolou o dado e saiu: {roll}");

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
Console.WriteLine("Obrigado por jogar!");