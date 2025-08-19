//Exercicio 01

//Testing a change to the message.
//int widgetsSold = 7;
//Console.WriteLine($"{firstName} sold {widgetsSold} widgets.");
/* string firstName = "Bob";
int widgetsPurchased = 7;

Console.WriteLine($"{firstName} purchased {widgetsPurchased} widgets."); */

/* //Exercicio 02 - com Comentários fracos
Random random = new Random();
string[] orderIDs = new string[5];
//Loop through eac blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    //Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    //Covert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    //Create a random number, pad with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    //Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
//Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
} */

/* //Exercicio 02 - sem Comentários
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
} */

/* //Exercicio 02 - com Comentários de nível superior


 //  The following code creates five random OrderIDs
 //  to test the fraud detection process. OrderIDs
 //  consist of a letter from A to E, and a three
 //  digit number. Ex. A123.

Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
} */

/* //Exercício 03 - Exemplo01
Console
.
WriteLine
(
"Hello Example 1!"
)
;

// Example 2:
string firstWord="Hello";string lastWord="Example 2";Console.WriteLine(firstWord+" "+lastWord+"!"); */

/* //Exercício 03 - Exemplo02
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
        Console.WriteLine($"Total = {total + 6}");
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        Console.WriteLine($"Total = {total + 2}");
    }
} */

/* //Exercício 04 - DESAFIO

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times."); */



/* //Exercício 04 - DESAFIO-SOLUÇÃO-MINHA

//The high-level purpose of this code is to reverse a 
//string and count the number of times a specific character appears.

string messageOld = "The quick brown fox jumps over the lazy dog.";
char[] message = messageOld.ToCharArray();

Array.Reverse(message);
int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string new_message = new String(message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times."); */



//Exercício 04 - DESAFIO-SOLUÇÃO-REAL
//   This code reverses a message, counts the number of times 
//   a particular character appears, then prints the results
//   to the console window.

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");