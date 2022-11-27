
// ================================= start ===============================================

// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

/*
int[,] CreateDimArray()
{
    Console.Write("Print row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newDimArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newDimArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newDimArray;
}

void PrintDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SortDescendDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int minI = i;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int minJ = j;
            for (int m = j; m < array.GetLength(1); m++)
            {
                if (array[minI, minJ] < array[i, m])
                {
                    int temp = array[minI, minJ];
                    array[minI, minJ] = array[i, m];
                    array[i, m] = temp;
                }
            }
        }
    }
    return array;
}

int[,] newDimArray = CreateDimArray();
PrintDimArray(newDimArray);
int[,] sortDimArray = SortDescendDimArray(newDimArray);
PrintDimArray(sortDimArray);
*/

// ======================================== end =====================================


// ================================= start ===============================================

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

/*
int[,] CreateDimArray()
{
    Console.Write("Print row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newDimArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newDimArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newDimArray;
}

void PrintDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[] FindSmallSumRow(int[,] array)
{
    int[] sumArray = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        sumArray[i] = sum;
    }
    return sumArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}  ");
    }
    Console.WriteLine();
}

void SmallElement(int[] array)
{
    int minI = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[minI])
        {
            minI = i;
        }
    }
    Console.WriteLine($"с наименьшей суммой элементов: {minI + 1} строка");
}

int[,] newDimArray = CreateDimArray();
PrintDimArray(newDimArray);
int[] FindRow = FindSmallSumRow(newDimArray);
PrintArray(FindRow);
SmallElement(FindRow);
*/

// ======================================== end =====================================


// ================================= start ===============================================

// Задача 58:(дополнительно) Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

/*
int[,] CreateDimArray()
{
    Console.Write("Print row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print minValue: ");
    int minValue = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print maxValue: ");
    int maxValue = Convert.ToInt32(Console.ReadLine());
    int[,] newDimArray = new int[row, column];
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newDimArray[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return newDimArray;
}

void PrintDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
PrintDimArray(CreateDimArray());
*/

//  TO DOOOOOOOOOOOOOOOOOOO

// ======================================== end =====================================


// ================================= start ===============================================

// Задача 60.(дополнительно) ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)


// ======================================== end =====================================


// ================================= start ===============================================

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] CreateDimArray()
{
    Console.Write("Print row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.Write("Print column: ");
    int column = Convert.ToInt32(Console.ReadLine());
    int[,] newDimArray = new int[row, column];
    int cout = 0;
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < column; j++)
        {
            newDimArray[i, j] = cout;
            cout++;
        }
    }
    return newDimArray;
}

void PrintDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}  ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] SpiralDimArray(int[,] array)
{
    int[,] spiralArray = new int[array.GetLength(0), array.GetLength(1)];
    int ibeg;
    // int jbeg;
    int ifin;
    int jfin;
    int i;
    int j;
    // while(spiralArray[i,j]<=spiralArray[array.GetLength(0),array.GetLength(1)]){

    // }
    for (i = 0; i < array.GetLength(0); i++)
    {
        for (j = 0; j < array.GetLength(1); j++)
        {
            spiralArray[i, j] = array[i, j];
        }
        for (ibeg = 1; ibeg < array.GetLength(0); ibeg++)
        {
            spiralArray[ibeg, j] = array[ibeg, j];
        }
        for (jfin = 2; jfin >= 0; jfin--)
        {
            spiralArray[ibeg, jfin] = array[ibeg, jfin];
        }
        for (ifin = 2; ifin > 0; ifin--)
        {
            spiralArray[ifin, jfin] = array[ifin, jfin];
        }

    }
    return spiralArray;
}
int[,] dimArray = CreateDimArray();
PrintDimArray(dimArray);
int[,] spiralDimArray = SpiralDimArray(dimArray);
PrintDimArray(spiralDimArray);

// ======================================== end =====================================

