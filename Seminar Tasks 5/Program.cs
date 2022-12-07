// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// int[] array = GetArray(4, 100, 1000);
// int count = Counter(array);
// Console.WriteLine("Получен массив из 4-x случайных чисел от 100 до 1000");
// Console.WriteLine($"[ {String.Join(", ", array)} ]");

// Console.WriteLine($"В нем содержится четных чисел {count}");

// //---------------Metods-----------------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);

//     }
//     return result;
// }

// int Counter(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             result++;
//         }
//     }
//     return result;
// }



// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях(индексы элементов должны быть нечетными(1,3,5 и тд))


// int[] array = GetArray(10, 0, 100);
// int count = Counter(array);
// Console.WriteLine("Получен массив из 10 случайных чисел от 1 до 100");
// Console.WriteLine($"[ {String.Join(", ", array)} ]");

// Console.WriteLine($"Сумма нечетных элементов равна {count}");

// //---------------Metods-----------------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);

//     }
//     return result;
// }

// int Counter(int[] array)
// {
//     int result = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 != 0)
//         {
//             result= result+array[i];
//         }
//     }
//     return result;
// }




// Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// Console.WriteLine("Введите длинну массива:");
// int size = int.Parse(Console.ReadLine()!);

// int[] array = GetArray(size, 0, 10);
// int[] prod = Prod(array);
// Console.WriteLine("Получен массив из 10 случайных чисел от 0 до 100");
// Console.WriteLine($"[ {String.Join(", ", array)} ]");

// Console.WriteLine($"Парное произведение чисел массива [ {String.Join(", ", prod)} ]"); // вывести массив с ответами

// //---------------Metods-----------------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = new Random().Next(minValue, maxValue);

//     }
//     return result;
// }

// int[] Prod(int[] array)
// {

//     int l = array.Length;
//     int size = l / 2;
//     int[] result;

//     if (l % 2 == 0)
//     {
//         result = new int[size];
//     }
//     else
//     {
//         result = new int[size + 1];
//     }
//     for (int i = 0; i < size; i++, l--)
//     {
//         result[i] = array[i] * array[l-1];
//     }

//     return result;
// }




// Задайте массив целых чисел от -10 до 10. Найдите разницу между максимальным и минимальным элементов массива.


int[] array = GetArray(10, -10, 11);
Console.WriteLine($"[{String.Join(", ", array)}]");
Console.WriteLine($"Разница между минимальным и максимальным числом массива = {MinMaxDif(array)}");


// ---------------Metods--------------------

int[] GetArray(int size, int minVal, int maxVal)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(minVal, maxVal);
    }
    return array;
}



int MinMaxDif(int[] array)
{
    int min = array[0];
    int max = array[0];
    int result = 0;
    foreach(int i in array)
    {
        if(i < min){
            min = i;
        } 
        
        if(i > max){
            max = i;
        }
    }
    result = max-min;
    return result;
}
