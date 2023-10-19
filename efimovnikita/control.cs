// Второй вариант
// Задание 1
// Проверить симметричен ли массив
// Console.Write("Введите длину массива: ");
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
//
// bool examination = true;
// for (int i = 1; i < n / 2; i++)
// {
//     if (arr[i-1] != arr[n - i]) examination = false;
// }
// if(examination) Console.WriteLine("Массив симметричен");
// else Console.WriteLine("Массив несимметричен");




// Задание 2
// Подсчитать количество неубывающих цепочек в массиве
// static int CountChain(int[] arr)
// {
//     int count = 1, count_chain = 0;
//     for (int i = 1; i < arr.Length; i++)
//     {
//         if (arr[i - 1] <= arr[i]) count += 1;
//         else if (count > 1)
//         {
//             count_chain += 1;
//             count = 1;
//         }
//         else count_chain++;
//     }
//     if (count > 1) count_chain += 1;
//     return count_chain;
// }
//
//
// Console.Write("Введите длину массива: ");
// int lenArr = int.Parse(Console.ReadLine());
// int[] array = new int[lenArr];
// for (int i = 0; i < lenArr; i++)
// {
//     array[i] = int.Parse(Console.ReadLine());
// }
//
// Console.WriteLine($"Количество неубывающих цепочек в массиве = {CountChain(array)}");



// Задание 3
// поменять местами максимальный и минимальный элементы матрицы
int n = int.Parse(Console.ReadLine());
int m = int.Parse(Console.ReadLine());
int[,] matrics = new int[n, m];
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        matrics[i, j] = int.Parse(Console.ReadLine());
    }
}

int maxi = 0;
int mini = 1000000;
int indexMaxI = 0;
int indexMaxJ = 0;
int indexMinI = 0;
int indexMinJ = 0;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (matrics[i, j] > maxi)
        {
            maxi = matrics[i, j];
            indexMaxI = i;
            indexMaxJ = j;
        }
    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if (matrics[i, j] < mini)
        {
            mini = matrics[i, j];
            indexMinI = i;
            indexMinJ = j;

        }
    }
}

matrics[indexMaxI, indexMaxJ] = mini;
matrics[indexMinI, indexMinJ] = maxi;
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write($"{matrics[i, j], 2} ");
    }
    Console.WriteLine();
}

