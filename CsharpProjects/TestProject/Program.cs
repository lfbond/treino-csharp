// Cria uma nova instância da classe Random para gerar números aleatórios
Random dice = new Random();

// Gera um número aleatório entre 1 e 6 (inclusive), simulando o lançamento de um dado
int roll = dice.Next(1, 7);

// Exibe o valor sorteado no console
Console.WriteLine(roll);