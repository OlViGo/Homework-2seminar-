// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет
Console.Write("Введите цифру,обозначающую дни недели");
int numberWeek = int.Parse(Console.ReadLine());
if (numberWeek == 6) 
{
 Console.WriteLine($"{numberWeek} является выходным днем");
}
else if (numberWeek == 7) 
{
 Console.WriteLine($"{numberWeek} является выходным днем");
}
else 
{
 Console.WriteLine($"{numberWeek}  не является выходным днем"); 
}