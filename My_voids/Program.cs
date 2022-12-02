// See https://aka.ms/new-console-template for more information
// 1. Создаем пустой массив на 10 ячеек
int[] arr = new int[1000]; // создали
// теперь метод для заполнения
void Fillarr(int[] collection)
{
    int len = collection.Length;
    int count = 0;
    while(count < len){
        collection[count] = new Random().Next(1,20);
        count++;
    }
}

// считаем сумму всех элементов и тоже выводим на экран
int Summa(int[] arg){
    int length = arg.Length;
    int cnt = 0;
    int result = 0;
    while(cnt<length){
        result = result + arg[cnt];
        cnt++;
    }
    return result;
}

void Printarr(int[] collect){
int pos = 0;
int l = collect.Length;
    while(pos<l){
        Console.Write(collect[pos] + "+");
        pos++;
    }
}
// теперь вызываем эти методы
Fillarr(arr);
Printarr(arr);
Console.WriteLine(""); //новая строка
Console.WriteLine("Итого набралось: " + Summa(arr));

// хорошо бы написать прогу, чтобы цифрами нарисовался бы портрет Ленина (напр.)
// надо по исходной картинке темноту пикселя сопоставить цифрам
