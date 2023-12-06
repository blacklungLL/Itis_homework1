using System.Text;

namespace controlWork;
// Вариант первый.

internal class Matrix
{
    private int rows;
    private int columns;
    private int[,] matr;

    public Matrix(string filename) // Считывание матрицы из файла
    {
        var file = new StreamReader(filename);
        var text = file.ReadLine().Split(' ');
        rows = Convert.ToInt32(text[0]);
        columns = Convert.ToInt32(text[1]);
        matr = new int[rows, columns];
        var matrText = file.ReadToEnd().Split('\n');
        for (int i = 0; i < rows; i++)
        {
            var line = matrText[i].Split(' ');
            for (int j = 0; j < columns; j++)
            {
                matr[i, j] = Convert.ToInt32(line[j]);
            }
        }
    }
    
    // Первый номер первого варианта
    public void Change(int x, int y)
    {
        for (int i = 0; i < columns; i++)
        {
            (matr[x, i], matr[y, i]) = (matr[y, i], matr[x, i]);
        }
    }

    public void ChangeCol()
    {
        var max = int.MinValue;
        var min = int.MaxValue;
        for (int i = 0; i < rows; i++)
        {
            var sumInCol = 0;
            for (int j = 0; j < columns; j++)
            {
                sumInCol += matr[i, j];
            }

            if (sumInCol > max)
                max = i;
            if (sumInCol < min)
                min = i;
        }
        Change(max, min);
    }
    
    public override string ToString() // Вывод
    {
        var stringBuilder = new StringBuilder();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
                stringBuilder.Append($"{matr[i, j],2}");
            stringBuilder.AppendLine();
        }
        return stringBuilder.ToString();
    }
}