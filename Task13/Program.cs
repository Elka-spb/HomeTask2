//task 13
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n < 100)
Console.WriteLine("Третьей цифры у заданного числа нет.");
else 
{
while (n > 999) n = n/10;
Console.WriteLine("Третья цифра в заданном числе: " + n % 10);
};