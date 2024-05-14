// Умножение матрицы на вектор

using System.Diagnostics;

static int[,] GenerateRandMatr(int rows, int columns)
{
    var matrix = new int[rows, columns];
    var r = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = r.Next();
        }
    }

    return matrix;
}

static int[] GenerateRandVector(int size)
{
    var vector = new int[size];
    var r = new Random();
    for (int i = 0; i < size; i++)
    {
        vector[i] = r.Next();
    }

    return vector;
}

int[,] matrix = GenerateRandMatr(1000,1000);

int[] vector = GenerateRandVector(1000);

Console.Write("Введите количество потоков: ");
int numOfThreads = Convert.ToInt32(Console.ReadLine());

var resThread = new int[matrix.GetLength(0)];
var resTask = new int[matrix.GetLength(0)];
var resParallel = new int[matrix.GetLength(0)];

var threadTime = new Stopwatch(); 
threadTime.Start();

Thread[] threads = new Thread[numOfThreads];
for (int i = 0; i < threads.Length; i++)
{
    var startId = i * (matrix.GetLength(0) / threads.Length);
    var endId = (i == threads.Length - 1
        ? matrix.GetLength(0)
        : (i + 1) * (matrix.GetLength(0) / threads.Length));
    threads[i] = new Thread(() =>
    {
        for (int j = startId; j < endId; j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[j, k] * vector[k];
            }

            resThread[j] = sum;
        }
    });
    threads[i].Start();
}

foreach (var i in threads)
{
    i.Join();
}

threadTime.Stop();
var threadsElapsedTime = threadTime.Elapsed;

//**************************************************************************************

var tasksTime = new Stopwatch();
tasksTime.Start();

var tasks = new Task[numOfThreads];
for (int i = 0; i < tasks.Length; i++)
{
    var startId = i * (matrix.GetLength(0) / tasks.Length);
    var endId = (i == tasks.Length - 1
        ? matrix.GetLength(0)
        : (i + 1) * (matrix.GetLength(0) / tasks.Length));
    tasks[i] = Task.Run(() =>
    {
        for (int j = startId; j < endId; j++)
        {
            int sum = 0;
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum += matrix[j, k] * vector[k];
            }

            resTask[j] = sum;
        }
    });
}

Task.WaitAll(tasks);

tasksTime.Stop();
var tasksElapsedTime = tasksTime.Elapsed;

//******************************************************************************* 

var parallelTime = new Stopwatch();
parallelTime.Start();

Parallel.For(0, matrix.GetLength(0), i =>
{
    var sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
        sum += matrix[i, j] * vector[j];
    resParallel[i] = sum;
});

parallelTime.Stop();
TimeSpan parallelElapsedTime = parallelTime.Elapsed;

//****************************************************************************************

Console.WriteLine("*********************************************");

Console.WriteLine($"Tread Time: {threadsElapsedTime}");
Console.WriteLine($"Tasks Time: {tasksElapsedTime}");
Console.WriteLine($"Parallel Time: {parallelElapsedTime}");
