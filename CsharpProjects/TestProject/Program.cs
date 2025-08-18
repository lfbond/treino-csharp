/* //Exercicio 01
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

if (total < 15)
{
    Console.WriteLine("Sorry, you lose!");
}

else
{
    Console.WriteLine("You win!");
}
 */

/*  //Exercicio 02
Random dice = new Random();
int roll1 = dice.Next(1, 7); // Generates a random number between 1 and 6
int roll2 = dice.Next(1, 7); // Generates another random number between 1 and 6
int roll3 = dice.Next(1, 7); // Generates a third random number between 1 and 6

int total = roll1 + roll2 + roll3; // Sums the three rolls
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        Console.WriteLine(total + 6);

    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total");
        Console.WriteLine(total + 2);
    }
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

else
{
    Console.WriteLine("Sorry, you lose!");
} */

/* //Exercicio 03
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        Console.WriteLine(total + 6);
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        Console.WriteLine(total + 2);

    }

    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
} */

//Exercicio 04
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
    discountPercentage = 20;
}
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
    discountPercentage = 10;
}
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}