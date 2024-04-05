// Cоздайте метод, котороый принимает список элементов любого типа T
// и возвращает новый список, содержащий только уникальные элементы.

static List<T> GetUniqueElemList<T>(List<T> lst)
{
    var lstOfUniqueElem = new List<T>();
    if (lst.Count == 0)
        return lst;
    foreach (var i in lst)
    {
        if(!lstOfUniqueElem.Contains(i))
            lstOfUniqueElem.Add(i);
    }

    return lstOfUniqueElem;
}

var list = new List<int> { 1, 2, 3, 15151, 22, 1, 11, 11, 11, 232, 443, 232, 1, 2, 4, 5 };
var uniqueList = GetUniqueElemList(list);

Console.Write("Уникальные элементы нашего массива: ");
foreach(var i in uniqueList)
{
    Console.Write($"{i} ");
}

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("*********************************************************************");
Console.WriteLine();


// Напишите обобщенный метод FindMax<T>, который принимает в качестве параметра массив элементов типа T
// и  возвращает максимальный элемент из массива. метод должен работать для любого типа данных

static T FindMax<T>(T[] arr)
    where T : IComparable<T>
{
    if (arr.Length == 0)
        throw new InvalidOperationException("Массив пустой");
    var maximum = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i].CompareTo(maximum) > 0)
            maximum = arr[i];
    }

    return maximum;
}

int[] firstArr = new[] { 38, 75, 898082, 0, 6869, 56474, 878650 };
double[] secondArr = new[] { 3.0, 2.1800, 8.8, 4.298, 7.98979, 1.11111};
string[] thirdArr = new[] { "Anna", "Banana", "Television", "Pitch" };
        
Console.WriteLine($"Максимальный элемент в первом массиве: {FindMax(firstArr)}");
Console.WriteLine($"Максимальный элемент во втором массиве: {FindMax(secondArr)}");
Console.WriteLine($"Максимальный элемент в третьем массиве: {FindMax(thirdArr)}");