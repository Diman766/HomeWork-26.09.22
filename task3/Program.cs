// Задача 58:
// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] matrix1 = GetMatrix(2, 3);
int[,] matrix2 = GetMatrix(3, 2);
PrintMatrix(matrix1);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine();
int rowsMatrix1 = matrix1.GetLength(0);
int columnsMatrix1 = matrix1.GetLength(1);
int rowsMatrix2 = matrix2.GetLength(0);
int columnsMatrix2 = matrix2.GetLength(1);

if (rowsMatrix1 == rowsMatrix2 && columnsMatrix1 == columnsMatrix2 || rowsMatrix1 == columnsMatrix2 && columnsMatrix1 == rowsMatrix2)
{
    int[,] MultiplySimilarMatrix(int[,] matrix1, int[,] matrix2)
    {
        int result = 0;
        int[,] resultMatrix = new int[columnsMatrix2, columnsMatrix2];
        for (int m = 0; m < rowsMatrix1; m++)
        {
            int[] array = ArrayMatrix(matrix1, m);
            for (int i = 0; i < rowsMatrix1; i++)
            {
                result = 0;


                for (int j = 0; j < columnsMatrix1; j++)
                {
                    result += array[j] * matrix2[j, i];

                }

                resultMatrix[m, i] = result;
            }

        }
        return resultMatrix;
    }
    PrintMatrix(MultiplySimilarMatrix(matrix1, matrix2));

    int[] ArrayMatrix(int[,] matrix, int numberRows)
    {
        int[] array = new int[matrix.GetLength(1)];
        for (int i = 0; i < columnsMatrix1; i++)
        {
            array[i] = matrix[numberRows, i];
        }
        return array;
    }
}
else Console.WriteLine("Матрицы не соразмерны!");