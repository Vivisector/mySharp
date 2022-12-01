// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
int[] arr={18,21,32,42,15,26,47,18,29};
int n = arr.Length;
int find = 48;
int index = -1;

while(index < n)
{
    if (find == arr[index]) {
        Console.WriteLine("Индекс искомогоэлемента: " + index); break;
    }
    index++;
}
