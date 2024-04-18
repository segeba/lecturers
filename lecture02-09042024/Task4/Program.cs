int n = 5;
int[] arr = { 125, 5, 13, 8, 27 };
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

max = arr[0];
for (int j = 1; j < n; j++)
{
    if (arr[j] > max)
    {
        max = arr[j];
    }
}
Console.Write(max);

max = arr[0];
foreach (int e in arr)
{
    if (arr[e] > max)
    {
        max = arr[e];
    }
}
Console.Write(max);