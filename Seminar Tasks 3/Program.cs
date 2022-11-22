// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом(первое число равно последнему, второе равно предпоследнему)

Console.Write("Введите пятизначное число ");
int number1 = int.Parse(Console.ReadLine());

string num1 = Convert.ToString(number1);

int length = num1.Length;

if (length==5)
{
    if (num1[0] == num1[4] && num1[1] == num1[3])
    {
        Console.WriteLine($"{number1} - это полиндром");
    }
    else
    {
        Console.WriteLine($"{ number1} не является полиндромом");
    }   
}
else
{
    Console.WriteLine ("Вы ввели не пятизначное число");
}

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Write("Введите координату х первой точки ");
// int x1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату y первой точки ");
// int y1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату z первой точки ");
// int z1 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату х второй точки ");
// int x2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату y второй точки ");
// int y2 = int.Parse(Console.ReadLine());
// Console.Write("Введите координату z второй точки ");
// int z2 = int.Parse(Console.ReadLine());

// double S = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
// Console.WriteLine ($"Расстояние между точками {S:f2}");

//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// Console.Write("Введите колличество степеней для тройки ");
// int N = int.Parse(Console.ReadLine()!);

// if (N<0)
// {
//     Console.Write ("Число преобразовано в положительное");
//     N = -N;
// }
// for (int i=1; i<=N; i++)
// {
//     Console.WriteLine ($"{Math.Pow(i,3)} ");
// }