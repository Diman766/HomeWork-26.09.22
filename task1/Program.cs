// Задача 54:
//  Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

int[,] matrix = GetMatrix(5, 5);
PrintMatrix(matrix);

int[,] ChangeMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    Console.WriteLine();
    for (int i = 0; i < columns; i++)
    {
        for (int m = 0; m < rows; m++)
        {

            int tmp = 0;
            for (int j = 0; j < rows - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    tmp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = tmp;
                }
            }

        }
    }
    return matrix;
}


PrintMatrix(ChangeMatrix(matrix));



