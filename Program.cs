using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

void calculateNumbers(int a, int b)
{
    int sum = a + b;
    int difference = a - b;
    int product = a * b;
    double quotient = (double)a / b;
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Difference: {difference}");
    Console.WriteLine($"Product: {product}");
    Console.WriteLine($"Quotient: {quotient}");
}