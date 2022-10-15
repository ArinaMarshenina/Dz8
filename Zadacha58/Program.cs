// Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.


void Matrices(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum += firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int InputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

int range = InputNumbers("Введите диапазон чисел: от 1 до ");

void CreateArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(range);
    }
  }
}

void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}

int m = InputNumbers("Введите число строк первой матрицы: ");
int n = InputNumbers("Введите число столбцов первой матрицы и строк 2 матрицы: ");
int p = InputNumbers("Введите число столбцов второй матрицы: ");


int[,] firstMartrix = new int[m, n];
CreateArray(firstMartrix);
Console.WriteLine($"Первая матрица:");
WriteArray(firstMartrix);

int[,] secondMartrix = new int[n, p];
CreateArray(secondMartrix);
Console.WriteLine($"Вторая матрица:");
WriteArray(secondMartrix);

int[,] resultMatrix = new int[m,p];

Matrices(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Результирующая матрица :");
WriteArray(resultMatrix);