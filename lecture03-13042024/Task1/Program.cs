double CalculateFormula(int a, int b, int c, int d)
{
    double numenator = a * b;
    int denumenator = c + d;
    double result = numenator / denumenator;
    return result;
}

System.Console.WriteLine(CalculateFormula(1, 2, 3, 4));
