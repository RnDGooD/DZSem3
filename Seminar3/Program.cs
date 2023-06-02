// Задача №17. Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число");
// int X = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y = Convert.ToInt32(Console.ReadLine());

// if((X>0) && (Y>0))
// {
//     Console.WriteLine("1");
// }
// else if((X<0) && (Y>0))
// {
//     Console.WriteLine("2");
// }
// else if((X<0) && (Y<0))
// {
//     Console.WriteLine("3");
// }
// else 
// {
//     Console.WriteLine("4");
// }




// Напишите программу, которая по заданному номеру четверти,
//  показывает диапазон возможных координат точек в этой четверти (x и y).


// Console.WriteLine("Введите число от 1 до 4");
// int num = Convert.ToInt32(Console.ReadLine());

// if (num == 1)
// {
//     Console.WriteLine("X>0, Y>0");
// }
// else if (num == 2)
// {
//     Console.WriteLine("X<0, Y>0");
// }
// else if (num == 3)
// {
//     Console.WriteLine("X<0, Y<0");
// }
// else if (num == 4)
// {
//     Console.WriteLine("X>0, Y<0");
// }
// else
// {
//     Console.WriteLine("Ввели некорректное число");


// Задача №17. Напишите программу, которая принимает
//  на вход координаты точки (X и Y), 
// причем X ≠ 0 и Y ≠ 0 и выдаёт номер 
// четверти плоскости, в которой находится эта точка.

// Console.WriteLine("Введите число от 1 до 4");
// int num = Convert.ToInt32(Console.ReadLine());

// switch(num)
// {
//     case 1:
//     {
//         Console.WriteLine("X>0, Y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("X<0, Y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("X<0, Y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("X>0, Y<0");
//         break;
//     }
//     default:
//     {
//         Console.WriteLine("Ввели некоректное число");
//         break;
//     }

// }


// Напишите программу, которая принимает 
// на вход координаты двух точек и находит
//  расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21 

// d (X2-X1)*(X2-X1)+ (Y2-Y1)2

// Console.WriteLine("Введите число");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число");
// double X2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите число");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double d =Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2));

// Console.WriteLine(d);


// double - При использовании Math 
// Math.Sqrt - Вычисление квадратного корня
// Math.Pow - Возведение в степень



// Напишите программу, которая принимает 
// на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count=1;

// while(num>=count)
// {
//     Console.WriteLine(Math.Pow(count,2));
//     count=count+1;
// }

// ____________________________________________ДЗ__________________________________

// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

// Console.WriteLine("Введите число X1");
// int X1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y1");
// int Y1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Z1");
// int Z1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число X2" );
// double X2 = Convert.ToDouble(Console.ReadLine());

// Console.WriteLine("Введите число Z2");
// int Z2 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите число Y2");
// int Y2 = Convert.ToInt32(Console.ReadLine());

// double d =Math.Sqrt(Math.Pow((X2-X1),2)+Math.Pow((Y2-Y1),2)+Math.Pow((Z2-Z1),2));

// Console.WriteLine(d);

// _________________________________________Задача 23____________________________

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.


// Console.WriteLine("Введите число");
// int num = Convert.ToInt32(Console.ReadLine());

// int count=1;

// while(num>=count)
// {
//     Console.WriteLine(Math.Pow(count,3));
//     count=count+1;
// }


// ______________________________________Задача 19_______________________________
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// Console.WriteLine("Введите число 5-ти значное число");
// int num = Convert.ToInt32(Console.ReadLine());




