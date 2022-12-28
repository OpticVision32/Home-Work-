/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Random r = new Random();
int[] array = new int[90];
int last = array.Length - 1;
for (int i = 0; i < array.Length; i++)
{
    array[i] = 10 + i;
}

int[,,] FillMatrix(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows, columns, depth];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                int x = r.Next(last);
                matrix[i, j, k] = array[x];
                array[x] = array[last - 1];
                last--;
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                System.Console.Write($"{matrix[i, j, k]}({i},{j},{k})");
            }
            System.Console.WriteLine();
        }
    }
}

int[,,] matrix = FillMatrix(4, 4, 4);
PrintMatrix(matrix);
