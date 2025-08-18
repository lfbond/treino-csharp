/*Exercicio 01
Random dice = new Random();
int roll1 = dice.Next(1, 7); // Generates a random number between 1 and 6
int roll2 = dice.Next(1, 7); // Generates another random number between 1 and 6
int roll3 = dice.Next(1, 7); // Generates a third random number between 1 and 6

int total = roll1 + roll2 + roll3; // Sums the three rolls

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}"); */


/*//Exercicio 02
Random dice = new Random();
int roll1 = dice.Next(1, 7); // Generates a random number between 1 and 6
int roll2 = dice.Next(1, 7); // Generates another random number between 1 and 6
int roll3 = dice.Next(1, 7); // Generates a third random number between 1 and 6

int total = roll1 + roll2 + roll3; // Sums the three rolls

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if (total >= 12)
{
    Console.WriteLine("You win!");
}

if (total <= 11)
{
    Console.WriteLine("Sorry, you lose!");
} */

/* 
//Exercicio 03
string message = "The quick brown fox jumps over the lazy dog.";
bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?");
} */

/*Exercicio 04
Random dice = new Random();
int roll1 = dice.Next(1, 7); // Generates a random number between 1 and 6
int roll2 = dice.Next(1, 7); // Generates another random number between 1 and 6
int roll3 = dice.Next(1, 7); // Generates a third random number between 1 and 6

int total = roll1 + roll2 + roll3; // Sums the three rolls
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
Console.WriteLine("You rolled doubles! +2 bonus to total");
Console.WriteLine(total + 2);
}
else if((roll1 != roll2) || (roll2 != roll3) || (roll1 != roll3)) {
    
    if (total < 12)
    {
        Console.WriteLine("You win!");
    }

    if (total >= 12)
    {
        Console.WriteLine("Sorry, you lose!");
    }
    
} */

//Exercicio 05
Random dice = new Random();
int roll1 = dice.Next(1, 7); // Generates a random number between 1 and 6
int roll2 = dice.Next(1, 7); // Generates another random number between 1 and 6
int roll3 = dice.Next(1, 7); // Generates a third random number between 1 and 6

int total = roll1 + roll2 + roll3; // Sums the three rolls
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total");
    Console.WriteLine(total + 2);
}

if ((roll1 == roll2) && (roll2 == roll3))
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    Console.WriteLine(total + 6);
}

if (total < 12)
{
    Console.WriteLine("Sorry, you lose!");
}

if (total >= 12)
{
    Console.WriteLine("You win!");
}

