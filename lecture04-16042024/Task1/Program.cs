int[,] matrix = new int[3, 5]; // определение нового двумерного массива - 3 строки, 5 столбцов

Random rnd = new Random(); // создание объекта класса Random

for (int i = 0; i < matrix.GetLength(0); i++) // matrix.GetLength(0) - количество строк двумерного массива
{
    for (int j = 0; j < matrix.GetLength(1); j++) // matrix.GetLength(1) - количество столбцов двумерного массива
    {
        matrix[i, j] = rnd.Next(1, 11); // заполнение массива случайными числами от 1 до 11 включительно
    }
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]} "); // вывод массива на экран поэлементно, построчно
    }
    Console.WriteLine();
}