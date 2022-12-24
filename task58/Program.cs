/*

Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Random r = new Random();

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        System.Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result)) break;
        else System.Console.WriteLine("not number");

    }
    return result;
}

int[,] FillMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = r.Next(1, 9);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] MultiplyMatrix(int[,] aMatrix, int[,] bMatrix)
{
    int[,] cMatrix = new int[aMatrix.GetLength(0), bMatrix.GetLength(1)];
    int sum = 0;
    for (int i = 0; i < cMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < cMatrix.GetLength(1); j++)
        {
            for (int k = 0; k < cMatrix.GetLength(1); k++)
            {
                sum += aMatrix[i, k] * bMatrix[k, j];
            }
            cMatrix[i, j] = sum;
            sum = 0;
        }
    }
    return cMatrix;


}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int[,] aMatrix = FillMatrix(rows, columns);
int[,] bMatrix = FillMatrix(rows, columns);
PrintMatrix(aMatrix);
System.Console.WriteLine();
PrintMatrix(bMatrix);
System.Console.WriteLine();
int[,] cMatrix = MultiplyMatrix(aMatrix, bMatrix);
PrintMatrix(cMatrix);