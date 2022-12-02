// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

void FillArray(int[] collection)
{ // примечание: void-метод - метод, который не возвращает значений, а работает только как процедура
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col)
{
    int cnt = col.Length;
    int position = 0; //замена названия индекса [чтобы не повторяться]
    while (position < cnt)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int[] arr = new int[20]; // "создай новый массив из 10 элементов (по умолчанию все элементы пустые)"
// int a = Random(1,10);
// COnsole.WriteLine(a);
FillArray(arr);
PrintArray(arr);
// int a = new Random().Next(1, 25);
// Console.WriteLine(a);