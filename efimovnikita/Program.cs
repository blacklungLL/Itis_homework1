//int n = int.Parse(Console.ReadLine());
//int k = 0;
//while(Math.Pow(3, k) < n)
//{
//    k++;
//}
//if (Math.Pow(3, k) == n)
//{
//    Console.WriteLine($"YES, stepen = {k}");
//}
//else
//{
//    Console.WriteLine("NO");
//} 
// это домашка на среду 20.09.23(является ли число степенью тройки)



//int k = int.Parse(Console.ReadLine());
//int f = 1;
//int s = 0;
//for(int n = 1; n < k + 1; n++)
//{
//    f = f * n;
//    s = s + f;
//}
//Console.WriteLine(s);
// прога для нахождения суммы факториалов



//double x = double.Parse(Console.ReadLine());
//double s = 0;
//double m = 1;
//double l = 1;

//for (int k = 1; k < 10; k++)
//{
//    s = s + (m / l);
//    m = m * x;
//    l = l * k;
//}
//Console.WriteLine(s);
//Console.WriteLine(Math.Exp(x));



//int k = int.Parse(Console.ReadLine());
//int cnt = 0;
//for (int a = 1; a < 10; a++)
//{
//    for (int b = 0; b < 10; b++)
//    {
//        for(int c = 0; c < 10; c++)
//        {
//            if (a+b+c == k)
//            {
//                cnt++;
//            }
//        }
//    }
//}
//Console.WriteLine(cnt);

//int cnt = 0;
//int cnt1 = 0;
//int cnt2 = 0;
//for (int a = 0; a < 10; a++)
//{
//    for (int b = 0; b < 10; b++)
//    {
//        for (int c = 0; c < 10; c++)
//        {
//            for (int d = 0; d < 10; d++)
//            {
//                for (int e = 0; e < 10; e++)
//                {
//                    for (int f = 0; f < 10; f++)
//                    {
//                        if((a + b + c) == (d + e + f))
//                        {
//                            cnt++;
//                        }
//                        if ((a + c + e) == (b + d + f))
//                        {
//                            cnt1++;
//                        }
//                        if (((a+b+c) == (d+e+f)) && ((a+c+e) == (b + d + f)))
//                        {
//                            cnt2++;
//                        }
//                    }
//                }
//            }
//        }
//    }
//}
//Console.WriteLine(cnt);
//Console.WriteLine(cnt1);
//Console.WriteLine(cnt2);



// double x = double.Parse(Console.ReadLine());
// double y = double.Parse(Console.ReadLine());
// if(((x >= 0 && x <= 1) && (y <= 0 && y <= (-1 * x))) || (x <= 0 && x >= -1 && y >= 0 && y >= (-1 * x)))
// {
//     Console.WriteLine("Входит");
// }
// else
// {
//     if (x >= -1 && x <= 0 && y <= 0 && y >= x)
//     {
//         Console.WriteLine("Входит");
//     }
//     else
//     {
//         Console.WriteLine("Не Входит");
//     }
// }
// это прога с первой пятиминутки с треугольниками
//
// long f, f1, f2;
// f = f1 = f2 = 1;
// int k = int.Parse(Console.ReadLine());
// for (int i = 2; i < k; i++)
// {
//     f = f1 + f2;
//     f2 = f1;
//     f1 = f;
// }
// Console.WriteLine(f);
// последовательность Фибаначи

// double y0, y = 0, eps = 0.0000000001;
// double x = double.Parse(Console.ReadLine());
// if (x > 1)
// {
//     y = x / 3;
// }
// else
// {
//     y = x;
// }
//
// int k = 0;
// do
// {
//     y0 = y;
//     y = y0 - (y0 - x / (y0 * y0)) / 3;
//     k++;
//
// } while (Math.Abs(y0 - y) > eps);
// Console.WriteLine(y);
// Console.WriteLine($"k = {k}");


// Random r = new Random();
// int n = 10;
// int[] arr = new int[n];
//
// arr[5] = 67;
//
// for (int i = 0; i < n; i++)
// {
// //    arr[i] = int.Parse(Console.ReadLine());
//       arr[i] = r.Next(-100, 100);
//       Console.WriteLine($"arr[{i}] = {arr[i]}");
// }

// Random r = new Random();
// int n = 100;
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = r.Next(-50, 50);
//         Console.WriteLine($"arr[{i}] = {arr[i]}");
// }
//
// int first_max = 0;
// int last_max = 0;
// int max = int.MinValue;
// for (int i = 0; i < n; i++)
// {
//     if (arr[i] > max)
//     {
//         first_max = i;
//         max = arr[i];
//         last_max = 0;
//     }
// }
//
// int count = 0;
// for (int i = 0; i < n; i++)
// {
//     if (arr[i] == max)
//     {
//         count += 1;
//         Console.WriteLine($"номер максимального числа = {i}");
//     }
//
//     if (arr[i] == max)
//     {
//         last_max = i;
//     }
// }
// Console.WriteLine(count);
// Console.WriteLine(max);
// Console.WriteLine(first_max);
// Console.WriteLine(last_max);
// Это классная работа выше



// тут домашняя работа на 4.10.23
// int[] arr = new[] {1, 2, 3, 4, 5, 5};
// int lenAr = arr.Length; // длина массива
// int cntNotrep = 0; // счетчик различных чисел
// bool exist = false; 
// for (int i = 0; i < lenAr; i++)
// {
//     Console.WriteLine($"arr[{i}] = {arr[i]}");
//     // вывод элементов массива
//     for (int j = 0; j < lenAr; j++)
//     {
//         if ((arr[i] == arr[j] && i != j)) break;
//         // если есть повторение то счетчик ломается 
//
//         else
//         {
//             if (j == lenAr - 1) cntNotrep++;
//         }
//         // если нет, то счетчик пробегается до конца массива и увеличивается на 1
//     }
// }
//
// int cntRep = lenAr - cntNotrep; // количество повторяющихся чисел
// for (int i = 0; i < lenAr; i++)
// {
//     for (int j = 0; j < lenAr; j++)
//     {
//         if ((arr[i] == arr[j]) && (i != j)) exist = true;
//         // проверка: есть ли одинаковые числа
//     }
// }
//
// if (exist) Console.WriteLine("Одинаковые числа есть в массиве");
// // работает правильно
// else Console.WriteLine("Нет одинаковых числе в массиве");
// // работает правильно
//
// Console.WriteLine($"количество повторяющихся чисел = {cntRep}");
// // работает правильно
// Console.WriteLine($"Количество непотвторяющихся(уникальных) чисел = {cntNotrep}"); 
// считает количество только тех чисел у которых вообще нет повторений



// Классная работа
// int[] arr = {5, 4, 3, 2, 1, 1, 1};
// int lenAr = arr.Length;
// bool vozrast = false;
// bool ubyv = false;
// for (int i = 0; i < lenAr - 1; i++)
// {
//     if (arr[i] > arr[i+1]) 
//     { 
//         ubyv = true;
//     }
//     if (arr[i] < arr[i+1]) 
//     { 
//         vozrast = true;
//     }
// }
// Console.WriteLine($"{vozrast} - возрастают");
// Console.WriteLine($"{ubyv} - убывают");

// Домашшнаяя работа
// Считаем количество элементов которые больше своих соседей
// int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
// int count = 0;
// int lenAr = arr.Length;
// for (int i = 1; i < lenAr-1; i++)
// {
//     if (arr[0] > arr[1]) count++;
//     if ((arr[i] > arr[i + 1]) && (arr[i] > arr[i - 1])) count++;
// }
//
// Console.WriteLine($"количество элементов, которые больше своих соседей = {count}");
//
// // Инвертация массива
// int invEl = 0;
// for (int i = 0; i < lenAr / 2; i++)
// {
//     invEl = arr[i]; // перекидываем значения элементов с начала массива в новую переменную
//     arr[i] = arr[lenAr - i - 1]; // меняем элементы массива местами(первый с последним и тд)
//     arr[lenAr - i - 1] = invEl; // присваиваем инвертируемому элементу значение последнего и тд элемента
// }
//
// for (int i = 0; i < lenAr; i++) Console.WriteLine(arr[i]);



// Матрицы, классная работа
// int n = 5, m = 10;
// int[,] matr = new int[n,m];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < m; j++)
//         Console.Write($"{matr[i, j]} ");
//     Console.WriteLine();
// }

// Задание 1
// int e = 5;
// int[,] matr = new int[e, e];
// for (int i = 0; i < e; i++)
// {
//     for (int j = 0; j < e; j++)
//     {
//         matr[i, j] = i == j ? 1 : 0; // то же самое что if(i == j) matr[i, j] = 1 else 0
//         Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задание 2
// int n = 5;
// int[,] matr = new int[n,n];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matr[i, j] = i == j ? 1 : 0;
//         if (i > j)
//         {
//             matr[i, j] = 0;
//         }
//
//         if (j > i)
//         {
//             matr[i, j] = j + 1 - i;
//             
//         }
//         Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
// }


// Задание 3
// int n = 11;
// int[,] matr = new int[n, n];
// for (int i = 1; i < n; i++)
// {
//     for (int j = 1; j < n; j++)
//     {
//         if (i == j) matr[i, j] = i;
//         if (j > i) matr[i, j] = 0;
//         if (i > j) matr[i, j] = j;
//         Console.Write($"{matr[i, j]} ");
//     }
//     Console.WriteLine();
// }

// Задание 4
// int n = 10;
// int[,] matr = new int[n, n];
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matr[i, j] = n - j - i;
//         Console.Write($"{matr[i, j], 2} ");
//     }
//     Console.WriteLine();
// }

//Домашняя работа, Задание 5 сумма крайних элементов матрицы
// int n = 5;
// int summa = 0;
// int[,] matr = new int[n, n];
// Random r = new Random();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matr[i, j] = r.Next(2);
//     }
// }
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i == 0) summa += matr[i, j]; // первая строка
//         if (j == (n - 1) && i != 0) summa += matr[i, j]; // последний столбец
//         if (i == (n - 1) && j != (n-1)) summa += matr[i, j]; // последняя строка
//         if (j == 0 && i != 0 && i != (n-1)) summa += matr[i, j]; // первый столбец
//         Console.Write($"{matr[i,j], 2} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Сумма крайних элементов = {summa}");


// Задание 6 сумма элементов диагоналей матрицы
// int n = 5;
// int[,] matr = new int[n, n];
// int summa = 0;
// Random r = new Random();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matr[i, j] = r.Next(2);
//     }
// }
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         if (i == j) summa += matr[i, j];
//         if (j == n - i - 1 && i != j) summa += matr[i, j];
//         Console.Write($"{matr[i,j], 2} ");
//     }
//     Console.WriteLine();
// }
// Console.WriteLine($"Сумма элементов диагоналей матрицы  = {summa}");


// Задание 7, 
// int n = 5;
// int[,] matr = new int[n, n];
// int summa = 0;
// Random r = new Random();
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         matr[i, j] = r.Next(2);
//     }
// }
//
// for (int i = 0; i < n; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         
//     }
// }