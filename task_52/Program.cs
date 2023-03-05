//Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
int[,] GetMatrix(int rows, int cols, int minValue, int maxValue)
{
  int[,] matrix = new int[rows, cols];
  for (int i = 0; i < rows; i++)
    {
      for (int j = 0; j < cols; j++)
      {
        matrix[i, j] = new Random().Next(minValue, maxValue + 1);
      }
    }
  return matrix;
}

void PrintMatrix(int[,] matr)
{
  for (int i = 0; i < matr.GetLength(0); i++)
    {
      for (int m = 0; m < matr.GetLength(1); m++)
        {
          Console.Write(matr[i, m] + "\t");
        }
          Console.WriteLine();
    }
}

int i_len = 5;
int i_size = 5;

int[,] resultMatrix = GetMatrix(i_len,i_size,0,10);
PrintMatrix(resultMatrix);

for(int m = 0; m < resultMatrix.GetLength(1); m++)
{
  double rowSum = 0;
    for(int i = 0; i < resultMatrix.GetLength(0); i++)
    {
      rowSum += resultMatrix[i,m];
    }
Console.WriteLine("Среднее арифметическое = " + rowSum / (resultMatrix.GetLength(1)));
}