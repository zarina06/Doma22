﻿// Домашняя работа 2.
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

// Домашняя работа 4.
// Задача 1. Напишите программу, которая  принимает на вход число и выдает сумму цифр в числе.
/*

Console.WriteLine("Вкдите число:");
int n  = int.Parse(Console.ReadLine());
int i = 0;
int sum = 0;
for (i = 0; n >=1; i++)
 {
    sum += n % 10;
    n = n / 10;

 }
 Console.WriteLine("Суммф цифр в числе ровна" + sum);
 */
 // Задача 2. Напишите программу, которая задает массив из 8 элементов и выводит их на экран.
 /*

 int[] array = {1,2,3,4,5,6,7,8};
 for (int i = 0; i < array.Length; i++)
 {
   // Console.WriteLine((array[i]));
    Console.WriteLine((   array[i] + " " ));
 }
*/
// Задача 3. Напишите цикл, который принимает на вход два числа ( A и B) и возводит числа A  в натуральную степень B.
/*
Console.WriteLine("Введите число A");
int A = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число B");
int B = int.Parse(Console.ReadLine());

int S = 1;
for (int i = 1; i <=B; i++)
{
    S*=A;
}
Console.WriteLine(S);
*/

// Домашняя работа 5.

// Задача 1. Задайте массив вещественных чисел, найдите разницу между максимальным и минимальным элементов массива.
/*
 
 int[] array = { 2,3,4,5,6,7,8,9,10,20};
 int max = array[0];
 int min = array [0];

 for (int j = 0; j < array.Length;j++)
{
    if (array[j] > max ) max = array[j];
    if (array[j] < min ) min = array[j];
}
Console.WriteLine();
Console.Write("Разницу между максимальным и минимальным элементом равна - " );
Console.Write( max - min);
*/
// Задача 2. Задайте одномерный массив, заполненные случайными числами , найдите сумму элементов , стоящих на нечетных позициях.
/*


int[] array = new int[30];
int count  = 0;

for (int i = 0;  i < array.Length; i++)
{
    array[i] = new Random().Next(0, 100);
    Console.WriteLine(array[i] +" ");
}
for(int j = 0; j < array.Length; j++);
{

}
Console.WriteLine();
Console.Write("Сумма чисел стоящих на нечетной позиции в массиве равна -");
Console.Write(count); 
*/

    
// Задача 3. Задайте массив заполненный случайными положительными трехзначными числами. Напишите программу, которое покажет количество четных чисел в массиве.
/*

int[] array = new int [12];
int countEven = 0;
for(int i = 0; i< array.Length; i++)
{
    array[i]=new Random().Next(100,999);
    Console.WriteLine(array[i] +" ");
}
Console.WriteLine();
for (int j = 0; j < array.Length; j++)
{
   if (array[j] %2 ==0) countEven = countEven +1;
}
Console.Write("Четные числа из массива:" + countEven);
*/
// Домашняя работа 6.

// Задача 1. Напишите программу, которая найдет точку пересечения двух прямых, заданных уравнениями y = k1* x +b1, y =k2* x+b2
/*

Console.WriteLine("Введите значение k1");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение k2");
double k2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b1");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите значение b2");
double b2 = double.Parse(Console.ReadLine());

if(k1==k2 && b1!=b2)
{
  Console.WriteLine("Две прямые параллельны");
}
else if(k1==k2 && b1==b2)
{

    Console.WriteLine("Две прямые совпадают");

}
else

{
  double x = (b2-b1)/(k1 - k2);
  double y = k1* x + b1;


  Console.WriteLine($" Две прямые пересекаются в точке с координатами X:(x),Y(y)");

   
}
*/

// Задача 2. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввел пользователь.
/*

Console.WriteLine("Введите числа:");
string numbers = Console.ReadLine();
// нам нужно перебрать каждый элемент строки, если это запятая или пробел делаем ++
string[] newNumbers = new string
[numbers.Length];
int k = 0;
for(int i = 0; i< newNumbers.Length; i++)
{
    if (numbers[i] ==',' )
{
   k++; 
}
else
{
    newNumbers[k]= newNumbers[k] + $"{numbers[i]}";
}
}
k++;
int[]resultNumbers = new int[k];
PrintArray(resultNumbers,newNumbers);
int sum =0;
for (int i = 0; i <k; i++)
{
  
  if(resultNumbers[i]>0)
  {
    sum++;
  }

}
 Console.WriteLine(" Количество чисел больше 0" +sum);
  void PrintArray (int[] array, string[] string1)
  {
for (int i =0; i < array.Length;i++)
{
    array[i]= Convert.ToInt32(string1[i]);
    Console.Write(array[i]+ " ");
}

Console.WriteLine();

  }
  */
  // Домашняя работа 7.

  // Задвча 1. Задайте двумерный массив m*n, заполненный случйными вещественными числами.
  /*

  void FiIIArray (double[,]array)
  {
     for( int i = 0; i < array.GetLength(0); i++) 
     {
        for( int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new
      Random().NextDouble();
        }
     } 
  }
void PrintArray (double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i ++)
    {
      for(int j = 0; j < array.GetLength(1); j ++)  
      {
Console.Write($"{array[i,j]}");
    }
 } 
}  
int m = 5;
int n = 4;
double[,]array = new double[ m,n];
FiIIArray(array);
PrintArray(array);
*/
 // Задача 2.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
 /*

 void FiIIArray(int[,]array)
 {
    for(int m = 0; m<array.GetLength(0);m++)
    {
        for(int n = 0; n<array.GetLength(1);n++)
        {
           array[m,n] = new Random().Next(1,20);
        }
    }
 }
void PrintArray(int[,]array)
{
    for(int m = 0 ; m<array.GetLength(0);m++)
    {
        for(int n = 0 ; n<array.GetLength(1);n++)
        {
            Console.Write($"{array[m,n]} ");
        }
    }
}
string ArithmeticMean(int[,]array)
{
    string result= string.Empty;
    for(int n = 0; n < array.GetLength(1); n++)
  {
   int sum = 0;
   int count = 0;
   double mean = 0;
   for(int m =0; m < array.GetLength(0); m ++)
{
    sum += array[m,n];
    count++;

}
mean = sum/count;
result+=mean.ToString() +" ";

}
return result;
}
int m = 5;
int n= 5;
int[,] array = new int[m,n];


FiIIArray(array);
PrintArray(array);
Console.WriteLine();
Console.WriteLine(ArithmeticMean(array));
*/
// Задача3. Напишите программу которая на вход принимает позиции элемента в двумерном массиве и возвращает значение этого элемента или же указание что этого элемента нет.
/*
 
 void FiIIArray(int[,]array)
 {
    for(int m = 0;  m< array.GetLength(0);m++)
    {
        for(int n = 0; n< array.GetLength(1); n++)
        {
            array[m,n]= new Random().Next(1,20);

        }
    }
 }
 void PrintArray(int[,]array)
 {
    for(int m = 0;m<array.GetLength(0);m++)
    {
        for(int n = 0;n<array.GetLength(1);n++)
        {
           Console.Write($"{array[m,n]} ");
        }
        Console.WriteLine();

    }
 }
int m = 5;
int n = 5;
int[,] array = new int[m,n];

FiIIArray(array);
PrintArray(array);
 
Console.WriteLine(" Введите число");
int num = int.Parse(Console.ReadLine());
string Position(int[,]array)
{
    string result = string.Empty;
    for(int m = 0; m <array.GetLength(0);m++)
    {
        for(int n =0; n<array.GetLength(1);n++)

        {
            if(num ==array[m,n]) result += $"{m},{n}";

        }
    }
    if (result==string.Empty) result = "Такого элемента нет";
       return result;


}
Console.WriteLine(Position(array))
*/



                  // Домашняя работа 8.


  // Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит по убиванию элементы каждой строки двумерного массива.
  /*


   int[,] table = new int[3,4];
   FillArrayRandom(table);
   PrintArray(table);
   SortTolower(table);
   Console.WriteLine();
   PrintArray(table);

   //Функция заполнения массива рандомно числами от 1 до 9
   void FillArrayRandom(int[,] array)
   {
    for (int i = 0; i < array.GetLength(0); i++)
    {
      for (int j = 0; j < array.GetLength(1); j++)
      {
        array[i,j] = new Random().Next(1,10);
      }
    }
   }
// Функция сортировки элементов в строке двумерного массива, по убиванию 
void SortTolower(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
{
  for(int j = 0; j < array.GetLength(1); j++)
{
for (int k = 0; k < array.GetLength(1) -1; k++)
{
  if(array[i,k] < array[i,k + 1])
  {
    int temp = array[i, k + 1];
    array[i, k + 1]= array[i,k];
    array[i,k] = temp;
  }
  }
 }
 }
}
 // Функция вывода двумерного  массива
 void PrintArray(int[,] array)
 {
  for(int i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j < array.GetLength(1); j++)
    {
      Console.WriteLine($" {array[i,j]}");
    }
    Console.WriteLine();
  }
 }
*/
// Задача 2. Задайте прямоугольный двумерный массив.Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*

int[,] table = new int [4,4];
FillArrayRandom(table);
PrintArray(table);
Console.WriteLine();
NumberRowMinSumElements(table);

//Функция вывода  номера строки ( не индекса) с наименьшей суммой элементов 

void
NumberRowMinSumElements(int[,] array)
{
  int minRow = 0;
  int minSumRow = 0;
  int sumRow = 0;
  for (int i = 0; i < table.GetLength(1); i++)
  {
    minRow += table[0,i];        
  }
  for(int i = 0; i < table.GetLength(0); i++)
{
for(int j = 0; j < table.GetLength(1); j++) sumRow +=table[i,j];
if (sumRow < minRow)
{
  minRow = sumRow;
  minSumRow = 1;
}
sumRow = 0;
}
Console.Write($"{ minSumRow +1} строка");
}   
// функция вывода двумерного массива 
void PrintArray(int[,]array)
{
  for (int  i = 0; i < array.GetLength(0); i++)
  {
    for(int j = 0; j <array.GetLength(1); j++)
    {
     Console.Write($" { array [i,j]} ");
    }
    Console.WriteLine();
  }
}

  //Функция заполнения массива рандомно числами от 1 до 9
  void FillArrayRandom(int[,]array)
  {
    for (int i = 0; i <  array.GetLength(0); i++)
    {
    for(int j =0; j < array.GetLength(1); j++)
    {
      array[i,j] = new
      Random().Next(1,10);
    }
    }
  }
  */
  //Задача 3.Задайте две матрицы, напишите программу которая будет находить произведение двух матриц.
  /*

  Console.WriteLine("Введите размер матриц и диопозон случайных значений");
  int m = inputNumbers("Введите число строк 1-й матрицы:");
  int n = inputNumbers("Введите число столбцов 1-й матрицы ( и строк 2-й) ");
  int p = inputNumbers("Введите число 2-й матрицы: ");
  int range = inputNumbers("Введите диопозон случайных чисел: от 1 до");

  int[,] firstMartrix = new int[ m,n ];
  CreateArray(firstMartrix);
  Console.WriteLine($"Первая матрица:");
  WriteArray(firstMartrix);

  int[,] secomdMartrix = new int[n,p];
  CreateArray(secomdMartrix);
  Console.WriteLine($"Вторая матрица: ");
  WriteArray(secomdMartrix);
  

  int[,] resultMatrix = new int[m,p];

  MultipiyMatrix(firstMartrix,secomdMartrix,resultMatrix);
  Console.WriteLine($"Произведение первой и второй матрицы:");
  WriteArray(resultMatrix);

void MultipiyMatrix(int[,]fristMartrix,int[,]secomdMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for(int k = 0; k < fristMartrix.GetLength(1); k++)
      {
        sum +=fristMartrix[i,k]* secomdMartrix[k,j];

      }
      resultMatrix[i,j] = sum;

    }
  }
}
int inputNumbers(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;

}
void CreateArray(int[,] array)
{
for(int i=0;  i < array.GetLength(0); i++)
{
  for(int j=0; j < array.GetLength(1); j++)
  {
    array[i,j] = new
    Random().Next(range);
  }
}
}
void WriteArray(int[,] array)
{
  for(int i=0; i < array.GetLength(0); i++)
  {
  for(int j=0; j < array.GetLength(1); j++)
  {
    Console.Write(array[i,j] +"");
  }
  Console.WriteLine();
  }
}
*/

                  //Домашняя работа 9.
  
  // Задача 1. Задайте значение N. Напишите программу которая выведит все натуральные числа в промежутке от N до 1.
  /*

  int n = Inputint("Введите  положительное число ");
  int m = 1;
  if ( n < 1)
  {
    Console.Write("Ввели не положительное число ");
  }
  Console.WriteLine(NaturalNumber(n,m));
  int NaturalNumber(int n,int m)
  {
    if ( n==m)
    return m;
    else

    Console.Write($" {NaturalNumber(n,m +1)}, ");
    return m;
  }
int Inputint(string output)
{
  Console.Write(output);
  return
  int.Parse(Console.ReadLine());

}
*/

   
// Задача 2.Задайте значение M и N .Напишите программу которая найдет сумму натуральных элементов от M до N.  
/*
int m = inputint(" Введите M:");
int n = inputint(" Введите N:");
Console.WriteLine($"Сумма элементов от {m} до {n}  =  { CountNaturalSum(m,n)}");

int inputint(string output)
{
  Console.Write(output);
  return
  int.Parse(Console.ReadLine());
}
int CountNaturalSum( int m, int n)
{
  if (m==n)
  return n;
  return n + CountNaturalSum(m,n -1);
}
*/ 
// Напишите программу вычисления функции Аккермана с помощью рекруссии. Даны не отрицательные числа  m и n.

int Ackerman ( int m ,int n ) 
{
  if (m ==0) return (n +1);
  else if (m==0) return
  Ackerman(m -1,1);
  else return Ackerman(m -1, Ackerman (m , n -1));
}
Console.WriteLine(" Inputm:");
int m =
int.Parse(Console.ReadLine());
Console.WriteLine(" Input n:");
int n =
int. Parse(Console.ReadLine());
Console.Write($" Значение функции Ackerman( {m} .{n}) равно: ");
Console.WriteLine(Ackerman(m,n));











 
  














































