// Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.
Console.Clear();
Console.WriteLine("Введие два числа:");
Console.Write("a = ");
int numA = int.Parse(Console.ReadLine());
Console.Write("b = ");
int numB = int.Parse(Console.ReadLine());

if (numA > numB) 
{
    Console.WriteLine($"{numA} > {numB}");
} else if (numA < numB)
{
    Console.WriteLine($"{numB} > {numA}");
} else 
    Console.WriteLine($"{numA} = {numB}");