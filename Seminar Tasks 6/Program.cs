// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

// Console.Write("Сколько чисел вы хотите ввести? ");
// int size = int.Parse(Console.ReadLine()!);

// int[] array = GetArray(size, -100, 101);
// int count = Counter(array);
// Console.WriteLine("Если не помните, то вы ввели следующие числа: ");
// Console.WriteLine($"[ {String.Join(", ", array)} ]");

// Console.WriteLine($"Всего введено {count} чисел отличных от нуля");
// Console.WriteLine($"Вот такая магия");

// // --------------------Metods-------------------

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     Console.WriteLine($"Введите по очереди {size} чисел");
//     int[] result = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = int.Parse(Console.ReadLine()!);
//     }
//     return result;
// }

// int Counter(int[] array)
// {
//     int result = 0;
//     for (int i=0; i<array.Length; i++)
//     {
//         if (array[i]!=0)
//         {
//             result++;
//         }
//     }
//     return result;
// }

// Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

Console.Write("Задайте размер массива ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size, 0, 101);
if (size <= 6)
{
    Console.WriteLine("Вы просите слишком мало. Введите больше 6");
}
else
{
    Console.WriteLine($"Получен массив размера {size}");
    Console.WriteLine($"[ {String.Join(", ", array)} ]");
    int[] structure = Structure(array);
    Console.WriteLine($"Упорядоченный массив будет выглядеть вот так:");
    Console.WriteLine($"[ {String.Join(", ", structure)} ]");
    Console.WriteLine($"Вот такая магия");

}



// --------------------Metods-------------------

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue);

    }
    return result;
}

int[] Structure(int[] array)
{
    int[] temp = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length-1; j++)
        {
            if (array[j] > array[j+1])
            {
                temp[j] = array[j];
                array[j]= array[j+1];
                array[j+1] = temp[j];
            }
        }
    }
    return array;
}