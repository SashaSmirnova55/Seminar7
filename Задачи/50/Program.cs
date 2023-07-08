// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет
void Main()
{
    int[,] matrix = FillMatrix(3, 4, -100, 100);
    PrintMatrix(matrix);
    ElementSearch(matrix);
}


int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
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


void ElementSearch(int[,] matrix)
{
    int row = ReadInt("Введите номер строки: ");
    int col = ReadInt("Введите номер столбца: ");
    if (row <= matrix.GetLength(0) && col <= matrix.GetLength(1))
    {
        System.Console.WriteLine($"Значение: {matrix[row, col]} ");
    }
    else
    {
        System.Console.WriteLine($"Элемента с таким адресом в матрице не существует.");
    }
}


Main();