// int n = 10;
int[] arr = { 1, 13, 23, 55, 77, 7, 15, 31, 5, 8 };
int i = 0;

while (i < arr.Length)
{
    if (arr[i] % 2 == 0)
    {
        Console.Write($"{arr[i]} ");
    }
    i = i + 1;
}