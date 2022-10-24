// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет   
// 32679 -> 6

Console.Write("Введите любое число: ");
int number = Convert.ToInt32(Console.ReadLine());

int count = 0;
while (number >= 1000)
{
    number = number / 10;
    count++;
}
if (number < 100)
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    Console.WriteLine($"третьей цифрой является {number % 10}");
}