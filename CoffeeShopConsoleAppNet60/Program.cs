// See https://aka.ms/new-console-template for more information
using CoffeeShopConsoleAppNet60;

Console.WriteLine("Hello, World!");

List<Coffee> coffees = new List<Coffee>()
{
    new Latte(2),
    new BlackCoffee(3),
    new Cortado(4)
};

foreach (var c in coffees)
{
    Console.WriteLine(c);
}

Console.WriteLine("Coffee with milk:");
List<Coffee> CoffeeWithMilk = new List<Coffee>()
{
    new Latte(1),
    new Cortado(2)
};

foreach (var co in CoffeeWithMilk)
{
    Console.WriteLine(co);
}



