// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите количество чисел - ");
// int a = Convert.ToInt32(Console.ReadLine());
// int [] arr = new int [a];
// int z=1;
// int x=0;
// int count=0;
// while (x<arr.Length)
// {
//     Console.Write($"Введите {z} чисело - ");
//     arr[x] = Convert.ToInt32(Console.ReadLine());
   
//     if (arr[x]>0)
//     {
//         count++;
//     }
//     x++;
//     z++;
// }
// Console.WriteLine($"Вы ввели {a} чисел, из которых {count} чисел больше ноля");

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.Write("Для расчета координат точки пересечения двух прямых введите значение - ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для расчета координат точки пересечения двух прямых введите значение - ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для расчета координат точки пересечения двух прямых введите значение - ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Для расчета координат точки пересечения двух прямых введите значение - ");
double k2 = Convert.ToDouble(Console.ReadLine());
double x=(b2-b1)/(k1-k2);
double y=k1*x+b1;
Console.WriteLine($"Точка пересечения для прямых заданных уравнениями y=k1*x+b1; y=k2*x+b2 будет иметь координаты по оси х = {x}, по оси у = {y}");