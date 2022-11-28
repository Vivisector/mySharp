Console.Clear(); //очистка консоли
//Console.SetCursorPosition(100,4);
//Console.WriteLine("+");
// сначала определим вершины треугольника
/*
алгоритм:
1 Определить три точки
2 Выбрать две любых
3 найти середину
4 Поставить точку
5 Выбрать случайную вершину треугольника
6 Соединить ее с полученной на 4 шаге точкой
7 Перейти к шагу 3
8. Шаги 3-7 повторить 9, 28, 31 раз

*/
int xa = 50, ya = 1, 
xb = 1, yb = 20,
xc =100, yc = 20;
Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");
Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");
Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");
