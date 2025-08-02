/* Console.WriteLine("Hello, World!");
Console.WriteLine("Congratulations!");
Console.Write("You wrote your first line of C#"); */

/* Console.WriteLine("This is the first Line");
Console.Write("This is a second Line"); */

// Einheit 2

// print char
Console.WriteLine('b');

// more then on char
//Console.WriteLine('not a char');

Console.WriteLine(0.25f); // float
Console.WriteLine(0.25); // double
Console.WriteLine(0.25m); // decimal
Console.WriteLine(true); // bool

// variables
string firstName;
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

firstName = "Bob";
Console.WriteLine(firstName);

// Einheit 5
var message = "Hello World!";

// Einheit 6
var userName = "Bob";
var messageCount = 3;
var temperature = 34.4;

Console.WriteLine($"Hello {userName}, you have {messageCount} new messages. The temperature is {temperature}°C.");

//Übung 3, Einheit 2
Console.WriteLine("Hello\nWorld!");
Console.WriteLine("Hello\tWorld!");
Console.WriteLine("Hello \"World!\"");
Console.WriteLine("c:\\source\\repos");

Console.WriteLine(@"    c:\source\repos
        This is where your code goes");

// Einheit 3
string message1 = "Hello World!" + firstName;

// Übung 4 Einheit 2
int firstNumber = 5;
int secondNumber = 10;
Console.WriteLine(firstNumber + secondNumber);
Console.WriteLine(firstName + " sold " + firstNumber + " widgets ");

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * 5m / 9m;
Console.WriteLine($"The temperature in Celsius is {celsius}°C.");