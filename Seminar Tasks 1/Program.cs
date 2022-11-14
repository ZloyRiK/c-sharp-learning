// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее

// Console.Write ("Введите первое число ");
// int a = int.Parse (Console.ReadLine()!);
// Console.Write ("Введите второе число ");
// int b = int.Parse (Console.ReadLine()!);

// int max = a;

// if (a>b)
// {
//     Console.WriteLine ($"max равен {max}");
// }
// else
// {
//     max = b;
//     Console.WriteLine ($"max равен {max}");
// }

// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write ("Введите первое число ");
int a = int.Parse (Console.ReadLine()!);
Console.Write ("Введите второе число ");
int b = int.Parse (Console.ReadLine()!);
Console.Write ("Введите третье число ");
int c = int.Parse (Console.ReadLine()!);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.WriteLine ($"Максимальное число {max}");
