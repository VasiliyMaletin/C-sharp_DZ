//Task_34 Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// Random rd = new Random();
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(N);

// int[] FillArray(int number)
// {
//     int[] array = new int[number];
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = rd.Next(100, 1000);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int i in array)
//     {
//     if (i == array[N-1]) Console.Write(i+".");
//     else Console.Write(i+", ");
//     }
//     Console.WriteLine();
// }

// void EvenNumbers(int[] array)
// {
//     int count = 0;
//     foreach (int i in array)
//     {
//         for (int j = i; j % 2 == 0; j++)
//         {
//             count++;
//         }
//     }
//     Console.Write("Количество чётных чисел = "+count);
// }

// PrintArray(array);
// EvenNumbers(array);

//Task_36 Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// Random rd = new Random();
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(N);

// int[] FillArray(int number)
// {
//     int[] array = new int[number];
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = rd.Next(1, 101);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int i in array)
//     {
//     if (i == array[N-1]) Console.Write(i+".");
//     else Console.Write(i+", ");
//     }
//     Console.WriteLine();
// }

// void Sum(int[] array)
// {
//     int sum = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (i % 2 == 1) sum += array[i];
//     }
// Console.WriteLine("Сумма нечётных индексов = "+sum);
// }

// PrintArray(array);
// Sum (array);

//Task_38 Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// Random rd = new Random();
// Console.Write("Введите размер массива: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(N);

// int[] FillArray(int number)
// {
//     int[] array = new int[number];
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = rd.Next(-100, 101);
//     }
//     return array;
// }

// void PrintArray(int[] array)
// {
//     foreach (int i in array)
//     {
//     if (i == array[N-1]) Console.Write(i+".");
//     else Console.Write(i+", ");
//     }
//     Console.WriteLine();
// }

// void Difference(int[] array)
// {
//     int max = array[0];
//     int min = array[0];
//     int diff = 0;
//     for (int i= 0; i<array.Length; i++)
//     {
//         if (array[i] > max) max = array[i];
//         if (array[i] < min) min = array[i];
//     }
//     diff = max - min;
//     Console.WriteLine("Разница между max и min = "+diff);
// }

// PrintArray(array);
// Difference(array);

//Task_19_Hard Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.
// void Palindrom()
// {
//     Console.Write("Введите число: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     int result = 0;
//     int number = n;
//     while (number > 0) 
//     {
//         result *= 10;
//         result += number % 10;
//         number /= 10;
//     }
//     if (n == result) 
//     {
//         Console.WriteLine("Является");
//     }
//     else Console.WriteLine("Не является");
// }

// Palindrom();