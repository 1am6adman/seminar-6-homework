﻿Console.Write("Введите числа(через пробел): ");
int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int count = arr.Count(x => x > 0);
Console.WriteLine($"Кол-во элементов больше 0: {count}");