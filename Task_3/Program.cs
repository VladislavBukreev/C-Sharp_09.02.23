// Напишите программу, которая принимает на вход число и проверяет кратно ли оно одновременно 7 и 23.


/*int a = 5;
int b = 6;
int c = 8;
int x = 10;
if((a > b || a < c) && (x > b || x < c))
      0    +    0         1    +   0
            0         *         1
                       0(Folse)
        
Console.WriteLine("Pidor");
else
Console.WriteLine("Gandon");
*/

Console.Clear();
Console.WriteLine("Введите число ");
int a = Convert.ToInt32(Console.ReadLine()); 
if((a % 7 == 0) && (a % 23 == 0))
Console.WriteLine("Ваше ебучее число кратное блять  и 7 и 23 ");
else
Console.WriteLine("Ваше ебучее число нихуя НЕкратное  ни 7 ни 23, ПНХ ");