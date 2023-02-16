/* Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если второе число не кратно числу первому, то программа выводит остаток от деления */
Console.Clear();
Console.WriteLine("ВВедите первое число ");
int a1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ВВедите Второе число ");
int a2 = Convert.ToInt32(Console.ReadLine());
if(a2 % a1 == 0)
    {Console.WriteLine("второе число кратно первому "); }
    else
    {int result = a2 % a1;
    Console.WriteLine($"остаток от деления -> {result}" );}