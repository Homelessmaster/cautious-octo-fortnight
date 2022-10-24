//Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
Console.Write("Введите количество чисел, которые вы хотите ввести >>> ");
int n = Convert.ToInt32(Console.ReadLine());

int count = 0;
for(int i = 0; i < n; i++)
{

    Console.Write($"Введите число {i+1} >>> ");
    int a = Convert.ToInt32(Console.ReadLine());

    if(a>0) count++;
}
Console.WriteLine($"Вы ввели {count} чисел больше нуля");
*/



//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
//           y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

Console.Write("Введите число k1 >>> ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b1 >>> ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите число k2 >>> ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число b2 >>> ");
double b2 = Convert.ToDouble(Console.ReadLine());


Console.WriteLine($"Точка пересечения двух прямых: {(b2 - b1) / (k1 - k2)}");