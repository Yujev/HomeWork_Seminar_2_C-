/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/
/*Моё решение
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
*/
// Решение от Софьи:

Console.WriteLine("Выбери вариант решения: ");
int chosenNumber = int.Parse(Console.ReadLine());

if (chosenNumber == 1)
{
    Console.Write("Введи число: ");
    int num = int.Parse(Console.ReadLine());
    if (num < 100)
    {
        Console.WriteLine($"Третьей цифры нет");
        return;
    }
    int thirdNumber = 0;
    if (num > 99 && num < 1000)
    {
        thirdNumber = (num % 100) % 10;
    }
    if (num > 99 && num < 10000)
    {
        thirdNumber = (num % 100) % 10;
    }
    if (num > 99 && num < 100000)
    {
        thirdNumber = (num % 1000) % 100;
    }
    if (num > 99 && num < 1000000)
    {
        thirdNumber = (num % 10000) % 1000;
    }
    Console.WriteLine($"Третья цифра числа {num} -> {thirdNumber}");
}