// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

// Console.Write("введите количество строк ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("введите количество столбцов ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 100);
// Console.WriteLine("Получен массив случайных чисел:");
// PrintArray(array);
// SortColums(array);
// Console.WriteLine("Массив был отсортирован:");
// PrintArray(array);

// // --------------Metods----------------

// int[,] GetArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {String.Join(", ", array[i, j])} ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// void SortColums(int[,] array)
// {
//     int temp = 0;
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int k = 0; k < array.GetLength(1) - 1; k++)
//             {
//                 if (array[i, k] < array[i, k + 1])
//                 {
//                     temp = array[i, k + 1];
//                     array[i, k + 1] = array[i, k];
//                     array[i, k] = temp;
//                 }
//             }
//         }
//     }
// }


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Console.Write("введите количество строк ");
// int rows = int.Parse(Console.ReadLine()!);
// Console.Write("введите количество столбцов ");
// int columns = int.Parse(Console.ReadLine()!);
// int[,] array = GetArray(rows, columns, 0, 10);
// Console.WriteLine("Получен массив случайных чисел:");
// PrintArray(array);
// Console.WriteLine($"Строка с наименьшей суммой {SumCheck(array)}");


// // --------------Metods----------------

// int[,] GetArray(int rows, int columns, int minValue, int maxValue)
// {
//     int[,] array = new int[rows, columns];
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(minValue, maxValue + 1);
//         }
//     }
//     return array;
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         Console.Write("[ ");
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($" {String.Join(", ", array[i, j])} ");
//         }
//         Console.Write("]");
//         Console.WriteLine("");
//     }
// }

// int SumCheck(int[,] array)
// {
//     int minsum = 0;
//     int result = 0;
//     for (int l = 0; l < array.GetLength(1); l++)
//     {
//         minsum = minsum + array[0, l];
//     }
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum = sum + array[i, j];
//         }
//         if (minsum > sum)
//         {
//             minsum = sum;
//             result = i;
//         }
//     }
//     return result;
// }


// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.


// Не решена



Console.Write("введите количество строк ");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("введите количество столбцов ");
int columns = int.Parse(Console.ReadLine()!);
int[,] array = GetArray(rows, columns, 0, 10);
int[,] array2 = GetArray(rows, columns, 0, 10);
// int[,] array3 = ProizvMatrix(rows, columns, 0, 10);
Console.WriteLine("Получен массив случайных чисел:");
PrintArray(array);
Console.WriteLine("Получен второй массив случайных чисел:");
PrintArray(array2);
// Console.WriteLine ("Произведение матриц равно:");
// PrintArray(array3);



// --------------Metods----------------

int[,] GetArray(int rows, int columns, int minValue, int maxValue)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($" {String.Join(", ", array[i, j])} ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

// int[,] ProizvMatrix (int[,] array)
// {
//     int[,]result= new int[rows, columns];
//     int resrows=1;
//     int rescolums=1;
//     for(int k=0; k<array.GetLength(0); k++)
//     {
//         for (int i=0; i<array.GetLength(0); i++)
//         {
//             resrows= resrows*array[i,k];
//             for(int j=0; j<array.GetLength(1);j++)
//             {
//                 rescolums=rescolums*array[k,j];
//             }
//         }
//     result [k]=resrows+rescolums;
//     }
//     return result;
// }