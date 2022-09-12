//Task_41 Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// void insemiPerimeterut()
// {
//     Console.Write("Введите количество чисел: ");
//     int size = Convert.ToInt32(Console.ReadLine());
//     int[] numbers = new int[size];
//     int count = 0;
//     for ( int i = 0; i < size; i++) 
//     {
//         Console.Write("Введите число: ");
//         int x = Convert.ToInt32(Console.ReadLine());
//         if (x > 0) count++;
//     }
//     Console.WriteLine("Введено чисел больше '0': "+count);
// }

// insemiPerimeterut();

//Task_43 Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// void IntersectionsemiPerimeteroint()
// {
//     Console.Write("Введите точку b1: ");
//     double b1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите точку b2: ");
//     double b2 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите точку k1: ");
//     double k1 = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите точку k2: ");
//     double k2 = Convert.ToInt32(Console.ReadLine());
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k2 * x + b2;
//     Console.WriteLine($"Координаты точки пересечения: ({x};{y})");
// }

// IntersectionsemiPerimeteroint();

//Task_40_Hard На вход программы подаются три целых положительных числа. Определить , 
//является ли это сторонами треугольника. Если да, то вывести всю информацию по нему - площадь, периметр, 
//значения углов треугольника в градусах, является ли он прямоугольным, равнобедренным, равносторонним.
// void TriangleDefinition()
// {
//     Console.Write("Введите первую сторону треугольника: ");
//     double a = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите вторую сторону треугольника: ");
//     double b = Convert.ToInt32(Console.ReadLine());
//     Console.Write("Введите третью сторону треугольника: ");
//     double c = Convert.ToInt32(Console.ReadLine());
//     Console.Write($"{a}, {b}, {c} - ");
//     if (a < b + c && b < a + c && c < a + b)
//     { 
//         Console.WriteLine("Треугольник Возможен");
//         double Perimeter = a + b + c;
//         double semiPerimeter = (a+b+c)/2;
//         double Square = Math.Sqrt(semiPerimeter*(semiPerimeter-a)*(semiPerimeter-b)*(semiPerimeter-c));
//         double AnglesA = Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180 / Math. PI;
//         double AnglesB = Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180 / Math. PI;
//         double AnglesC = Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180 / Math. PI;
//         Console.WriteLine("Площадь треугольника = "+Square);
//         Console.WriteLine("Периметр треуголника = "+Perimeter);
//         Console.WriteLine($"Угол A = {AnglesA} градусов");
//         Console.WriteLine($"Угол B = {AnglesB} градусов");
//         Console.WriteLine($"Угол C = {AnglesC} градусов");
//         if (a == b && a == c && b == c) Console.WriteLine("Треугольник равносторонний");
//         else if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b)) Console.WriteLine("Треугольник равнобедренный");
//         else if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == b * b + a * a)) Console.WriteLine("Треугольник прямоугольный");
//         else Console.WriteLine("Треугольник разносторонний");
//     }
//     else Console.WriteLine("Треугольник не возможен");
// }

// TriangleDefinition();