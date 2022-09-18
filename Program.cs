//Task_54 Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// void FillArray(int[,] table)
// {
//     Random random = new Random();
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = random.Next(1, 100);
//         }
//     }
// }

// void PrintArray(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write(table[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void SortArray(int [,] table)
// {   
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1) - 1; j++)
//         {
//             for (int k = 0; k < table.GetLength(1) - 1; k++)
//             {
//                 if (table[i, k] < table[i, k+1]) 
//                 {
//                     int temp = table[i, k];
//                     table[i, k] = table[i, k+1];
//                     table[i, k+1] = temp;
//                 }
//             }
//         }
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите кол-во строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите кол-во столбцов: ");
// int cols = Convert.ToInt32(Console.ReadLine());
// int[,] table = new int[rows, cols];

// FillArray(table);
// PrintArray(table);
// SortArray(table);
// PrintArray(table);

//Task_56 Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// void FillArray(int[,] table)
// {
//     Random random = new Random();
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = random.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write(table[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// void SumRows(int[,] table)
// {
//     int min = Int32.MaxValue;
//     int rows = 0;
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             sum += table[i, j];
//         }
//         if (min > sum)
//         {
//             min = sum;
//             rows++;
//         }
//     }
// Console.WriteLine($"Минимальная сумма = {min}, в строке - {rows}.");
// }

// int[,] table = new int[4, 5];
// FillArray(table);
// PrintArray(table);
// SumRows(table);

//Task_58 Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// int size = 3;
// int[,] FirstTable = new int[size, size];
// int[,] SecondTable = new int[size, size];
// int[,] ProductTable = new int[size, size];

// void FillArray(int[,] table)
// {
//     Random random = new Random();
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             table[i, j] = random.Next(1, 10);
//         }
//     }
// }

// void PrintArray(int[,] table)
// {
//     for (int i = 0; i < table.GetLength(0); i++)
//     {
//         for (int j = 0; j < table.GetLength(1); j++)
//         {
//             Console.Write(table[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// FillArray(FirstTable);
// PrintArray(FirstTable);
// FillArray(SecondTable);
// PrintArray(SecondTable);

//     for (int i = 0; i < size; i++)
//     {
//         for (int j = 0; j < size; j++)
//         {
//             for (int k = 0; k < size; k++)
//             {
//                 ProductTable[i, j] += FirstTable[i, k] * SecondTable[k, j];
//             }
//         }
//     }
// PrintArray(ProductTable);

//Task_60 Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Console.Write("Введите размерность z: ");
// int z = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность y: ");
// int y = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность x: ");
// int x = Convert.ToInt32(Console.ReadLine());
// int[,,] array3D = new int[z, y, x];
// int maxnumbers = 90;

// if (z * y * x > maxnumbers)
// {
//     Console.Write("Массив слишком большой!");
//     return;
// }

// FillArray(array3D);
// PrintArray(array3D);

// void FillArray(int[,,] array3D)
// {
//     static IEnumerable<int> UniqueRandomNumbers(int from, int to)
//     {
//         Random rand = new();
//         int[] values = Enumerable.Range(10, 90).ToArray();
//         int i = values.Length;
//         while (i > 0)
//         {
//             int j = rand.Next(i--);
//             yield return values[j];
//             (values[i], values[j]) = (values[j], values[i]);
//         }
//     }
//     IEnumerator<int> randoms = UniqueRandomNumbers(10, 90).GetEnumerator();
//     randoms.MoveNext();
//     for (int i = 0; i < array3D.GetLength(0); ++i)
//     {
//         for (int j = 0; j < array3D.GetLength(1); ++j)
//         {
//             for (int k = 0; k < array3D.GetLength(2); ++k, randoms.MoveNext())
//             {
//                 array3D[i, j, k] = randoms.Current;
//             }
//         }
//     }
// }

// void PrintArray(int[,,] array3D)
// {
//     for (int i = 0; i < array3D.GetLength(0); i++)
//     {
//         for (int j = 0; j < array3D.GetLength(1); j++)
//         {
//             for (int k = 0; k < array3D.GetLength(2); k++)
//             {
//                 Console.Write($"[{i},{j},{k}] {array3D[i, j, k]}\t");
//             }
//             Console.WriteLine();
//         }
//         Console.WriteLine();
//     }
// }

//Task_62 Напишите программу, которая заполнит спирально массив 4 на 4.
// Console.Write("Введите размер массива: ");
// int size = Convert.ToInt32(Console.ReadLine());
// int[,] Spiral = new int[size, size];

// void FillArray(int[,] Spiral)
// {
//     int count = 1;
//     int i = 0;
//     int j = 0;

//     while (count <= size * size)
//     {
//         Spiral[i, j] = count;
//         if (i <= j + 1 && i + j < size - 1) j++;
//         else if (i < j && i + j >= size - 1) i++;
//         else if (i >= j && i + j > size - 1) j--;
//         else i--;
//         count++;
//     }
// }

// void PrintArray(int[,] Spiral)
// {
//     for (int i = 0; i < Spiral.GetLength(0); i++)
//     {
//         for (int j = 0; j < Spiral.GetLength(1); j++)
//         {
//             Console.Write(Spiral[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// FillArray(Spiral);
// PrintArray(Spiral);