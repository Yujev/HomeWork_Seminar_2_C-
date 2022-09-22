/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
Console.WriteLine("Введите любое число: ");
int number1 = int.Parse(Console.ReadLine());
int number2 = ((number1 / 100) % 10);

if (number2 != 0)
{
    Console.WriteLine($"Третья цифра этого числа: {number2}");
}
else
{
    Console.WriteLine($"Третьей цифры нет");
}