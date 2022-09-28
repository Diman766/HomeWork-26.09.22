// * Задача 62. 
// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7

// int[,] GetMatrix(int rows, int columns)
// {
//     int numbers = 0;
//     int[,] matrix = new int[rows, columns];
//     for (int j = 0; j < columns; j++)
//     {
//         matrix[columns - columns, j] = numbers;
//         numbers++;
//     }
//     for (int f = 0; f < rows - 1; f++)
//     {
//         matrix[f + 1, rows - 1] = numbers;
//         numbers++;
//     }
//     for (int j = columns - 1; j > 0; j--)
//     {
//         matrix[columns - 1, j - 1] = numbers;
//         numbers++;
//     }
//     for (int f = rows - 2; f > 0; f--)
//     {
//         matrix[f, rows - rows] = numbers;
//         numbers++;
//     }

//     for (int j = 0; j < columns - 2; j++)
//     {
//         matrix[1, j + 1] = numbers;
//         numbers++;
//     }
//     for (int f = 0; f < 1; f++)
//     {
//         matrix[2, 2] = numbers;
//         numbers++;
//     }

//     matrix[2, 1] = numbers;
//     numbers++;

//     return matrix;
// }

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

int[,] matrix = GetMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();

   int[,] GetMatrix(int rows, int columns)
        {
            int[,] matrix = new int[rows, columns];
            int row = 0, col = 0, dx = 1, dy = 0, dirChanges = 0, gran = columns;
 
            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[col, row] = i + 1;
                if (--gran == 0)
                {
                    gran = m*(dirChanges%2) + n*((dirChanges + 1)%2) - (dirChanges/2 - 1) - 2;
                    int temp = dx;
                    dx = -dy;
                    dy = temp;
                    dirChanges++;
                }
                col += dx;
                row += dy;
            }
            return A;
        }
    }
}