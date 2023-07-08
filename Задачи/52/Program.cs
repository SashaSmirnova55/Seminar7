// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
void Main()
{
    int[,] matrix = FillMatrix(4, 5, -100, 100);
    PrintMatrix(matrix);
    double[] array = AritMean(matrix);
    PrintArray(array);
}


int[,] FillMatrix(int row, int col, int start, int end)
{
    int[,] matrix = new int[row, col];
    Random rand = new Random();
    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            matrix[i, j] = rand.Next(start, end + 1);
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
            System.Console.Write(matrix[i, j] + "\t");
        }
        System.Console.WriteLine();
    }
}


double[] AritMean(int[,] matrix)
{
    double[] answer = new double[matrix.GetLength(1)];
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            answer[j] += matrix[i, j];
        }
        answer[j] /= matrix.GetLength(0);;
    }
    return answer;
}


void PrintArray(double[] array)
{
    System.Console.WriteLine($"Среднее арифметическое значение каждого столбца матрицы: [ {string.Join(", ", array)} ]");
}


Main();