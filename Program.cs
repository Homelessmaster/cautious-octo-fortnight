// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

/*
void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-10, 10) * new Random().NextDouble();
            Console.Write($"{matrix[i,j]:f1}\t");
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double [n, m];
InputMatrix(matrix);
*/


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//            и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

void FindIndexMatrix(int[,] matrix)
{
    if (a >= 0 && a < matrix.GetLength(0) + 1 && b >= 0 && b < matrix.GetLength(1) + 1)
    {
        Console.Write($"Там находится число: {matrix[a - 1, b - 1]} \t");
    }
    else
    {
        Console.WriteLine("Такого числа в массиве нет");
    }
}

Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

InputMatrix(matrix);

Console.Write("Введите номер строки: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int b = Convert.ToInt32(Console.ReadLine());

FindIndexMatrix(matrix);
*/


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}

string ArithmeticMean(int[,] matrix)
{
    double ArithmeticMeanSumm = 0;
    string result = string.Empty;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        ArithmeticMeanSumm = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            ArithmeticMeanSumm = ArithmeticMeanSumm + matrix[i, j];
        }
        ArithmeticMeanSumm = ArithmeticMeanSumm/matrix.GetLength(1);
        result = result + Convert.ToString(ArithmeticMeanSumm)  + "     ";
    }
    return result;
}



Console.Clear();
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];

InputMatrix(matrix);

Console.WriteLine();
Console.WriteLine($"Cредние арифмитические: {ArithmeticMean(matrix)}");