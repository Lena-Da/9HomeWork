// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1 (Рекурсия)

int m = InputInt("Задайте число m: ");
int n = 1;
Console.WriteLine(NaturalNumber(m, n));

int NaturalNumber(int m, int n)
{
if (m == n)
{
return n;
}
if (m < n)
{
Console.Write($"{NaturalNumber(m, n - 1)}, ");
}
if (m > n)
{
Console.Write($"{NaturalNumber(m, n + 1)}, ");
}

return n;
}

int InputInt(string output)
{
Console.Write(output);
return int.Parse(Console.ReadLine());
}

