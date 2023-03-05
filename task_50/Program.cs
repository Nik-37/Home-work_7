//Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

double[,] GetMatrix(int rows, int cols)
{
  double[,] matrix = new double[rows, cols];
  for (int i = 0; i < rows; i++)
  {
    for (int j = 0; j < cols; j++)
    {
    matrix[i, j] = new Random().NextDouble();
    }
  }
  return matrix;
}

void PrintMatrix(double[,] matr)
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

double[,] resultMatrix = GetMatrix(i_len,i_size);
PrintMatrix(resultMatrix);

int rows;
int cols;
string rows_l;
string cols_l;

Console.WriteLine("Введите номер строки"   );
rows_l = Console.ReadLine();
rows = Convert.ToInt32(rows_l);

Console.WriteLine("Введите номер столбца"   );
cols_l = Console.ReadLine();
cols = Convert.ToInt32(cols_l);

double result;

if(rows >= i_len || cols >= i_size)
{
  Console.WriteLine("ТАКОГО ЭЛЕМЕНТА НЕТ");
}
else
{
  result = resultMatrix[rows, cols];
  Console.WriteLine("ЗНАЧЕНИЕ ЭЛЕМЕНТА = " + result);
}
