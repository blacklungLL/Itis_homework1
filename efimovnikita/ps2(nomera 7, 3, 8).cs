// Задание 1.7
static double Atan2(double x, double eps = 0.0001)
{
    double res = 0;
    int k = 0;
    var one = 1;
    var newPow = x;
    var oldRes = res + eps;
    while(oldRes - res >= eps)
    {
        oldRes = res;
        res += one / newPow / (2*k + 1);
        newPow *= x * x;
        one *= -1;
        k++;
    }
    return (Math.PI * Math.Sqrt(x*x) / (2 * x)) - res;
}

Console.WriteLine(Math.Atan(5));
Console.WriteLine(Atan2(5));



// Задание 2.3
static double Pi2(double eps)
{
    double res = 0;
    int k = 0;
    var one = 1;
    var check = Math.PI;
    var powOfThree = 1;
    while (Math.Abs(check - res) > eps)
    {
        res += Math.Sqrt(12) * one / (powOfThree * (2 * k + 1));
        one *= -1;
        powOfThree *= 3;
        k++; 
    }
    return res;
}

Console.WriteLine(Math.PI);
Console.WriteLine(Pi2(0.0001));



// Задание 4.8

static double Func(double x)
{
    return (Math.Sin(2*x)) / (Math.Cos(x) * Math.Cos(x));
}

static double LeftRectangles(double left, double right, double segCnt)
{
    double segLen = 1 / segCnt;
    double res = 0;
    for (var i = left; i < right; i += segLen)
    {
        res += Func(i);
    }
    return res * segLen;
}

static double RightRectangles(double left, double right, double segCnt)
{
    double segLen = 1 / segCnt;
    double res = 0;
    for (var i = left; i <= right - segLen; i += segLen)
    {
        res += Func(i + segLen);
    }
    return res * segLen;
}

static double Trapez(double left, double right, double segCnt)
{
    double segLen = 1 / segCnt;
    double res = 0;
    for (var i = left; i <= right - segLen; i += segLen)
    {
        res += (Func(i) + Func(i + segLen)) / 2 * segLen;
    }
    return res;
}

static double Simpson(double left, double right, double segCnt)
{
    double res = 0;
    double segLen = 0;
    if (segCnt % 2 == 1) segCnt++;
    segLen = 1 / segCnt;
    for (var i = left; i < right; i += segLen)
    {
        res += segLen / 6 * (Func(i) + 4 * Func((2 * i + segLen) / 2) + Func(i + segLen));
    }
    return res;
}

static double MonteCarlo()
{
    return 0;
}

Console.WriteLine(LeftRectangles(0, 1.5, 10000));
Console.WriteLine(RightRectangles(0, 1.5, 10000));
Console.WriteLine(Trapez(0, 1.5, 10000));
Console.WriteLine(Simpson(0, 1.5, 100000));