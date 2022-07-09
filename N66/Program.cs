// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.


int m = InputInt("Задайте число m: ");
int n = InputInt("Задайте число n: ");
int temp = m;
Summa(m, n, temp=0);


if (m > n) 
{
  m = n; 
  n = temp;
}



void Summa(int m, int n, int sum)
{
  sum = sum + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов от m до n : {sum} ");
    return;
  }
  Summa(m, n - 1, sum);
}

int InputInt(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}