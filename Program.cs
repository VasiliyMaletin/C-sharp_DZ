//Task_25 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// void degree()
// {
//     Console.WriteLine("Введите число A и B: ");
//     int number_A = Convert.ToInt32(Console.ReadLine());
//     int number_B = Convert.ToInt32(Console.ReadLine());
//     int natural_degree = number_A;
//     int count = 2;
//     if (number_B > 0)
//     {
//         while (count <= number_B) 
//         {
//             natural_degree *= number_A; count++;
//         }
//         Console.WriteLine("Натуральная степень = "+natural_degree);
//     }
//     else if (number_B < 0) Console.WriteLine("Введите положительное число 'B'!");
//     else Console.WriteLine("Натуральная степень = 1");
// }
// try
// {
//     degree();
// }
// catch
// {
//     Console.WriteLine("Нужно вводить цифры!");
// }

//Task_27 Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// void SUM()
// {
//     Console.Write("Введите число: ");
//     int number = Convert.ToInt32(Console.ReadLine());
//     int remainder = number % 10;
//     int sum = 0;
//     while (number != 0) 
//     {
//         number /= 10; sum += remainder; remainder = number % 10;
//     }
//     Console.WriteLine("Сумма цифр в числе = "+sum);
// }
// try
// {
//     SUM();
// }
// catch
// {
//     Console.WriteLine("Нужно вводить цифры!");
// }

//Task_29 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// Random rd = new Random();
// int[] array = FillArray(8);
// int[] FillArray(int number)
// {
//     int[] array = new int[number];
//     for (int i = 0; i < 8; i++)
//     {
//         array[i] = rd.Next(1, 101);
//     }
//     return array;
// }
// void PrintArray(int[] Array)
// {
//     foreach (int i in Array)
//     {
//         if (i == Array[7]) Console.Write(i+". "); // есть недочёт, если Array[7] повторяется в массиве. как можно исправить?
//         else Console.Write(i+", ");
//     }
// }
// PrintArray(array);

//Optional_Task Написать программу сортировки массива от большего к меньшему. Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.
// Random rd = new Random();
// Console.Write("Введите число: ");
// int N = Convert.ToInt32(Console.ReadLine());
// int[] array = FillArray(N);

// int[] FillArray(int number)
// {
//     int[] array = new int[number];
//     for (int i = 0; i < N; i++)
//     {
//         array[i] = rd.Next(1, 100);
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
// void Sort(int [] array)
// {   
//     for (int i = 0; i < array.Length - 1; i++)
//     {
//         int max = i;
//         for (int j = i+1; j < array.Length; j++)
//         {
//             if (array[j] > array[max] ) max = j;
//         }
//         int help = array[i];
//         array[i] = array[max];
//         array[max] = help;
//     }
// }
// PrintArray(array);
// Sort(array);
// PrintArray(array);
