
//DONE//Напишите программу, показывает, является ли 5ти значное число палиндромом.
// Console.WriteLine("Введите пятизначное число");
// int x=Convert.ToInt32(Console.ReadLine());
// int i1 = x/10000;
// int i2 = (x%10000)/1000;
// int i4 = (x%100)/10;
// int i5 = x%10;
// double y = x/10000;
// if (i1 == i5 && i2 == i4) Console.WriteLine("Число палиндром");
// else if (y<=0) Console.WriteLine ("Число имеет разрядность меньше 5");
// else if (y>= 10) Console.WriteLine ("Число имеет разрядность выше 5");
// else Console.WriteLine ($"Число не палиндром");

// DONE// Забрать от пользователя координаты двух точек и найти расстояние между ними в 3х мерном пространстве

// Console.WriteLine ("Введите значение первой точки по оси x");
// int x1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение первой точки по оси y");
// int y1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение второй точки по оси z");
// int z1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение второй точки по оси x");
// int x2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение второй точки по оси y");
// int y2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите значение второй точки по оси z");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double i = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
// Console.WriteLine (i);

// DONE// Получаем N, выдаем кубы чисел до N (Включая N)

// Console.WriteLine ("Введите число");
// int x = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i<=x; i++)
// Console.Write (i*i*i+" ");

// Сначала задается N с клавиатуры, потом задаются координаты точек. N = размерность пространства

// Console.WriteLine ("Введите размерность пространства (не более 5)");
// int m = Convert.ToInt32(Console.ReadLine());
// if (m == 1)
// {
//     Console.WriteLine ("Введите значение первой точки по оси x");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси x");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     double i = Math.Sqrt(Math.Pow(x2-x1, 2));
//     Console.WriteLine (i);
// }
// else if (m == 2)
// {
//     Console.WriteLine ("Введите значение первой точки по оси x");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси y");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси x");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси y");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     double i = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2));
//     Console.WriteLine (i);
// }
// else if (m == 3)
// {
//     Console.WriteLine ("Введите значение первой точки по оси x");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси y");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси z");
//     int z1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси x");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси y");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси z");
//     int z2 = Convert.ToInt32(Console.ReadLine());
//     double i = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2));
//     Console.WriteLine (i);
// }
// else if (m == 4)
// {
//     Console.WriteLine ("Введите значение первой точки по оси x");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси y");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси z");
//     int z1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси k");
//     int k1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси x");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси y");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси z");
//     int z2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси k");
//     int k2 = Convert.ToInt32(Console.ReadLine());
//     double i = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)+Math.Pow(k2-k1, 2));
//     Console.WriteLine (i);
// }
// else if (m == 5)
// {
//     Console.WriteLine ("Введите значение первой точки по оси x");
//     int x1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси y");
//     int y1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси z");
//     int z1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси k");
//     int k1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение первой точки по оси l");
//     int l1 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси x");
//     int x2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси y");
//     int y2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси z");
//     int z2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси k");
//     int k2 = Convert.ToInt32(Console.ReadLine());
//     Console.WriteLine ("Введите значение второй точки по оси l");
//     int l2 = Convert.ToInt32(Console.ReadLine());
//     double i = Math.Sqrt(Math.Pow(x2-x1, 2)+Math.Pow(y2-y1, 2)+Math.Pow(z2-z1, 2)+Math.Pow(k2-k1, 2)+Math.Pow(l2-l1, 2));
//     Console.WriteLine (i);
// }
// else if (m>5) Console.WriteLine ("Выше 5-мерного простанства уже перебор... Вернитесь в реальность пожалуйста:3");
// else if (m<=0) Console.WriteLine ("Введены некорректные данные");


// Console.WriteLine ("Введите размерность пространства (не более 5)");
// int m = Convert.ToInt32(Console.ReadLine());


// на вход целое число любой разрядности и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите число до 1M");
int x=Convert.ToInt32(Console.ReadLine());
if (x/10<=0) Console.WriteLine ("Вы ввели однозначное число");
else if (x/10<10 && x/10>0) 
{
    Console.WriteLine ("Вы ввели двузначное число");
        if (x/10 == x%10) Console.WriteLine ("Вы ввели число палиндром");
    else Console.WriteLine ("Вы ввели число не палиндром");
}
else if (x/100<10 && x/100>0) 
{
    Console.WriteLine ("Вы ввели трехзначное число");
        if (x/100 == x%10) Console.WriteLine ("Вы ввели число палиндром");
    else Console.WriteLine ("Вы ввели число не палиндром");
}
else if (x/1000<10 && x/1000>0) 
{
    Console.WriteLine ("Вы ввели четырехзначное число");
        if (x/1000 == x%10 && (x%1000)/100 == (x%100)/10 ) Console.WriteLine ("Вы ввели число палиндром");
    else Console.WriteLine ("Вы ввели число не палиндром");
}
else if (x/10000<10 && x/10000>0) 
{
    Console.WriteLine ("Вы ввели пятизначное число");
        if (x/10000 == x%10 && (x%10000)/1000 == (x%100)/10 ) Console.WriteLine ("Вы ввели число палиндром");
    else Console.WriteLine ("Вы ввели число не палиндром");
}
else if (x/100000<10 && x/100000>0) 
{
    Console.WriteLine ("Вы ввели шестизначначное число"); 
        if (x/100000 == x%10 && (x%100000)/10000 == (x%100)/10 &&  (x%10000)/1000 == (x%1000)/100 ) Console.WriteLine ("Вы ввели число палиндром");
    else Console.WriteLine ("Вы ввели число не палиндром");
}
else Console.WriteLine ("Вы вышли за условия задачи");