//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. (Задачи, решенные через Math.Pow, будут отправлены на переделку, так как задача стоит в том, чтобы написать цикл)

// Console.Write("Введите число A: ");
// int numberA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число B: ");
// int numberB = Convert.ToInt32(Console.ReadLine());

// int exponentiation = Exponentiation(numberA, numberB);
// Console.WriteLine($"{numberA} в степени {numberB} будет равно {exponentiation}");



//---------------Metods-----------------------

// int Exponentiation(int numberA, int numberB){
//   int result = 1;
//   for(int i=1; i <= numberB; i++){
//     result = result * numberA;
//   }
//     return result;
// }

// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// Console.Write("Введите число N: ");
// int numberN = Convert.ToInt32(Console.ReadLine());

// int sum = SumNumbers(numberN);

// Console.WriteLine ($"Сумма цифр числа равна {sum}");


//---------------Metods-----------------------

// int SumNumbers(int numberN){

//     int lentgh = Convert.ToString(numberN).Length;
//     int result = 0;
    
//     for (int i=1; i<=lentgh; i++)
//     {
//         result = result + (numberN%10);
//         numberN = numberN /10;
//     }
//     return result;
// }


//Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. (числа берете любые)

int[] array = GetArray(8, 0, 100);  // верхние и нижние границы заданы для сокращения цифр в числах массива
Console.WriteLine("Получен массив из 8-ми случайных чисел от 1 до 100");
Console.WriteLine($"[ {String.Join(", ", array)} ]");

//---------------Metods-----------------------

int[] GetArray(int size, int minValue, int maxValue){
    int[] result = new int[size];
    for (int i=0; i<size; i++){
        result[i] = new Random().Next(minValue, maxValue+1);
    }
    return result;
}
