// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// Напишите программу, которая на вход
// принимает число (N), а на выходе показывает все чётные
// числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите целое число ");
int num = int.Parse(Console.ReadLine());
int n = num;
int index = 2;
while (index < n)
{
    if (index < n ) 
    {
        Console.WriteLine(index);
    }
    index = index + 2; 

}