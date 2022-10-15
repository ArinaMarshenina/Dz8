// Напишите программу, которая заполнит спирально массив 4 на 4.

int n = 4;
int m = 4;
int[,] doubleArray = new int[n, m];

int temp = 1;
int i = 0;
int j = 0;

while (temp <= doubleArray.GetLength(0) * doubleArray.GetLength(1))
{
  doubleArray[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < doubleArray.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= doubleArray.GetLength(1) - 1)
    i++;
  else if (i >= j && i + j > doubleArray.GetLength(1) - 1)
    j--;
  else
    i--;
}

WriteArray(doubleArray);

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(1); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      if (array[i,j] / 10 <= 0)
      Console.Write($" {array[i, j]} ");

      else Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
  }
}