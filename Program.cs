// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Console.Write("Введите число подряд через пробел  ");
// int[] Arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < Arr.Length; i++)
// {
//     if (Arr[i] > 0 )
//     {
//         count++;
//     }
// }
// Console.WriteLine($"Количство элементов больше 0 : {count}");



// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

// Дополнительно (на оценку не влияют):


int Prompt(string message)
{
    System.Console.Write(message);
    int result = Convert.ToInt32(Console.ReadLine());
    return result;
}

void Main(double k1, double b1 , double k2, double b2)
{
    if (b1 == b2 && k1 == k2)
    {
        System.Console.WriteLine("Прямые совпадают ");
    }
    else if (k1 == k2)
    {
        System.Console.WriteLine("Прямые параллельны ");
    }
    else
    {
        var tuple = SystemSolution(k1, k2, b1, b2);
        System.Console.WriteLine($"Кординаты точки пересечения ({(tuple.Item1):f2}; {(tuple.Item2):f2})");
    }
}
(double, double) SystemSolution(double k1, double b1, double k2, double b2)
{
    double x = (b2 - b1) / (k1 - k2);
    double y = k1 * x + b1;
    var result = (x, y);
    return result;
}
int k1 = Prompt("Определить коффециент k1 ");
int b1 = Prompt("Определить коффециент b1 ");
int k2 = Prompt("Определить коффециент k2 ");
int b2 = Prompt("Определить коффециент b2 ");
Main(k1, b1, k2, b2);