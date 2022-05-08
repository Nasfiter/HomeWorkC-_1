// Напишите программу, которая принимает на
// вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
Console.Write("Введите целое число А = ");
int numA = int.Parse(Console.ReadLine());

Console.Write("Введите целое число B = ");
int numB = int.Parse(Console.ReadLine());

Console.Write("Введите целое число C = ");
int numC = int.Parse(Console.ReadLine());

int max = numA;
if (numA > max) max = numA;
if (numB > max) max = numB;
if (numC > max) max = numC;
Console.Write("Наибольшее чистло из трех равно = ");
Console.Write(max);
