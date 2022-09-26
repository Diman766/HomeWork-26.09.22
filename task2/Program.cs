// Задача 56: 
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] GetMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)

        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            Console.Write(inputMatrix[i, m] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] matrix = GetMatrix(3, 3);
PrintMatrix(matrix);
Console.WriteLine();

int[] GetSumArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int[] array = new int[rows];
    for (int i = 0; i < rows; i++)
    {
        int sum = 0;
        for (int j = 0; j < columns; j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int m = 0; m < array.GetLength(0); m++)
    {
        Console.WriteLine(array[m]);
    }
}
PrintArray(GetSumArray(matrix));
Console.WriteLine();

// int[] a = { 1, 3, 2 };
int MinRows(int[] array)
{
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[min] > array[i]) min = i;
    }
    return min + 1;
}

Console.WriteLine(MinRows(GetSumArray(matrix)));


