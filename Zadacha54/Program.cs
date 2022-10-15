// Задайте двумерный массив. 
// Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.


void OrderArrayLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(1) - 1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
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

void WriteArray(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
  }
}


int m = InputNumbers("Введите размерность массива m: ");
int n = InputNumbers("Введите размерность массива n: ");

int[,] array = new int[m, n];
CreateArray(array);
WriteArray(array);

Console.WriteLine("Элементы по убыванию в каждой строке массива: ");
OrderArrayLines(array);
WriteArray(array);