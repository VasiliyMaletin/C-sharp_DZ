//Task_47 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// double[,] NewMatrix()
// {
//     Console.Write("Введите количество строк: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите количество столбцов: ");
//     int n = Convert.ToInt32(Console.ReadLine());
    
//     double[,] matrix = new double[m, n];
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j <matrix.GetLength(1); j++)
//         {
//             Random random = new Random();
//             matrix[i, j] = random.Next(-10, 101) + random.NextDouble();   
//             Console.Write(Math.Round(matrix[i, j], 2)+"\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
//     return matrix;
// }
// NewMatrix();

//Task_50 Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// int [,] search = new int[4, 4];
// void NewMatrix(int[,] matrix)
// { 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix [i, j] = new Random().Next(1, 101);
//             Console.Write(matrix[i, j]+"\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// } 

// void Input()
// {
//     Console.Write("Введите номер строки: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите номер столбца: ");
//     int n = Convert.ToInt32(Console.ReadLine());

//     if (m < search.GetLength(0) && n < search.GetLength(1)) Console.WriteLine(search[m, n]);
//     else Console.WriteLine(m+", "+n+" -> такого числа в массиве нет");
// }

// NewMatrix(search);
// Input();

//Task_52 Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// int[,] numbers = new int [5, 3];
// void NewMatrix(int[,] matrix)
// { 
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             matrix [i, j] = new Random().Next(1, 10);
//             Console.Write(matrix[i, j]+"\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// } 

// void Average(int[,] numbers)
// {
//     for (int j = 0; j < numbers.GetLength(1); j++)
//     {
//         double avg = 0; 
//         for (int i = 0; i < numbers.GetLength(0); i++)
//         {
//             avg += numbers[i, j];
//         }
//         if (j == numbers.GetLength(1) - 1) Console.Write(avg / numbers.GetLength(0)+"."); 
//         else Console.Write(avg / numbers.GetLength(0)+"; ");
//     }
//     Console.WriteLine();
// }
// NewMatrix(numbers);
// Average(numbers);
