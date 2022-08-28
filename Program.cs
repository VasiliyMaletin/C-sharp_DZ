//Task_19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// void Palindrom()
// {
// Console.Write("Введите пятизначное число: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int a = n / 10000;
// int b = n % 10; 
// int c = (n / 1000) % 10;
// int d = (n / 10) % 10;
// if (n > 9999 && n < 100000)
//     {
//     if (a == b && c == d) 
//         {
//         Console.WriteLine("Является");
//         }
//     else Console.WriteLine("Не является");
//     }
// else Console.WriteLine("Нужно вводить пятизначное число!");
//     }
// try
//     {
//     Palindrom();
//     }
// catch
//     {
//     Console.WriteLine("Нужно вводить цифры!");
//     }

// Task_21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// double Res()
//     {
//     Console.WriteLine("Введите координаты точки A (x,у,z):");
//     int Ax = Convert.ToInt32(Console.ReadLine());
//     int Ay = Convert.ToInt32(Console.ReadLine());
//     int Az = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine("Введите координаты точки B (x,у,z):");
//     int Bx = Convert.ToInt32(Console.ReadLine());
//     int By = Convert.ToInt32(Console.ReadLine());
//     int Bz = Convert.ToInt32(Console.ReadLine());
//     int x = Bx - Ax;
//     int y = By - Ay;
//     int z = Bz - Az;
//     double distance = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2));
//     return distance;
//     }
// try
//     {
//     Console.WriteLine($"Расстояние между A и B: {Res()}");
//     }
// catch
//     {
//     Console.WriteLine("Введите цифры");
//     }

//Task_23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// void Cube()
//     {
//     Console.Write("Введите число: ");
//     int n = Convert.ToInt32(Console.ReadLine());
//     if (n < 1) Console.WriteLine("Нужно вводить число больше 0!");
//     for (int i = 1; i <= n; i++) Console.Write($"{i*i*i} ");
//     }
// try
//     {
//     Cube();
//     }
// catch
//     {
//     Console.WriteLine("Нужно вводить число!");
//     }

//Optional_task Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, 
//пока сумма введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.
//Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.
void SumSquareNumber()
    {
    Console.WriteLine("Введите число:");
    int a = Convert.ToInt32(Console.ReadLine());
    int b = a;
    int c = a * a;
    int d = 0;
    int e = d + c;
    while (b != 0)
        {
        a = Convert.ToInt32(Console.ReadLine());
        b += a;
        c = a * a;
        e += c;
        d = c;
        }
    Console.WriteLine($"Сумма квадратов всех считанных чисел: {e}");
    }
try 
    {
    SumSquareNumber();
    }
catch
    {
    Console.WriteLine("Нужно вводить цифры!");
    }