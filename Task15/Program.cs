﻿//task 15
Console.Clear();
Console.Write("Введите номер дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
while (n < 1 || n > 7)
{
    Console.Write("Вы ошиблись! Введите день недели: ");
    n = Convert.ToInt32(Console.ReadLine());
}
if (n == 6 ||  n == 7)
    Console.WriteLine("Да, это выходной день");
else 
    Console.WriteLine("Нет, это рабочий день");