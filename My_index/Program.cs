int[] arr = { 18, 21, 32, 42, 15, 26, 47, 18, 29 };
int find = 20;

// int Max(int arg1, int arg2, int arg3)

int mFind(int[] arr, int find) // определили функцию
{
    int index = 0;
    int n = arr.Length;
    int position = -1;
    while (index < n)
    {
        if (arr[index] == find)
        {
            position = index;

        }
        index++;
    }
    return position;

}

if (mFind(arr, find) == -1)
{
    Console.WriteLine("Элемент " + Convert.ToString(find) + " не входит в представленный список");
}
else
{
    Console.WriteLine("Элемент " + Convert.ToString(find) + " находится на " + (mFind(arr, find) + 1) + " месте представленного списка");
}

// Console.WriteLine("Hello, World!");
