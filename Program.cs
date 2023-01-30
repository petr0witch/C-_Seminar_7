// Урок 7. Двумерные массивы

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
/*
double[,] RandomArray2d()
{
    Console.WriteLine("Генерация случайного двухмерного массива");
    Console.WriteLine("Кол-во строк: ");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Кол-во столбцов: ");
    int columns = Convert.ToInt32(Console.ReadLine());

    double[,] array = new double[rows, columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 1);
    }
    return array;
}

void Show(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
     Console.WriteLine();
    }
}

Show(RandomArray2d());
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> элемента с такими индексами в массиве нет

double[,] RandomArray2d(int rows, int columns)
{
    double[,] array = new double[rows, columns];

    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            array[i, j] = Math.Round(new Random().NextDouble() * 10, 0);
    }
    return array;
}

void Find(double[,] array, int rows, int columns)
{
    if(rows < array.GetLength(0) && columns < array.GetLength(1) ) Console.Write($"Значение array[{rows}, {columns}] = {array[rows, columns]}");
    else Console.Write($"Значения array[{rows}, {columns}] - не существует");
}

void Show(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
     Console.WriteLine();
    }
}

Console.WriteLine("Поиск значения по индексу массива");
Console.Write("Введите номер строки: ");
int i = Convert.ToInt16(Console.ReadLine());
Console.Write("ВВедите номер столбца: ");
int j = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Генерация случайного двухмерного массива");
int rows = Convert.ToInt32(new Random().Next(1, 10));
Console.WriteLine($"Кол-во строк: {rows}");
int columns = Convert.ToInt32(new Random().Next(1, 10));
Console.WriteLine($"Кол-во столбцов: {columns}");

double[,] newArray = RandomArray2d(rows, columns);
Show(newArray);
Find(newArray, i, j);


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

/*
int[,] array = new int[,] {
            {1, 4, 7, 2},
            {5, 9, 2, 3},
            {8, 4, 2, 4},
}; 

void Median(int[,] array)
{
    for(int j = 0; j < array.GetLength(1); j++)
    {
        double med = 0;
        for(int i = 0; i < array.GetLength(0); i++)
        {
            med += array[i, j];
        }
    med /= array.GetLength(0);
    Console.WriteLine($"Среднее арифметическое по столбцу {j} = {Math.Round(med, 2)}");
    }
}

Median(array);
*/