// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, team!");
Console.WriteLine("Go calc sum 1..5!");
Console.WriteLine("Go calc product 1..10!");
int sum = 0;
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Count: {i}");
    sum += i;
}
Console.WriteLine("sum=" + sum);

int product = 1;
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine($"Count: {i}");
    product *= i;
}
Console.WriteLine(product);

Console.WriteLine("Go calc average!");
Console.WriteLine($"Average = {(double)sum / 5}");
