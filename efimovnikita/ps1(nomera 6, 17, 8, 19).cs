// Задание 1.6
// int year = int.Parse(Console.ReadLine());
// if (((year % 4 == 0) || (year % 400 == 0)) && (year % 100 != 0))
// {
//     Console.WriteLine($"День программиста в {year} году - 12/09/{year}");
// }
// else Console.WriteLine($"День программиста в {year} году - 13/09/{year}");


// Задание 2.17
// int number1 = int.Parse(Console.ReadLine()); // число возводимое в степень
// int stepen = int.Parse(Console.ReadLine()); // степень в которую возводим
// int res = 1; // переменная в которую будем записывать результат  возведения в степень
// for (int i = 0; i < stepen; i++)
// {
//     res *= number1;
// }
// // цикл для возведения в степень, вместо функции Math.Pow
//
// string number = Convert.ToString(res); // переводим результат в string для работы с цифрами
// int lenNum = number.Length; // измеряем длину строки
// Random r = new Random();
// int[] arr = new int[lenNum]; // создаем массив чтобы записать туда все цифры полученного числа
// for (int i = 0; i < lenNum; i++)
// {
//     arr[i] = r.Next(30);
// }
// // заполняем массив для последующей замены этих элементов на цифры числа
//
// for (int i = 0; i < lenNum; i++)
// {
//     int el = Convert.ToInt32(number[i]);
//     arr[i] = el;
// }
// // Заменяем
//
// int count = 1;
// int maxLen = 0; // вводим переменную в которую будет записываться максимальная длина цепочки цифр 
// for (int i = 0; i < lenNum - 1; i++)
// {
//     if (arr[i] <= arr[i + 1])
//     {
//         count += 1;
//         if (count > maxLen) maxLen = count;
//     }
//     else count = 1;
// }
// // проверяем возрастает ли цепочка цифр и получаем максимальную длинну
//
// Console.WriteLine($"Число, полученное от возведения в данную сетпень данного числа = {res}");
// Console.WriteLine($"Длина самой длинной цепочки возрастающих цифр этого числа = {maxLen}");


// // Задание 3.8
// Console.Write("Введите количество чисел последовательности: ");
// int n = int.Parse(Console.ReadLine());
// int[] arr = new int[n];
// for (int i = 0; i < n; i++)
// {
//     arr[i] = int.Parse(Console.ReadLine());
// }
//
// bool posl = false;
// for (int i = 0; i < n - 2; i++)
// {
//     if (((arr[i] > arr[i + 1]) && (arr[i + 1] < arr[i + 2])) || ((arr[i] < arr[i + 1]) && (arr[i] > arr[i + 2])))
//     {
//         posl = true;
//     }
// }
// if(posl) Console.WriteLine("Последовательность является пилообразной");
// else Console.WriteLine("Последовательность НЕ является пилообразной");


// Задание 4.19
static bool IsPrime(int del)
{
    for (int i = 2; i <= del / 2; i++)
    {
        if (del % i == 0) return false;
    }

    return true;
}

static int[] Div(int n)
{
    List<int> div = new List<int>();
    for (int i = 2; i * i <= n; i++)
    {
        if (n % i == 0)
        {
            div.Add(i);
            if (i * i != n)
                div.Add(n / i);
        }
    }
    div.Sort();
    return div.ToArray();
}

int number = int.Parse(Console.ReadLine());
int maxDel = 0;
for (int i = 0; i < Div(number).Length; i++)
{
    if (IsPrime(Div(number)[i]))
    {
        if (Div(number)[i] > maxDel) maxDel = Div(number)[i];
    }
}
Console.WriteLine(maxDel);

