using Newtonsoft.Json;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


// Built-in types 
// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/built-in-types
bool w = true;
int x = 10;
float y = 10.5F; // F is literal suffix
string z = "Hello World";

// C# is a strongly typed language. 
// var is just a syntax sugar for the type inference.
var a = 10; // equivalent to int a = 10;
var b = "Hello World"; // equivalent to string b = "Hello World";

// Flow control statements
if (x == a)
{
    Console.WriteLine("x == a");
}

for (int i = 0; i < 3; i++)
{
    Console.WriteLine(i);
}

while (x < 12)
{
    Console.WriteLine(x);
    x++;
}

do
{
    Console.WriteLine(x);
    x++;
} while (x < 14);

var l = new List<int>() { 1, 2, 3, 4, 5 }; // Collection initializer!
foreach (var i in l)
{
    Console.WriteLine(i);
}

// String interpolation
Console.WriteLine($"l is {l}");
Console.WriteLine($"l json is {JsonConvert.SerializeObject(l)}");
