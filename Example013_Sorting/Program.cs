// сортируем массив
/*
1. Найти в неотсортированной части минимальный элемент
2. Обменять его с первой позицией несортированной части
3. Повторять, пока остается несортированная часть
*/

int[] arr = { 1, 5, 4, 2, 3, 5, 7, 1, 1 };

// метод вывода на экран
void PrintArray(int[] arr)
{
    int cnt = arr.Length;
    for (int i = 0; i < cnt; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
// метод упорядочивания по возрастанию
void SortingUp(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < arr.Length; j++){
            if (arr[j] < arr[minPosition]) minPosition = j;
        }

        int temp = arr[i];
        arr[i] = arr[minPosition];
        arr[minPosition] = temp;
    }
}

// метод упорядочивания по убыванию
void SortingDown(int[] arr)
{
    for (int i = 0; i < arr.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < arr.Length; j++){
            if (arr[j] > arr[maxPosition]) maxPosition = j;
        }

        int temp = arr[i];
        arr[i] = arr[maxPosition];
        arr[maxPosition] = temp;
    }
}
Console.WriteLine("\nИсходный массив:");
PrintArray(arr);
SortingUp(arr);
Console.WriteLine("\nПо возрастанию:");
PrintArray(arr);
SortingDown(arr);
Console.WriteLine("\nПо убыанию:");
PrintArray(arr);