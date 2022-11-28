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

int x= xa, y = xb;
int cnt = 0;
while(cnt < 5000){
int what = new Random().Next(0,3); // задали полуинтервал [0,3) -> 0 1 2 (не 3)
if (what==0){
    x = (x+xa)/2;
    y = (y+ya)/2;
}
if (what==1){
    x = (x+xb)/2;
    y = (y+yb)/2;
}
if (what==0){
    x = (x+xc)/2;
    y = (y+yc)/2;
}
Console.SetCursorPosition(x, y);
Console.WriteLine("+");
cnt++;
}