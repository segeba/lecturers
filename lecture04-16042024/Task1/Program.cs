int [,] CreateMatrix(int rowsCount, int columnsCount) // метод для создания матрицы
{
    int[,] matrix = new int[rowsCount, columnsCount]; // определение нового двумерного массива - 3 строки, 5 столбцов

    Random rnd = new Random(); // создание объекта класса Random

    for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - количество строк двумерного массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - количество столбцов двумерного массива
        {
            matrix[i, j] = rnd.Next(1, 11); // заполнение массива случайными числами от 1 до 10 включительно (11 не входит в диапазон)
        }
    }
    return matrix;
}

void ShowMatrix(int [,] matrix) // метод вывода матрицы на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} "); // вывод массива на экран поэлементно
        }
        Console.WriteLine(); // переход на следующую строку, построчный вывод массива
    }
}

int[,] matrix = CreateMatrix(4, 5);

ShowMatrix(matrix); // вывод матрицы на экран путем вызова метода ShowMatrix()