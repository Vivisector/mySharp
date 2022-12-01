// See https://aka.ms/new-console-template for more information
// тренируем создание функции

int[] arr = { 1, 24, 32, 181255, 15, 61, 71, 18, 19 };
int M = Max(Max(arr[0], arr[1], arr[2]), Max(arr[3], arr[4], arr[5]), Max(arr[6], arr[7], arr[8]));
int Max(int arg1, int arg2, int arg3){
    int result = arg1;
    int index = 0;
    if (arg2 > result) result = arg2;
    if (arg3 > result) result = arg3;
    return result;
}

Console.WriteLine("Наибольшее число оказалось: " + M);
