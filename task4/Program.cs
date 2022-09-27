// Задача 60.
// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,
// добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] GetMatrix(int r, int c, int m)
{
    int tmp = 0;
    int[,,] matrix = new int[r, c, m];
    for (int i = 0; i < r; i++)
    {
        for (int j = 0; j < c; j++)
        {
            for (int l = 0; l < m; l++)
            {
                tmp = new Random().Next(10, 100);
                while (CheckMatrix(matrix, tmp) == false)
                {
                    tmp = new Random().Next(10, 100);
                }
                matrix[i, j, l] = tmp;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] inputMatrix)
{
    for (int i = 0; i < inputMatrix.GetLength(0); i++)
    {
        for (int m = 0; m < inputMatrix.GetLength(1); m++)
        {
            for (int l = 0; l < inputMatrix.GetLength(2); l++)
            {
                Console.Write(inputMatrix[i, m, l] + "(" + i + "," + m + "," + l + ")" + "\t");
            }
            Console.WriteLine();
        }
    }
}

int[,,] matrix = GetMatrix(2, 2, 2);
PrintMatrix(matrix);
Console.WriteLine();

bool CheckMatrix(int[,,] matrix, int number)
{
    bool check = true;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int depth = matrix.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int l = 0; l < depth; l++)
            {
                if (matrix[i, j, l] == number) check = false;

            }
        }
    }
    return check;
}
