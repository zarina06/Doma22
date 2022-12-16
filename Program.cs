// Домашняя работа 2.
// Задача 1.Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
/*



Console.WriteLine("Input a num: ");
int num = Convert.ToInt32(Console.ReadLine());
num = (num/10) % 10;
Console.WriteLine(num);
*/
//Задача 2.Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*

//Найти третью цифру числа или сообщить, что ее нет 
Console.WriteLine("Введите число");
int number = 
int.Parse(Console.ReadLine());
string str = number.ToString();
int index = 0;


Console.WriteLine(str[2]);
*/

//Задача 3.Напишите программу, которая принимает на вход цифру, общначающую день недели , и проверяет , является ли этот день выходным.
/*

Console.WriteLine("Введите номер дня недели ");
int a = int.Parse(Console.ReadLine());
if (a > 5&& a <8 )
{
    Console.WriteLine("Выходной день" );
}
else if (a > 6)
{
  Console.WriteLine("Будний день" ) ;
}
if (a > 7)

{
Console.WriteLine("Ошибка");
*/


// Домашняя работа 3.
// Здадача 1.Напишите программу, которая на вход принимает пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int Ien = number . Length;

if ( Ien == 5 )

{  

      if ( number[0] == number[4] && number[1] == number[3] )

      {
          Console.WriteLine ( $" {number} - Палиндром" );
   }
   else
   {
     
     Console.WriteLine ( $" {number} - НЕ палиндром" );

   } 
 }
else
 {

    Console.WriteLine( $"ОШИБКА: {number} - не является пятизначным " );
  }

*/
// Задача 2.Напишите программу, которая принимает на вход число (N)  и выдает таблицу кубов чисел от 1 до N.
/*

int i = 1;
Console.WriteLine("Ввeдите число N");
int N = int.Parse(Console.ReadLine());
Console.WriteLine("Число" + "\t" + "Куб");
for (i=1; i<= N;i++)
{
 Console.WriteLine( i +"\t" + i* i* i );
}
*/
// Задача 3. Напишите программу, которая принимает на вход коородинаты двух точек и находит расстояние между ними в 3D пространстве.
/*


Console.WriteLine("Введите значение x1");
double x1 =
double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение  x2");
double x2 =
double.Parse(Console.ReadLine());
Console.WriteLine("Введете значение у1");
double y1 = 
double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение y2");
double y2 =
double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение z1");
double z1 =
double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение z2");
double z2 = 
double.Parse(Console.ReadLine());
double distance1 = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1,2) + Math.Pow(z2 - z1,2));
Console.WriteLine("Расстояние между точками в пространстве 3D:" + distance1);
*/





































