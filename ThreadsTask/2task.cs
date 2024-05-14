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

int[,] matrix1 = GenerateRandMatr(1000, 1000);

int[,] matrix2 = GenerateRandMatr(1000, 1000);

int[,] resultThread = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
int[,] resultTask = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
int[,] resultParallel = new int[matrix1.GetLength(0), matrix2.GetLength(1)];

var threadTime = new Stopwatch();
threadTime.Start();

Console.Write("Введите количество потоков: ");
int numThreads = Convert.ToInt32(Console.ReadLine());

Thread[] threads = new Thread[numThreads];
for (int t = 0; t < numThreads; t++)
{
    int threadIndex = t;
    threads[t] = new Thread(() =>
    {
        for (int i = threadIndex; i < matrix1.GetLength(0); i += numThreads)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                int sum = 0; 
                for (int k = 0; k < matrix1.GetLength(1); k++) 
                { 
                    sum += matrix1[i, k] * matrix2[k, j];
                }
                resultThread[i, j] = sum;
            }
        }
    });
    threads[t].Start();
}

foreach (var thread in threads)
{
    thread.Join();
}

threadTime.Stop();
TimeSpan threadElapsedTime = threadTime.Elapsed;

var tasksTime = new Stopwatch();
tasksTime.Start();

Task<int>[,] tasks = new Task<int>[matrix1.GetLength(0), matrix2.GetLength(1)];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        int row = i;
        int column = j;
        tasks[row, column] = Task.Run(() =>
        {
            int sum = 0;
            for (int k = 0; k < matrix1.GetLength(1); k++)
            {
                sum += matrix1[row, k] * matrix2[k, column];
            }
            return sum;
        });
    }
}

for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        resultTask[i, j] = tasks[i, j].Result;
    }
}

tasksTime.Stop();
TimeSpan tasksElapsedTime = tasksTime.Elapsed;

var parallelTime = new Stopwatch();
parallelTime.Start();

Parallel.For(0, matrix1.GetLength(0), i =>
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        int sum = 0;
        for (int k = 0; k < matrix1.GetLength(1); k++)
        {
            sum += matrix1[i, k] * matrix2[k, j];
        }
        resultParallel[i, j] = sum;
    }
});

parallelTime.Stop();
TimeSpan parallelElapsedTime = parallelTime.Elapsed;

// Console.WriteLine("Thread result:");
// PrintMatrix(resultThread);
//
// Console.WriteLine("Task result:");
// PrintMatrix(resultTask);
//
// Console.WriteLine("Parallel result:");
// PrintMatrix(resultParallel);

Console.WriteLine("**************************************");
Console.WriteLine("Thread Time: " + threadElapsedTime);
Console.WriteLine("Tasks Time: " + tasksElapsedTime);
Console.WriteLine("Parallel Time: " + parallelElapsedTime);

static void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);

    for (int i = 0; i < rows; i++)
    { 
        for (int j = 0; j < columns; j++)
        {
            Console.Write(matrix[i, j] + "\t");
        }
        Console.WriteLine();
    }
}