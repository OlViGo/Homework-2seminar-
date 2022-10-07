// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Write("Введите число");
int num = int.Parse(Console.ReadLine());
int last_digit = num%1000;
int third_digit =last_digit/100;
Console.WriteLine($"{third_digit}.");


// Console.WriteLine($"{third_digit}не существует."); 
// int third_digit = num/last_digit;
// if (last_digit > 2)
// {
//  Console.WriteLine($"{third_digit}не существует.");  
// }

// if (num>2)
// {
// Console.WriteLine($"{num}.");   
// }
// else
// {
// Console.WriteLine("Третьей цифры нет"); 
// }

 
