﻿// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел строго больше 0 ввёл пользователь.

Console.Write ("Введите числа через пробел ");
int[] array = GetArray (Console.Readline()!);
Console.WriteLIne ($"Введено чисел больше нуля {Count(array)}");
// Console.WriteLine();

// --------------------Metods-------------------

int[] GetArray()

// Написать программу, которая на вход принимает массив из любого количества элементов (не менее 6)в промежутке от 0 до 100, а на выходе выводит этот же массив, но отсортированный по возрастанию(от меньшего числа к большему).

