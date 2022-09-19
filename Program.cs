//Task_64 Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// string IntervalOfNumbers(int m, int n)
// {
//     if (n == m - 1) return "";
//     return IntervalOfNumbers(m, n - 1) + " " + Convert.ToString(n);
// }

// try
// {
//     Console.Write("Введите число m: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число n: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine(IntervalOfNumbers(m, n));
// }

// catch
// {
//     Console.WriteLine("Введите натуральное число!!!");
// }

//Task_66 Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// int SumNumbers(int m, int n)
// {
//     if (n == m - 1) return 0;
//     return SumNumbers(m, n - 1) + n;
// }

// try
// {
//     Console.Write("Введите число M: ");
//     int m = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите число N: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Сумма чисел = " + SumNumbers(m, n));
// }

// catch
// {
//     Console.WriteLine("Введите натуральное число!!!");
// }

//Task_68 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// int Akkerman(int m, int n)
// {
//     if (m == 0) return n + 1;
//     else if (m > 0 && n == 0) return Akkerman(m - 1, 1);
//     else return Akkerman(m - 1, Akkerman(m, n - 1));
// }

// try
// {
//     Console.Write("Введите число M: ");
//     int m = Convert.ToInt32 (Console.ReadLine());
//     Console.Write("Введите число N: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("A(m, n) = " + Akkerman(m, n));
// }

// catch
// {
//     Console.WriteLine("Введите положительное число!!!");
// }