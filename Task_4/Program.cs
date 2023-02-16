// Напишите программу, которая принимает на вход два числа и проверяет  является ли одно число квадратом другого.
Console.Clear();
Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());
if(a * a == b)
Console.WriteLine("Да является квадратом ");
else 
Console.WriteLine("Нет не является квадратом ");
