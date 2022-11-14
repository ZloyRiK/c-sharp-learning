Console.Write ("Введите первое число ");
int a = int.Parse (Console.ReadLine()!);
Console.Write ("Введите второе число ");
int b = int.Parse (Console.ReadLine()!);

int max = a;

if (a>b)
{
    Console.WriteLine ($"max равен {max}");
}
else
{
    max = b;
    Console.WriteLine ($"max равен {max}");
}