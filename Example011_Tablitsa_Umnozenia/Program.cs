// моделируем таблицу умножения, используя цикл в цикле
// int[] a = {0,1,2,3,4,5,6,7,8,9};
for (int i=1;i<10;i++){
    for (int k = 1; k<=10; k++){
        Console.WriteLine($"{i} x {k} = {i*k}");
    }
Console.WriteLine();
}

