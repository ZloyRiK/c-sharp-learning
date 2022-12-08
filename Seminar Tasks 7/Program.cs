// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


/*
Console.Write("введите количество строк ");
int linesVol = int.Parse(Console.ReadLine()!);
Console.Write("введите количество столбцов ");
int columnsVol = int.Parse(Console.ReadLine()!);
double[,] numbers = new double[linesVol, columnsVol];
GetArray(numbers);
PrintArray(numbers);

// --------------Metods----------------

void GetArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {String.Join(", ", array[i,j])} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
*/

// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.



// Console.WriteLine("введите номер строки");
// int n = int.Parse(Console.ReadLine()!);
// Console.WriteLine("введите номер столбца");
// int m = int.Parse(Console.ReadLine()!);
// int [,] numbers = new int [10,10];
// GetArray(numbers);

// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {numbers[n-1,m-1]}");
//     PrintArray(numbers);
// }

// --------------Metods----------------

// void GetArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//         {        
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 array [i,j] = new Random().Next(-100, 100)/10;
//             }   
//         }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {String.Join(", ", array[i,j])} ");
//         }   
//         Console.Write("]");
//         Console.WriteLine(""); 
//     }
// }



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

Console.Write("введите количество строк");
int n = int.Parse(Console.ReadLine());
Console.Write("введите количество столбцов");
int m = int.Parse(Console.ReadLine());

int[,] numbers = new int[n, m];
GetArray(numbers);
Console.WriteLine();
PrintArray(numbers);
Console.WriteLine();

// --------------Metods----------------

for (int j = 0; j < numbers.GetLength(1); j++)
{
    double avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write($"[ {String.Join(", ", avarage)} ]");
}

void GetArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
}

void PrintArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}