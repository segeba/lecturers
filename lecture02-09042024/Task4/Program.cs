int n = 5;
int[] arr = { 1, 5, 13, 8, 27 };
int i = 0;
int max = arr[i];

while (i < n)
{
    if (arr[i] > max)
    {
        max = arr[i];
    }
    i = i + 1;
}

Console.WriteLine(max);