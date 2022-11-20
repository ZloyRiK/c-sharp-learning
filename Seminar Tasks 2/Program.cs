// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// Обязательна проверка на ввод чисел больше/меньше 3-х знаков

// Console.Write("Введите трехзначное число ");

// int number1 = int.Parse(Console.ReadLine());

// string temp = Convert.ToString(number1);
// int length = temp.Length;

// if (length==3)
// {
//     Console.WriteLine($"Вторая цифра {temp[1]}");
// }
// else 
// {
//     Console.WriteLine ("Число не трехзначное");
// }

// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000

// Random rnd = new Random();
//  
// int number2 = rnd.Next(0, 10000);

// string num2 = Convert.ToString(number2);

// if (num2.Length > 2)
// {
//     Console.WriteLine($"Получено число {number2}");
//     Console.WriteLine($"Третья цифра числа {num2[2]}");
// }
// else
// {
//     Console.WriteLine($"Получено меньше трех цифр: {number2}");
// }

// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным. Обязательна проверка на ввод числа <1 и >7

Console.Write ("Введите число дня недели от 1 до 7 ");
int week = int.Parse(Console.ReadLine());

if (week == 6 || week == 7)
{
    Console.WriteLine ("Этот день выходной");
}
else 
{
    if (week <1 || week > 7)
    {
        Console.WriteLine ("Нет такого дня");
    }
    else
    {
        Console.WriteLine ("Этот день рабочий");
    }
}