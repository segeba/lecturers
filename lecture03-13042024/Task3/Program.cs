void ZeroEvenElemnts(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }
}

void PrintArray(int[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
}

int[] array = { 1, 2, 3, 4, 5, 6,};
ZeroEvenElemnts(array);
PrintArray(array);
