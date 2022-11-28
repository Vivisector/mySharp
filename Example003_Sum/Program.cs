/*
БЛОК_СХЕМА:
НАЧАЛО-опрть numA-опрть NumB-вывод NumA+NumB-КОНЕЦ
*/
//int NumA = 3;
int NumA = new Random().Next(1,10); // берем сл. число 0,1,2,3,...,9
Console.WriteLine("A = " + NumA);
//break();
int NumB = new Random().Next(1,10);
Console.WriteLine("B = " + NumB);
int res = NumA + NumB; // промежуточная
Console.WriteLine("A + B = " + res);
